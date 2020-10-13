using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dream_of_electric_sheep.Controllers
{
    [ApiController]
    [Route("cryptoprices")]
    public class CryptoPricesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" //update
        };

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
    }
}
