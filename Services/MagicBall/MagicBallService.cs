using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasuliEEndpointsD3.Services.MagicBall
{
    public class MagicBallService : IMagicBallService
    {
        string[] answers = new string[]{"Yes", "No", "Maybe", "Ask again later", "Probably not", "Cannot be determined yet", "Doubtful", "Most likeley"};
        public string getAnswer(){
            Random r = new Random();
            return answers[r.Next(0, answers.Length)];
        }
    }
}