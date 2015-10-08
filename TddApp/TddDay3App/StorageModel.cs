using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TddDay3App
{
    public class StorageModel
    {
        public IStorageConnector StorageConnector { get; set; }


        public bool saveGame(string playerName, int target, int attempts)
        {
            bool result = StorageConnector.saveGame(playerName, target, attempts);

            return result;
        }
    }
}
