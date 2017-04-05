using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SearchAlgorithmsLib
{
    public class State<T> {
        private T state;
        public double cost
        {
            get; set;
        }
        public double GetCost()
        {
            return cost;
        }
        private State <T> cameFrom;
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="state"></param>
        public State(T state)
        {
            this.cost = int.MaxValue;
            this.state = state;
        }
        /// <summary>
        /// comper between to states
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return state.Equals((obj as State<T>).state);
        }
        /// <summary>
        /// to help equal method
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return state.GetHashCode();
        }
        /// <summary>
        /// get state
        /// </summary>
        /// <returns></returns>
        public T getVal()
        {
            return this.state;
        }

    }
}