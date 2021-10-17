using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace mywebapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public readonly IScopedService ScopedService1 ;
        private readonly IScopedService scopedService2;
        private readonly ISingletonService singletonService1;
        private readonly ISingletonService singletonService2;
        private readonly ITrasientService trasientService1;
        private readonly ITrasientService trasientService2;

        public WeatherForecastController(ILogger<WeatherForecastController> logger,
        IScopedService scopedService1, IScopedService scopedService2,
        ISingletonService singletonService1, ISingletonService singletonService2,
        ITrasientService trasientService1, ITrasientService trasientService2)
        {
            _logger = logger;
            this.ScopedService1 = scopedService1;
            this.scopedService2 = scopedService2;
            this.singletonService1 = singletonService1;
            this.singletonService2 = singletonService2;
            this.trasientService1 = trasientService1;
            this.trasientService2 = trasientService2;
        }

        

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 1).Select(index => new WeatherForecast
            {
                Summary =
                 this.ScopedService1.ToString() +
                    this.scopedService2.ToString() +
                    this.singletonService1.ToString() +
                    this.singletonService2.ToString() +
                    this.trasientService1.ToString() +
                    this.trasientService2.ToString() 
            })
            .ToArray();
        }
    }
}
