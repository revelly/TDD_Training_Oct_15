using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddDay3App
{
    public interface IStorageConnector
    {
        bool saveGame(string playerName, int target, int attempts);
    }
}
