using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class Player
    {
        public int AllGold { get; set; } = 0;
        public int GoldCount { get; set; } = 0;
        public int Health { get; set; } = 3;
        public int NameLength { get; private set; }
        public string Name
        {
            get { return name; }
            private set
            {              
                if (string.IsNullOrEmpty(value))
                {
                    name = "Player1";
                    NameLength = Name.Length;
                }
                name = value;
                NameLength = Name.Length;
            }
        }
        private string name;

        public Player(string Name)
        {
            this.Name = Name;
        }

       

    }
}
