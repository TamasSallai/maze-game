using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class Program
    {
        static void Main(string[] args)
        {                     

            ScreenWriter ScreenWriter = new ScreenWriter();
            Menu Menu = new Menu();
            Menu.MainMenu();

            Console.WriteLine("Adjon meg egy nevet.");
            string playerName = Console.ReadLine();
            Console.Clear();
            Player Player = new Player(playerName);
            PlayerUpdate Update = new PlayerUpdate(Player);
            CharacterController Controller = new CharacterController();
            FileWriter WriteFile = new FileWriter();

            do
            {
                RunGame(Menu, Player, Update, ScreenWriter, Controller, WriteFile);
            } while (Menu.RestartGame);

            Environment.Exit(0);
        }

        private static void RunGame(Menu Menu, Player Player, PlayerUpdate Update, ScreenWriter ScreenWriter, CharacterController Controller ,FileWriter WriteFile)
        {                      
            int levelNumber = 0;
            LoadMap Map = new LoadMap(levelNumber);

            while (!Menu.EndOfGame)
            {
                ScreenWriter.WriteMap(Map.ProgressMatrix);
                ScreenWriter.WriteUserInterface(Player);
                Controller.GetStartingPosition(Map.MapMatrix);
                while (Map.MapMatrix[Controller.PositionFromTop][Controller.PositionFromLeft] != 'E' && Player.Health > 0)
                {
                    Controller.MoveCharacter(Map.MapMatrix);
                    Update.StepCheking(Map.MapMatrix, Map.ProgressMatrix, Controller.PositionFromTop, Controller.PositionFromLeft);

                }

                if (Player.Health == 0)
                {
                    Menu.GameOverMenu();
                    break;
                }

                if (levelNumber == 3)
                {
                    Menu.VictoryMenu();
                    Update.EndOfLevel();
                    break;
                }

                Menu.NextMenu();
                if (Menu.NextLevel)
                {
                    levelNumber++;
                    Update.EndOfLevel();
                    Map = new LoadMap(levelNumber);                   
                }


            }
            WriteFile.WriteStat(Player);
        }
    }
}
