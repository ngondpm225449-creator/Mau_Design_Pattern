using System;

namespace Memento.Structural
{
    /// <summary>
    /// The 'Originator' class
    /// </summary>
    public class Originator
    {
        string state;

        public string State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State = " + state);
            }
        }

        public Memento CreateMemento()
        {
            return new Memento(state);
        }

        public void SetMemento(Memento memento)
        {
            Console.WriteLine("Restoring state...");
            State = memento.State;
        }
    }
}