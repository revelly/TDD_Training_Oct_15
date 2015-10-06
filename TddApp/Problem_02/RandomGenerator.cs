using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_02
{
    public class RandomGenerator
    {
        public RandomGenerator()
        {
            StartPoint = 1;
            EndPoint = 100;
        }

        public int StartPoint { get; set; }

        public int EndPoint { get; set; }

        public int getRandomNumber()
        {
            Random random = new Random();

            return random.Next(StartPoint, EndPoint);
        }
    }
}
