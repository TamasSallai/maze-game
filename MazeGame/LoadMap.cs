using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    class LoadMap
    {
        private List<List<char>> mapMatrix = new List<List<char>>();
        private List<List<char>> progressMatrix = new List<List<char>>();
        private int mapHeigth;

        public List<List<char>> MapMatrix { get => mapMatrix; private set => mapMatrix = value; }
        public List<List<char>> ProgressMatrix { get => progressMatrix; set => progressMatrix = value; }      
        public int MapHeigth { get => mapHeigth; set => mapHeigth = mapMatrix.Count; }

        public LoadMap(int mapNumber)
        {
            ReadMapFile(mapNumber);
        }


        private void ReadMapFile(int mapNumber)
        {
            string fileName = $"Map{mapNumber}.txt";
            StreamReader fileSream = new StreamReader(fileName);
            while (!fileSream.EndOfStream)
            {
                List<char> mapCharList = new List<char>();
                List<char> xCharList = new List<char>();
                
                string actualLine = fileSream.ReadLine();
                mapCharList.AddRange(actualLine);
                MapMatrix.Add(mapCharList);
               
                string xString = new String('X', actualLine.Length);
                xCharList.AddRange(xString);
                ProgressMatrix.Add(xCharList);              
            }
        }       
    }
}
