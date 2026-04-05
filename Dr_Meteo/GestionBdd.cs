using System.Data.SQLite;
using System.Data;
using Newtonsoft.Json;

namespace Dr_Meteo
{
    public class GestionBdd
    {
        private const string DatabaseFileName = "MeteoDatabase.db";
        private const string ConnectionString = @"Data Source=MeteoDatabase.db;version=3";
        public static void InitialiserBase()
        {
            if (!File.Exists(DatabaseFileName))
            {
                SQLiteConnection.CreateFile(DatabaseFileName);
            }
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string createTableQuery = "CREATE TABLE IF NOT EXISTS TableVille (Id INTEGER PRIMARY KEY AUTOINCREMENT, Nom TEXT NOT NULL, " +
                    "CodePostal TEXT, Latitude REAL, Longitude REAL, DonneesJson TEXT, DerniereMaj TIME)";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
                createTableQuery = "CREATE TABLE IF NOT EXISTS Utilisateurs (Id INTEGER PRIMARY KEY AUTOINCREMENT, NomUtilisateur TEXT NOT NULL UNIQUE, " +
                    "MotDePasse TEXT NOT NULL, EMail TEXT, VilleFavorite TEXT)";
                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static DataTable GetVilles()
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            string requete = "SELECT Nom,CodePostal FROM TableVille";
            var commande = new SQLiteCommand(requete, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(commande);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return (dataTable);
        }

        //Récupération des données d'une ville
        public static VilleData RecupererVille(string nomVille)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM TableVille WHERE Nom = @Nom";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nom", nomVille);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new VilleData
                            {
                                //Les ID SQLite sont souvent renvoyés en Int64 (long), Convert règle ce problème
                                Id = Convert.ToInt32(reader[0]),

                                Nom = reader[1].ToString(),

                                CodePostal = reader.IsDBNull(2) ? "" : reader[2].ToString(),

                                //Convert.ToDouble acceptera la valeur même si SQLite la renvoie comme un float ou un string
                                Latitude = reader.IsDBNull(3) ? 0 : Convert.ToDouble(reader[3]),
                                Longitude = reader.IsDBNull(4) ? 0 : Convert.ToDouble(reader[4]),

                                DonneesJson = reader.IsDBNull(5) ? "" : reader[5].ToString(),

                                //Utilisation de DateTime.TryParse pour éviter tout crash si la date est mal formatée
                                DerniereMaj = reader.IsDBNull(6) || string.IsNullOrWhiteSpace(reader[6].ToString())
                                        ? DateTime.MinValue
                                        : (DateTime.TryParse(reader[6].ToString(), out DateTime parsedDate) ? parsedDate : DateTime.MinValue)
                            };
                        }
                    }
                }
                connection.Close();
            }
            return null; //Ville non trouvée
        }
        //Ajout ou mise à jour d'une ville
        public static void MajVille(string nomVille, double lat, double lon, string json)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = @"UPDATE TableVille SET Latitude=@lat, Longitude=@lon, DonneesJson=@json, DerniereMaj=@date
                    WHERE nom=@nom";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", nomVille);
                    command.Parameters.AddWithValue("@lat", lat);
                    command.Parameters.AddWithValue("@lon", lon);
                    command.Parameters.AddWithValue("@json", json);
                    command.Parameters.AddWithValue("@date", DateTime.Now);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }

        }


        public async Task ImporterVillesDepuisApiGouv()
        {
            //Vérification si la base est déjà remplie pour ne pas retélécharger à chaque fois
            using (var connexion = new SQLiteConnection(ConnectionString))
            {
                connexion.Open();
                using (var cmdVerif = new SQLiteCommand("SELECT COUNT(*) FROM TableVille", connexion))
                {
                    long nbVilles = (long)cmdVerif.ExecuteScalar();
                    if (nbVilles > 0) return; // La base est déjà remplie, on arrête là !
                }
            }

            //Téléchargement des données depuis l'API du gouvernement
            string url = "https://geo.api.gouv.fr/communes?fields=nom,codesPostaux,centre&format=json&geometry=centre";

            using (HttpClient client = new HttpClient())
            {
                string jsonResponse = await client.GetStringAsync(url);

                //On transforme le gros texte JSON en une liste d'objets C#
                List<CommuneGouv> communes = JsonConvert.DeserializeObject<List<CommuneGouv>>(jsonResponse);

                //On insère tout dans la base de données à la vitesse de l'éclair
                using (var connexion = new SQLiteConnection(ConnectionString))
                {
                    connexion.Open();

                    using (var transaction = connexion.BeginTransaction())
                    {
                        string sql = "INSERT INTO TableVille (Nom, CodePostal, Latitude, Longitude) VALUES (@nom, @cp, @lat, @lon)";
                        using (var cmd = new SQLiteCommand(sql, connexion, transaction))
                        {
                            cmd.Parameters.Add(new SQLiteParameter("@nom"));
                            cmd.Parameters.Add(new SQLiteParameter("@cp"));
                            cmd.Parameters.Add(new SQLiteParameter("@lat", System.Data.DbType.Double)); //Force en nombre à virgule (REAL)));
                            cmd.Parameters.Add(new SQLiteParameter("@lon", System.Data.DbType.Double));

                            foreach (var commune in communes)
                            {
                                cmd.Parameters["@nom"].Value = commune.nom;

                                //Transforme la liste des codes postaux en texte séparé par des virgules
                                cmd.Parameters["@cp"].Value = commune.codesPostaux != null ? string.Join(", ", commune.codesPostaux) : "";

                                if (commune.centre != null && commune.centre.coordinates != null && commune.centre.coordinates.Count >= 2)
                                {
                                    cmd.Parameters["@lon"].Value = commune.centre.coordinates[0];
                                    cmd.Parameters["@lat"].Value = commune.centre.coordinates[1];
                                }
                                else
                                {
                                    cmd.Parameters["@lon"].Value = 0;
                                    cmd.Parameters["@lat"].Value = 0;
                                }

                                cmd.ExecuteNonQuery();
                            }
                        }
                        //On valide l'enregistrement global
                        transaction.Commit();
                    }
                }
            }
        }
        //Partie Utilisateurs
        public static void CreerUtilisateur(string nomUtilisateur, string motDePasse, string villeFavorite)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO Utilisateurs (NomUtilisateur, MotDePasse, VilleFavorite) VALUES (@nomUtilisateur, @motDePasse, @villeFavorite)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                    command.Parameters.AddWithValue("@motDePasse", motDePasse);
                    command.Parameters.AddWithValue("@villeFavorite", villeFavorite);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static bool UtilisateurExiste(string nomUtilisateur)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Utilisateurs WHERE NomUtilisateur = @nomUtilisateur";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                    long count = (long)command.ExecuteScalar();
                    connection.Close();
                    return count > 0; //Retourne true si l'utilisateur existe
                }
            }
        }

        public static string GetVilleFavorite(string nomUtilisateur)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT VilleFavorite FROM Utilisateurs WHERE NomUtilisateur = @nomUtilisateur";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                    object result = command.ExecuteScalar();
                    return ((string) result);
                }
            }
        }
        public static void MettreAJourVilleFavorite(string nomUtilisateur, string nouvelleVilleFavorite)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Utilisateurs SET VilleFavorite = @nouvelleVilleFavorite WHERE NomUtilisateur = @nomUtilisateur";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nouvelleVilleFavorite", nouvelleVilleFavorite);
                    command.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static void MettreAJourMotDePasse(string nomUtilisateur, string nouveauMotDePasse)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Utilisateurs SET MotDePasse = @nouveauMotDePasse WHERE NomUtilisateur = @nomUtilisateur";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nouveauMotDePasse", nouveauMotDePasse);
                    command.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static void SupprimerUtilisateur(string nomUtilisateur)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Utilisateurs WHERE NomUtilisateur = @nomUtilisateur";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        public static List<string> GetTousUtilisateurs()
        {
            List<string> utilisateurs = new List<string>();
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT NomUtilisateur FROM Utilisateurs";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            utilisateurs.Add(reader[0].ToString());
                        }
                    }
                }
                connection.Close();
            }
            return utilisateurs;
        }
        public static string GetEmail(string nomUtilisateur)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT EMail FROM Utilisateurs WHERE NomUtilisateur = @nomUtilisateur";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomUtilisateur", nomUtilisateur);
                    object result = command.ExecuteScalar();
                    if(result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null; //Retourne null si l'utilisateur n'existe pas ou n'a pas d'email
                    }
                }
            }
        }

        //Mettre à jour l'e-mail de l'utilisateur qui vient de s'inscrire
        public static void EnregistrerEmail(string pseudo, string email)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "UPDATE Utilisateurs SET Email = @email WHERE NomUtilisateur = @pseudo";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@pseudo", pseudo);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        //Ajoute d'une ville dans ses favoris
        public static void AjouterVilleFavorite(string pseudo, string ville)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                // On cherche l'ID de l'utilisateur grâce à son pseudo pour faire la liaison
                string query = "UPDATE Utilisateurs SET VilleFavorite = @ville WHERE NomUtilisateur = @pseudo";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@pseudo", pseudo);
                    command.Parameters.AddWithValue("@ville", ville);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }

        public static bool VerifierIdentifiants(string pseudo, string mdp)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Utilisateurs WHERE NomUtilisateur=@pseudo AND MotDePasse=@mdp";
                using (var commande = new SQLiteCommand(query, connection))
                {
                    commande.Parameters.AddWithValue("@pseudo", pseudo);
                    commande.Parameters.AddWithValue("@mdp", mdp);
                    long count = (long)commande.ExecuteScalar();
                    if (count > 0)
                    {
                        return (true);
                    }
                    else
                    {
                        return (false);
                    }
                }
            }
        }

        public static bool VilleExiste(string nomVille)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM TableVille WHERE Nom=@nomVille";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomVille", nomVille);
                    long count = (long)command.ExecuteScalar();
                    return count > 0; //Retourne true si la ville existe
                }
            }


        }
        public static string GetCodePostal(string nomville)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                string query = "SELECT CodePostal FROM TableVille WHERE Nom=@nomville";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nomville", nomville);
                    connection.Open();
                    object result = command.ExecuteScalar();
                    connection.Close();
                    if (result != null)
                    {
                        return((string)result);
                    }
                    else
                    {
                        return ""; //Retourne une chaîne vide si la ville n'existe pas ou n'a pas de code postal
                    }
                }
            }
        } 
    }
}
//Classe pour transporter les données de la Bdd
public class VilleData
{
    public int Id { get; set; }
    public string Nom { get; set; }
    public string CodePostal { get; set; }
    public double Latitude { get; set; }
    public double Longitude { get; set; }
    public string DonneesJson { get; set; }
    public DateTime DerniereMaj { get; set; }
}

//Pour lire la réponse de l'API geo.api.gouv.fr
public class CommuneGouv
{
    public string nom { get; set; }
    public List<string> codesPostaux { get; set; }
    public PointCentre centre { get; set; }
}

public class PointCentre
{
    // L'API renvoie un tableau [Longitude, Latitude]
    public List<double> coordinates { get; set; }
}

