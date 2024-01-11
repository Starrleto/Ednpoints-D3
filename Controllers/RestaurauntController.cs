using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RasuliEEndpointsD3.Services.Restauraunt;

namespace RasuliEEndpointsD3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurauntController
    {
        private readonly IRestaurauntPicker _restaurauntService;

        public RestaurauntController(IRestaurauntPicker i)
        {
            _restaurauntService = i;
        }
        [HttpGet]
        [Route("FindRestauraunt/{type}")]
        public string find(string type){
            return _restaurauntService.getRestauraunt(type);
        }


    }
}