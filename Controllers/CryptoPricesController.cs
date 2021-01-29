using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Web;

namespace dream_of_electric_sheep.Controllers
{
    [ApiController]
    [Route("cryptoprices")]
    public class CryptoPricesController : ControllerBase
    {
        /*private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" //update
        };*/
        private readonly ILogger<CryptoPricesController> _logger;

        public CryptoPricesController(ILogger<CryptoPricesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<CryptoPrices> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new CryptoPrices
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }

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
