using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_01
{
    public class GameMathEngine
    {
        public bool isStarted { get; set; }

        public GameMathEngine()
        {
            isStarted = false;
        }

        public void startGame()
        {
            isStarted = true;
        }

        /*
        public int startPoint { get; set; }

        public void setStartPoint(int p)
        {
            startPoint = p;
        }

        public int endPoint { get; set; }

        public void setEndPoint(int p)
        {
            endPoint = p;
        }
        */

        public IRanger ranger { get; set; }

        public void isWithinPoints()
        {
            throw new NotImplementedException();
        }

        public void isWithinPoints(int playNumber)
        {
            if (playNumber < ranger.StartPoint && playNumber > ranger.EndPoint)
                throw new Exception("Enter valid play Number");
        }

        public void play()
        {
            if (ranger.StartPoint == 0) throw new Exception("Please set start point!");
            if (ranger.EndPoint == 0) throw new Exception("Please set end point!");

            for (var i = ranger.StartPoint; i <= ranger.EndPoint; i++)
            {
                var message = compute(i).ToString();

                resultLogger(message);
            }
        }

        public void resultLogger(string message)
        {
            Console.WriteLine(message);
        }

        public object compute(int userInput)
        {
            if (userInput % 3 == 0) return "Hot";
            if (userInput % 5 == 0) return "Hotter";
            else return userInput;
        }
    }
}
