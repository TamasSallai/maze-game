using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class CharacterController
    {
        public int PositionFromLeft { get; private set; }
        public int PositionFromTop { get; private set; }      

        public void GetStartingPosition(List<List<char>> mapMatrix)
        {
            for (int row = 0; row < mapMatrix.Count; row++)
            {
                for (int column = 0; column < mapMatrix[row].Count; column++)
                {
                    if (mapMatrix[row][column] == 'S')
                    {
                        PositionFromLeft = column;
                        PositionFromTop = row;
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                        Console.Write("C");
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                    }
                }
            }
        }

        public void MoveCharacter(List<List<char>> mapMatrix)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            Console.SetCursorPosition(PositionFromLeft, PositionFromTop);

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (mapMatrix[PositionFromTop - 1][PositionFromLeft] != '|')
                    {                      
                        Console.WriteLine(mapMatrix[PositionFromTop][PositionFromLeft]);
                        PositionFromTop--;                                             
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                        Console.Write("C");
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);                       
                    }
                    else
                    {
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop - 1);
                        Console.WriteLine(mapMatrix[PositionFromTop -1][PositionFromLeft]);
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (mapMatrix[PositionFromTop][PositionFromLeft + 1] != '|')
                    {
                        Console.WriteLine(mapMatrix[PositionFromTop][PositionFromLeft]);
                        PositionFromLeft++;                       
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                        Console.Write("C");
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);                        
                    }
                    else
                    {
                        Console.SetCursorPosition(PositionFromLeft + 1, PositionFromTop);
                        Console.WriteLine(mapMatrix[PositionFromTop][PositionFromLeft + 1]);
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (mapMatrix[PositionFromTop + 1][PositionFromLeft] != '|')
                    {
                        Console.WriteLine(mapMatrix[PositionFromTop][PositionFromLeft]);
                        PositionFromTop++;                    
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                        Console.Write("C");
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                    }
                    else
                    {
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop + 1);
                        Console.WriteLine(mapMatrix[PositionFromTop + 1][PositionFromLeft]);
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (mapMatrix[PositionFromTop][PositionFromLeft - 1] != '|')
                    {
                        Console.WriteLine(mapMatrix[PositionFromTop][PositionFromLeft]);
                        PositionFromLeft--;                       
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                        Console.Write("C");
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                    }
                    else
                    {
                        Console.SetCursorPosition(PositionFromLeft - 1, PositionFromTop);
                        Console.WriteLine(mapMatrix[PositionFromTop][PositionFromLeft -1]);
                        Console.SetCursorPosition(PositionFromLeft, PositionFromTop);
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
