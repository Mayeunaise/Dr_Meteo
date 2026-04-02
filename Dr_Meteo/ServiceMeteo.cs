using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Dr_Meteo
{
    public class ServiceMeteo
    {
        private static readonly HttpClient client = new HttpClient();

        //Trouver la latitude/longitude de la ville
        //Fonction obsolète
        public async Task<VilleResultat> ChercherVille(string nomVille)
        {
            try
            {
                string url = $"https://geocoding-api.open-meteo.com/v1/search?name={nomVille}&count=1&language=fr&format=json";
                var json = await client.GetStringAsync(url);
                var data = JsonConvert.DeserializeObject<ReponseGeocoding>(json);

                if (data.results != null && data.results.Count > 0)
                    return data.results[0];

                return null;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erreur Geocoding : " + ex.Message);
                return null;
            }
        }

        //Avoir la météo via Lat/Lon
        public async Task<ReponseMeteo> ObtenirMeteo(double lat, double lon)
        {
            try
            {
                string sLat = lat.ToString(CultureInfo.InvariantCulture);
                string sLon = lon.ToString(CultureInfo.InvariantCulture);

                //API call
                string url = $"https://api.open-meteo.com/v1/forecast?latitude={sLat}&longitude={sLon}&current=temperature_2m,relative_humidity_2m,wind_speed_10m,surface_pressure,weather_code,is_day&daily=weather_code,temperature_2m_max,temperature_2m_min,sunrise,sunset,uv_index_max&timezone=auto";

                var json = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ReponseMeteo>(json);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("Erreur Météo : " + ex.Message);
                return null;
            }
        }
    }

    public class ReponseGeocoding
    {
        public List<VilleResultat> results { get; set; }
    }

    public class VilleResultat
    {
        public string name { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public string country { get; set; }
        [JsonProperty("postcodes")]
        public List<string> codePostal { get; set; }
    }

    public class ReponseMeteo
    {
        public CurrentData current { get; set; }
        public DailyData daily { get; set; }
    }

    public class CurrentData
    {
        [JsonProperty("temperature_2m")]
        public double temperature { get; set; }

        [JsonProperty("relative_humidity_2m")]
        public int humidity { get; set; }

        [JsonProperty("wind_speed_10m")]
        public double windspeed { get; set; }

        [JsonProperty("surface_pressure")]
        public double pressure { get; set; }

        [JsonProperty("weather_code")]
        public int code_meteo { get; set; }

        public int is_day { get; set; }
        public int uv_index { get; set; }
    }

    public class DailyData
    {
        public List<string> time { get; set; }
        public List<int> weather_code { get; set; }

        [JsonProperty("temperature_2m_max")]
        public List<double> temperature_max { get; set; }

        [JsonProperty("temperature_2m_min")]
        public List<double> temperature_min { get; set; }

        public List<string> sunrise { get; set; }
        public List<string> sunset { get; set; }

        public List<double> uv_index_max { get; set; }
    }
}

