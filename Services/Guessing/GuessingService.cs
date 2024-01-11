using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RasuliEEndpointsD3.Services.Guessing
{
    public class GuessingService : IGuessingService
    {

        public string playEasy(string guess){
            int numGuess;
            Random ran = new Random();
            int num = ran.Next(0, 11);
            if(int.TryParse(guess, out numGuess)){
                if(numGuess > num)
                    return "Lower";
                else if (numGuess < num)
                    return "Higher";
                else
                    return "You guessed it";
            }
            else
                return "Please enter an integer";
        }
        public string playMed(string guess){
            int numGuess;
            Random ran = new Random();
            int num = ran.Next(0, 51);
            if(int.TryParse(guess, out numGuess)){
                if(numGuess > num)
                    return "Lower";
                else if (numGuess < num)
                    return "Higher";
                else
                    return "You guessed it";
            }
            else
                return "Please enter an integer";
        }
        public string playHard(string guess){
            int numGuess;
            Random ran = new Random();
            int num = ran.Next(0, 101);
            if(int.TryParse(guess, out numGuess)){
                if(numGuess > num)
                    return "Lower";
                else if (numGuess < num)
                    return "Higher";
                else
                    return "You guessed it";
            }
            else
                return "Please enter an integer";
        }
    }
}