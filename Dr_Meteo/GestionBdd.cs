using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
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
                connection.Close();
            }
        }
        public static DataTable GetData()
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            string requete = "SELECT Nom FROM TableVille";
            var commande = new SQLiteCommand(requete, connection);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(commande);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();
            return (dataTable);
        }

        public static void Ajouter_Ville(string Ville)
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            string verification = "SELECT COUNT(*) FROM TableVille WHERE Nom=@Ville";
            using (var verificationCommande = new SQLiteCommand(verification, connection))
            {
                verificationCommande.Parameters.AddWithValue("@Ville", Ville);
                long count = (long)verificationCommande.ExecuteScalar();
                if (count > 0)
                { // La ville existe déjà, ne pas l'ajouter
                    connection.Close();
                    return;
                }
            }
            string requete = "INSERT INTO TableVille (Nom, Latitude, Longitude, DonneesJson, DerniereMaj) VALUES (@Ville, 0.0, 0.0, 0.0)";
            var commande = new SQLiteCommand(requete, connection);
            commande.Parameters.AddWithValue("@Ville", Ville);
            commande.ExecuteNonQuery();
            connection.Close();
        }

        public static void Supprimer_Ville(string Ville)
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            string requete = "DELETE FROM TableVille WHERE Nom=@Ville";
            var commande = new SQLiteCommand(requete, connection);
            commande.Parameters.AddWithValue("@Ville", Ville);
            commande.ExecuteNonQuery();
            connection.Close();
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
                                // Les ID SQLite sont souvent renvoyés en Int64 (long), Convert règle ce problème
                                Id = Convert.ToInt32(reader[0]),

                                Nom = reader[1].ToString(),

                                CodePostal = reader.IsDBNull(2) ? "" : reader[2].ToString(),

                                // Convert.ToDouble acceptera la valeur même si SQLite la renvoie comme un float ou un string
                                Latitude = reader.IsDBNull(3) ? 0 : Convert.ToDouble(reader[3]),
                                Longitude = reader.IsDBNull(4) ? 0 : Convert.ToDouble(reader[4]),

                                DonneesJson = reader.IsDBNull(5) ? "" : reader[5].ToString(),

                                // Utilisation de DateTime.TryParse pour éviter tout crash si la date est mal formatée
                                DerniereMaj = reader.IsDBNull(6) || string.IsNullOrWhiteSpace(reader[6].ToString())
                                        ? DateTime.MinValue
                                        : (DateTime.TryParse(reader[6].ToString(), out DateTime parsedDate) ? parsedDate : DateTime.MinValue)
                            };
                        }
                    }
                }
                connection.Close();
            }
            return null; // Ville non trouvée
        }
        // Ajout ou mise à jour d'une ville
        public static void MajVille(string nomVille, string codePostaux, double lat, double lon, string json)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                // "INSERT OR REPLACE" permet de créer la ville si elle n'existe pas, ou de la mettre à jour
                string query = @"INSERT OR REPLACE INTO TableVille (Nom, CodePostal, Latitude, Longitude, DonneesJson, DerniereMaj) 
                    VALUES (@nom ,@codePostaux, @lat, @lon, @json, @date)";
                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", nomVille);
                    command.Parameters.AddWithValue("@codePostaux", codePostaux);
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
            // 1. On vérifie si la base est déjà remplie pour ne pas retélécharger à chaque fois
            using (var connexion = new SQLiteConnection(ConnectionString))
            {
                connexion.Open();
                using (var cmdVerif = new SQLiteCommand("SELECT COUNT(*) FROM TableVille", connexion))
                {
                    long nbVilles = (long)cmdVerif.ExecuteScalar();
                    if (nbVilles > 0) return; // La base est déjà remplie, on arrête là !
                }
            }

            // 2. On télécharge les données depuis l'API du gouvernement
            string url = "https://geo.api.gouv.fr/communes?fields=nom,codesPostaux,centre&format=json&geometry=centre";

            using (HttpClient client = new HttpClient())
            {
                string jsonResponse = await client.GetStringAsync(url);

                // On transforme le gros texte JSON en une liste d'objets C#
                List<CommuneGouv> communes = JsonConvert.DeserializeObject<List<CommuneGouv>>(jsonResponse);

                // 3. On insère tout dans la base de données à la vitesse de l'éclair
                using (var connexion = new SQLiteConnection(ConnectionString))
                {
                    connexion.Open();

                    // La TRANSACTION est la clé de la rapidité
                    using (var transaction = connexion.BeginTransaction())
                    {
                        string sql = "INSERT INTO TableVille (Nom, CodePostal, Latitude, Longitude) VALUES (@nom, @cp, @lat, @lon)";
                        using (var cmd = new SQLiteCommand(sql, connexion, transaction))
                        {
                            // On prépare les paramètres une seule fois
                            cmd.Parameters.Add(new SQLiteParameter("@nom"));
                            cmd.Parameters.Add(new SQLiteParameter("@cp"));
                            cmd.Parameters.Add(new SQLiteParameter("@lat", System.Data.DbType.Double)); // Force en nombre à virgule (REAL)));
                            cmd.Parameters.Add(new SQLiteParameter("@lon", System.Data.DbType.Double)); // Force en nombre à virgule (REAL)));

                            foreach (var commune in communes)
                            {
                                cmd.Parameters["@nom"].Value = commune.nom;

                                // Transforme la liste des codes postaux en texte séparé par des virgules
                                cmd.Parameters["@cp"].Value = commune.codesPostaux != null ? string.Join(", ", commune.codesPostaux) : "";

                                //Longitude en premier !
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
                        // On valide l'enregistrement global
                        transaction.Commit();
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

