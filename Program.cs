using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {

            Startup();

            void Startup()
            {
                Console.WriteLine("Guess the number between 1 and 100 that I am thinking of!");
                int winningNumber = WinningNumber();
                GuessGame(winningNumber);
            }

            //This is a test #2

            int WinningNumber()
            {
                int winningNumber = Random();
                return winningNumber;
            }

            void GuessGame(int winningNumber)
            {
                string userGuess = Console.ReadLine(); //User Input becomes userGuess

                int convertedGuess = Converter(); //Converter is invoked to convert string userGuess to int

                if (convertedGuess > winningNumber)
                {
                    Console.WriteLine("Too high try again");
                    GuessGame(winningNumber);
                    //string newGuess = Console.ReadLine();
                    //newGuess = userGuess;
                }
                if (convertedGuess < winningNumber)
                {
                    Console.WriteLine("Too low try again");
                    GuessGame(winningNumber);
                    //string newGuess = Console.ReadLine();
                    //newGuess = userGuess;
                }
                if (convertedGuess == winningNumber)
                {
                    Console.WriteLine("Great job you got it!");
                    Console.WriteLine("Did you want to play again?");
                    string answerText = Console.ReadLine();
                    if (answerText.Equals("Yes", StringComparison.OrdinalIgnoreCase))
                    {
                        Startup();
                    }
                    else
                    {
                        Console.WriteLine("Thanks for playing!");
                        Console.ReadLine();
                        Environment.Exit(0);
                    }

                }


                int Converter()
                {
                    int convertGuess = Convert.ToInt32(userGuess);
                    return convertGuess;
                }
            }

            int Random()
            {
                System.Random randomGen = new System.Random();
                int var = randomGen.Next(1, 100);
                return var;
            }





        }
    }
}
