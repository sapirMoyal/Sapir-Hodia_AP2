using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SearchAlgorithmsLib;
using MazeGeneratorLib;
using MazeLib;
namespace ConsoleApplication3
{
    class SearchableMaze : ISearchable
    {
        private Maze maze;
        public List<State<Position>> getAllPossibleStates(State<> s)
        {
            
        }

        public State<Position> getGoalState()
        {
             State<Position> s  = new State<Position> (maze.GoalPos);
            return s;
        }

        public State<Position> getInitialState()
        {
            State<Position> s = new State<Position> (maze.InitialPos);
            return s;
        }
    }
}
