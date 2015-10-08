using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TddDay3App;

namespace TddDay3UnitTests
{
    public class FakeStorageConnector : IStorageConnector
    {
        public bool saveGame(string playerName, int target, int attempts)
        {
            return true;
        }
    }
    
}
