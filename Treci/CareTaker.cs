using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treci
{
    class CareTaker
    {
        private int counter;
        private List<Memento> previousState;

        public CareTaker() { this.previousState = new List<Memento>(); counter = previousState.Count - 1; }
        public CareTaker(List<Memento> previousState)
        {
            this.previousState = previousState;
            counter = previousState.Count - 1;
        }
        public Memento Undo()
        {
            counter--;
            if (counter < 0) return null;
            return previousState[counter];
        }

        public void AddPreviousState(Memento state) { previousState.Add(state); counter = previousState.Count - 1; }

        public Memento Add()
        {
            counter++;
            if (counter > previousState.Count - 1) return null;
            return previousState[counter];
        }
    }
}
