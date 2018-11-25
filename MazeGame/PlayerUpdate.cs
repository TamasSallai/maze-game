using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class PlayerUpdate : ScreenWriter
    {
        public char Trap { get; } = 'T';
        public char Gold { get; } = 'G';
        public char Unknow { get; } = 'X';

        private Random rnd = new Random();

        
        Player Player;
        
        public PlayerUpdate(Player Player)
        {
            this.Player = Player;
        }

        public void StepCheking(List<List<char>> mapMatrix, List<List<char>> progressMatrix, int positionFromTop, int positionFromLeft)
        {            
            if (mapMatrix[positionFromTop][positionFromLeft] == Trap && progressMatrix[positionFromTop][positionFromLeft] == Unknow)
            {
                int chance = rnd.Next(1, 101);
                if (Player.Health > 0 && chance < 30)
                {
                    Player.Health--;
                    WriteUpdatedHealth(Player, Player.NameLength);
                }                
            }

            if (mapMatrix[positionFromTop][positionFromLeft] == Gold && progressMatrix[positionFromTop][positionFromLeft] == Unknow)
            {
                Player.GoldCount++;
                WriteUpdatedGold(Player, Player.NameLength);
            }

            progressMatrix[positionFromTop][positionFromLeft] = mapMatrix[positionFromTop][positionFromLeft];
        }

        public void EndOfLevel()
        {
            Player.AllGold += Player.GoldCount;
            Player.GoldCount = 0;
            Player.Health = 3;
        }
    }
}
