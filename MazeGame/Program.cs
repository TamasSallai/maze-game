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
            Menu Menu= new Menu();
            Menu.MainMenu();

            Console.WriteLine("Adjon meg egy nevet.");
            string playerName = Console.ReadLine();
            Console.Clear();

            Player Player = new Player(playerName);
            PlayerUpdate Update = new PlayerUpdate(Player);

            CharacterController Controller = new CharacterController();           
            LoadMap Map = new LoadMap(0);

            //ScreenWriter.WriteMap(Map.ProgressMatrix);
            //ScreenWriter.WriteUserInterface(Player);
            int LevelNumber = 0;
            while (!Menu.EndOfGame)
            {                
                ScreenWriter.WriteMap(Map.ProgressMatrix);
                ScreenWriter.WriteUserInterface(Player);
                Controller.GetStartingPosition(Map.MapMatrix);
                while (Map.MapMatrix[Controller.PositionFromTop][Controller.PositionFromLeft] != 'E')
                {
                    Controller.MoveCharacter(Map.MapMatrix);
                    Update.StepCheking(Map.MapMatrix, Map.ProgressMatrix, Controller.PositionFromTop, Controller.PositionFromLeft);
                    if (Player.Health == 0)
                    {
                        Menu.GameOverMenu();
                    }
                }

                Menu.NextMenu();
                if (Menu.NextLevel)
                {
                    LevelNumber++;
                    Update.EndOfLevel();
                    Map = new LoadMap(LevelNumber);
                    ScreenWriter.WriteMap(Map.ProgressMatrix);
                    ScreenWriter.WriteUserInterface(Player);
                }

                if (Menu.PreviousLevel)
                {                    
                    ScreenWriter.WriteMap(Map.ProgressMatrix);
                    ScreenWriter.WriteUserInterface(Player);
                }

                if (Menu.GameOver)
                {

                    break;
                }


            }
            
        }
    }
}
