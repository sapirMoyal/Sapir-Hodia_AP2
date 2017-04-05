using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MazeGeneratorLib;
using MazeLib;
using SearchAlgorithmsLib;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            IMazeGenerator img = new DFSMazeGenerator();
            Maze maze = img.Generate(100, 100);
            
            Console.WriteLine(maze.ToString());
            ISearcher searcher = new BFS(); 
            searcher.search()
            Console.ReadKey();
        }
    }
}
