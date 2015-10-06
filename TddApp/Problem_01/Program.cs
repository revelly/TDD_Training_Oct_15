using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem_01
{
    class Program
    {
        static void Main(string[] args)
        {
            IRanger lowerCLass = new LowerClass();

            GameMathEngine engine = new GameMathEngine();
            engine.startGame();
            engine.ranger = lowerCLass;
            engine.play();

            IRanger higherCLass = new HigherClass();
            engine.ranger = higherCLass;
            engine.play();

            Console.ReadKey();
        }
    }
}
