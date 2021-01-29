using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Web;

namespace dream_of_electric_sheep
{
    public class CryptoPrices
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        private static string API_KEY = Environment.GetEnvironmentVariable("COIN_MARKET_CAP_API_KEY");

        static string makeAPICall()
            {
                var URL = new UriBuilder("https://pro-api.coinmarketcap.com/v1/cryptocurrency/listings/latest");

                var queryString = HttpUtility.ParseQueryString(string.Empty);
                queryString["start"] = "1";
                queryString["limit"] = "5000";
                queryString["convert"] = "USD";

                URL.Query = queryString.ToString();

                var client = new WebClient();
                client.Headers.Add("X-CMC_PRO_API_KEY", API_KEY);
                client.Headers.Add("Accepts", "application/json");
                return client.DownloadString(URL.ToString());

            }
    }
}