using System;

namespace State.Structural
{
    public class Context
    {
        State state;

        public Context(State state)
        {
            this.State = state;
        }

        public State State
        {
            get { return state; }
            set
            {
                state = value;
                Console.WriteLine("State: " + state.GetType().Name);
            }
        }

        public void Request()
        {
            state.Handle(this);
        }
    }
}