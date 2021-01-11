using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class GamesController
    {
      

        private readonly ILogger<GamesController> _logger;

        public GamesController(ILogger<GamesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("games")]
        public string  Get()
        {
            List<Games> games = new List<Games>();
            games.Add(new Games(1, "Poszukiwanie Szopa","Dane", new DateTime(2020, 12, 19)));
            games.Add(new Games(2, "Poszukiwanie Skarbu", "Dane", new DateTime(2020, 12, 19)));
            games.Add(new Games(3, "Poszukiwanie Rzeczy", "Dane", new DateTime(2020, 12, 19)));
            games.Add(new Games(4, "Poszukiwanie Czegoś", "Dane", new DateTime(2020, 12, 19)));
            games.Add(new Games(5, "Poszukiwanie Terenowe", "Dane", new DateTime(2020, 12, 19)));

           var dd= JsonConvert.SerializeObject(games, Formatting.Indented);
            System.Diagnostics.Debug.WriteLine("Poszło");
            return dd;
        }
    }
}
