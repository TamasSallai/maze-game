using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class FileWriter
    {
        StreamWriter streamWriter = new StreamWriter("Adatok.txt", true, Encoding.UTF8);
        public void WriteStat(Player player)
        {
            string actualDateTime = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            streamWriter.WriteLine($"Date: {actualDateTime}, Name: {player.Name}, Gold: {player.AllGold}");
            streamWriter.Close();
        }
    }
}
