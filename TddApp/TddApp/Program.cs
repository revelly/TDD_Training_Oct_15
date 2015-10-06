using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Problem_02;

namespace TddApp
{
    class Program
    {
        static void Main(string[] args)
        {
            GuessGameEngine gameEngine = new GuessGameEngine();
            RandomGenerator ran = new RandomGenerator();
            ran.StartPoint = 50;
            ran.EndPoint = 100;
            gameEngine.randomGenerator = ran;
            gameEngine.startGame();

            Console.WriteLine("Enter number between 1 - 100");
            while (true)
            {
                int userInput = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(gameEngine.verifyGuess(userInput));

                if (gameEngine.isGameEnded)
                {
                    Console.WriteLine("Do you want to continue?");
                    var vote = Console.ReadLine().ToString();

                    if (vote.ToLower() == "yes")
                    {
                        Console.WriteLine("Enter number between 1 - 100");
                        gameEngine.restart();
                    }
                    else
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
