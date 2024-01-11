using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasuliEEndpointsD3.Services.Restauraunt
{
    public interface IRestaurauntPicker
    {
        public string getRestauraunt(string name);
        public string asianFood();
        public string mexicanFood();
        public string americanFood();
    }
}