using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsGuess2
{
    class GuessGame
    {
        
        public Boolean gameWon = false;
        
        //method to compare user input with random generated number
        public string checkGuess(int guess, int target)
        {
            string message = "";

            if (guess > target)
            {
                message = ("Your guess is too high!");
            } else if (guess < target)
            {
                message = ("Your guess is too low!");

            }   else
            {
                message = ("You guessed correctly");
                gameWon = true;
            }

            return message;
        }

    }
}
