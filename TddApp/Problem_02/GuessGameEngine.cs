using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_02
{
    public class GuessGameEngine
    {
        public GuessGameEngine()
        {
        }

        public bool isStarted { get; set; }

        public void startGame()
        {
            if (!isStarted)
            {
                isStarted = true;
                isGameEnded = false;
                RandomNumber = generateRandomNumber();
            }
            else
                throw new Exception("Game has already started!");
        }

        public int RandomNumber { get; set; }
        public RandomGenerator randomGenerator { get; set; }
        public int generateRandomNumber()
        {
            if (randomGenerator == null)
                randomGenerator = new RandomGenerator();

            return RandomNumber = randomGenerator.getRandomNumber();
        }

        public string verifyGuess(int userInput)
        {
            Attempts++;

            if (userInput < RandomNumber) return "Aim Higher!";
            else if (userInput > RandomNumber) return "Aim Lower!";
            else {
                isGameEnded = true;
                return "You've got it in " + Attempts + " attempts"; }
        }

        public int Attempts { get; set; }

        public bool isGameEnded { get; set; }

        public void restart()
        {
            isStarted = true;
            isGameEnded = false;
            RandomNumber = generateRandomNumber();
            Attempts = 0;
        }
    }
}
