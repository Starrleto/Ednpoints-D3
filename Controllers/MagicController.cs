using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RasuliEEndpointsD3.Services.MagicBall;

namespace RasuliEEndpointsD3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MagicController
    {
        private readonly IMagicBallService _magicService;

        public MagicController(IMagicBallService i)
        {
            _magicService = i;
        }
        [HttpGet]
        [Route("GetAnswer")]
        public string playEasy(){
            return _magicService.getAnswer();
        }

    }
}