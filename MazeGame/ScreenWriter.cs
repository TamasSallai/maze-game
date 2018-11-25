using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class ScreenWriter
    {
        private static int mapHeigth;
        public static int MapHeigth { get => mapHeigth; set => mapHeigth = value; }

        public void WriteMap(List<List<char>> mapMatrix)
        {
            MapHeigth = mapMatrix.Count;
            foreach (List<char> subList in mapMatrix)
            {              
                foreach (char character in subList)
                {
                    Console.Write(character);
                }
                Console.WriteLine();
            }
        }

        


        public void WriteUserInterface(Player player)
        {
            Console.WriteLine();
            Console.Write($" Player: {player.Name}");
            Console.Write("     ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write($"Health: {player.Health}/3"); 
            Console.Write("     ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Gold: {player.GoldCount}/3"); 
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }

        public void WriteUpdatedHealth(Player player, int nameLength)
        {            
            int positionFromTop = MapHeigth + 1;
            int positionFromLeft = 22 + nameLength;
            Console.SetCursorPosition(positionFromLeft, positionFromTop);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(player.Health);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void WriteUpdatedGold(Player player, int nameLength)
        {
            int positionFromTop = MapHeigth + 1;
            int positionFromLeft = 36 + nameLength;
            Console.SetCursorPosition(positionFromLeft, positionFromTop);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(player.GoldCount);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
