using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsGuess2
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessGame newGame = new GuessGame();

            
                //generate a random number between 1 and 1000
                Random random = new Random();
                int number = random.Next(1000);


                //initialize counter to track number of guesses
                int guessCount = 0;
                int myGuess = 0;
                
                //line entered for testing purposes
                //Console.WriteLine($"Target is {number}");

                //loop while guess not equal to target number and guesscount less than 10

                for (int i = 0; i < 10; i++)
                {

                    guessCount++;

                    //check user input and show message
                    Console.Write($"Enter guess number {guessCount}: ");
                    myGuess = Convert.ToInt16(Console.ReadLine());
                    string checkMessage = newGame.checkGuess(myGuess, number);
                    Console.WriteLine(checkMessage);

                    //break from loop if guess is correct
                    if (newGame.gameWon)
                    {
                        break;
                    }

                }

                Console.WriteLine($"Your guess was {myGuess}, the number was {number}");
                Console.ReadLine();
            

        }
    }
}
