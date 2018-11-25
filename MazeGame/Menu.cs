using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class Menu
    {

        public bool EndOfGame { get; private set; } 
        public bool NextLevel { get; private set; } 
        public bool PreviousLevel { get; private set; }
        public bool GameOver { get; set; }



        public void MainMenu()
        {
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Exit");
            while (!EndOfGame && !NextLevel)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        NextLevel = true;
                        break;
                    case ConsoleKey.D2:
                        EndOfGame = true;
                        break;
                    default:                       
                        break;
                }
            }
            
            Console.Clear();
        }

        public void NextMenu()
        {
            EndOfGame = false;
            NextLevel = false;
            PreviousLevel = false;

            Console.Clear();
            Console.WriteLine("1. Next Level");
            Console.WriteLine("2. Previous Level");
            Console.WriteLine("3. Exit");
            
            while (!EndOfGame && !NextLevel && !PreviousLevel)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        NextLevel = true;
                        Console.Clear();
                        break;
                    case ConsoleKey.D2:
                        PreviousLevel = true;
                        Console.Clear();
                        break;
                    case ConsoleKey.D3:
                        EndOfGame = true;
                        break;
                    default:
                        break;
                }
            }                     
        }       

        public void GameOverMenu()
        {

        }
    }
}
