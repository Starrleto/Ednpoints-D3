using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasuliEEndpointsD3.Services.Restauraunt
{
    public class RestaurauntPicker : IRestaurauntPicker
    {
        string[] asian = new string[]{"Panda Express", "Katana", "Daraman Ramen", "Golden China", "Chong's Cuisine", "Thai Cuisine", "Tasty Thai", "Samurai Sushi", "Fuji Sushi", "Hangry Sumos"};

        string[] mexican = new string[]{"Mariachis Mexican Restauraunt", "El Charro", "El Asadero Taco Shop", "El Rosal", "Mundo's Latin Grill", "Taco Bell", "Mario's Authentic Tacos", "Tacos El Hidalguense", "Tacos Aviña", "Las Casuelas"};

        string[] american = new string[]{"Chili's", "KFC", "AJ's Cafe and Grill", "Huckleberry's", "Black Bear Diner", "Center Street Grill", "McDonalds", "Wendy's", "My Garden Cafe", "Table 26"};

        public string getRestauraunt(string name){
            switch(name.ToLower()){
                case "asian": return asianFood(); 
                case "mexican": return mexicanFood(); 
                case "american": return americanFood();
                default: return "Please enter asian, mexican, or american";
            }
        }
        public string asianFood(){
            Random r = new Random();
            return asian[r.Next(0, asian.Length)];
        }

        public string mexicanFood(){
            Random r = new Random();
            return mexican[r.Next(0, mexican.Length)];
        }

        public string americanFood(){
            Random r = new Random();
            return american[r.Next(0, american.Length)];
        }
    }
}