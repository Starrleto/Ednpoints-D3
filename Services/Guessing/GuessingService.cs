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
            int num = ran.Next(1, 11);
            if(int.TryParse(guess, out numGuess)){
                if(numGuess < 1 || numGuess > 10)
                    return "Please enter a number only between 1-10.";

                if(numGuess > num)
                    return "Lower";
                else if (numGuess < num)
                    return "Higher";
                else
                    return "You guessed it";
            }
            else
                return "Please enter an integer between 1-10";
        }
        public string playMed(string guess){
            int numGuess;
            Random ran = new Random();
            int num = ran.Next(1, 51);
            if(int.TryParse(guess, out numGuess)){
                if(numGuess < 1 || numGuess > 50)
                    return "Please enter a number only between 1-50.";

                if(numGuess > num)
                    return "Lower";
                else if (numGuess < num)
                    return "Higher";
                else
                    return "You guessed it";
            }
            else
                return "Please enter an integer between 1-50";
        }
        public string playHard(string guess){
            int numGuess;
            Random ran = new Random();
            int num = ran.Next(1, 101);
            if(int.TryParse(guess, out numGuess)){
                if(numGuess < 1 || numGuess > 100)
                    return "Please enter a number only between 1-100.";

                if(numGuess > num)
                    return "Lower";
                else if (numGuess < num)
                    return "Higher";
                else
                    return "You guessed it";
            }
            else
                return "Please enter an integer between 1-100";
        }
    }
}