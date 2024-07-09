using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numberToGuess = random.Next(1, 101);
            int userGuess = 0;
            int attempts = 0;
            string playAgain;

            Console.WriteLine("Welcome to the Guessing Game!");

            do
            {
                Console.WriteLine("\nGuess a number between 1 and 100:");

                
                while (userGuess != numberToGuess)
                {
                    string input = Console.ReadLine();

                    if (int.TryParse(input, out userGuess))
                    {
                        attempts++;

                        
                        if (userGuess < numberToGuess)
                        {
                            Console.WriteLine("Too low! Try again.");
                        }
                        else if (userGuess > numberToGuess)
                        {
                            Console.WriteLine("Too high! Try again.");
                        }
                        else
                        {
                            Console.WriteLine($"Correct! You guessed the number in {attempts} attempts.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                    }
                }

                
                Console.WriteLine("Do you want to play again? (yes/no)");
                playAgain = Console.ReadLine().ToLower();

                switch (playAgain)
                {
                    case "yes":
                        numberToGuess = random.Next(1, 101);
                        userGuess = 0;
                        attempts = 0;
                        break;
                    case "no":
                        Console.WriteLine("Thanks for playing!");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Exiting game.");
                        playAgain = "no";
                        break;
                }

            } while (playAgain == "yes");

            
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Goodbye!");
                Console.ReadLine();
            }

        }
    }
}
