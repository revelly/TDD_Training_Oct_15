using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_01
{
    public interface IRanger
    {
        int StartPoint { get; set; }
        int EndPoint { get; set; }

        void setStartPoint(int startPoint);
        void setEndPoint(int endPoint);
    }
}
