using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasuliEEndpointsD3.Services.Guessing
{
    public interface IGuessingService
    {
        public string playEasy(string guess);
        public string playMed(string guess);
        public string playHard(string guess);
    }
}