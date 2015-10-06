using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_01
{
    public class HigherClass : IRanger
    {
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }

        public HigherClass(){
            StartPoint = 1; EndPoint = 100;
        }

        public void setStartPoint(int startPoint)
        {
            StartPoint = startPoint;
        }

        public void setEndPoint(int endPoint)
        {
            EndPoint  = endPoint;
        }
    }
}
