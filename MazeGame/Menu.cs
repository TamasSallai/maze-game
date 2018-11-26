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
        public bool GameOver { get; private set; }
        public bool RestartGame { get; private set; }

        public void ResetBools()
        {
            EndOfGame = false;
            NextLevel = false;
            PreviousLevel = false;
            GameOver = false;
            RestartGame = false;
        }

        public void MainMenu()
        {
            ResetBools();

            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Exit");
            while (!NextLevel)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        NextLevel = true;
                        break;
                    case ConsoleKey.D2:
                        Environment.Exit(0);
                        break;
                    default:                       
                        break;
                }
            }
            
            Console.Clear();
        }

        public void NextMenu()
        {
            ResetBools();           

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
            ResetBools();
            Console.Clear();
            Console.WriteLine("Game Over");
            Console.WriteLine("1.Play Again");
            Console.WriteLine("2.Exit");
            while (!EndOfGame && !RestartGame)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        RestartGame = true;
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

        public void VictoryMenu()
        {
            ResetBools();
            Console.Clear();
            Console.WriteLine(" _______________________");
            Console.WriteLine("|                       |");
            Console.WriteLine("|        VICTORY        |");
            Console.WriteLine("|                       |");
            Console.WriteLine("|_______________________|");
            Console.WriteLine();
            Console.WriteLine("1. Restart");
            Console.WriteLine("2. Exit");

            while (!EndOfGame && !RestartGame)
            {
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
                switch (KeyInfo.Key)
                {
                    case ConsoleKey.D1:
                        RestartGame = true;
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

    }
}
