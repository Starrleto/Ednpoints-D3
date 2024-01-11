using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RasuliEEndpointsD3.Services.Guessing;

namespace RasuliEEndpointsD3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GuessingController
    {
        private readonly IGuessingService _guessingService;

        public GuessingController(IGuessingService i)
        {
            _guessingService = i;
        }
        [HttpGet]
        [Route("PlayEasy/{guess}")]
        public string playEasy(string guess){
            return _guessingService.playEasy(guess);
        }
        [HttpGet]
        [Route("PlayMed/{guess}")]
        public string playMed(string guess){
            return _guessingService.playMed(guess);
        }
        [HttpGet]
        [Route("PlayHard/{guess}")]
        public string playHard(string guess){
            return _guessingService.playHard(guess);
        }

    }
}