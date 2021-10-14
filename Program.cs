using System;
using System.Collections.Generic;
using TurtleChallenge.Games;

namespace TurtleChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array;

            if (args.Length == 0)
            {
                array = new string[2];

                array[0] = "game-settings";
                array[1] = "moves";
            }
            else
            {
                array = new string[args.Length];
                array = args;
            }

            IGame basicGameLoader = new BasicGame();
            IGameSettings basicGameSettings = basicGameLoader.LoadGameSettings(array);
            basicGameLoader.ExecuteGame(basicGameSettings);
        }
    }
}
