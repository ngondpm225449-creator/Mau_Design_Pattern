using System;
using System.Collections.Generic;

namespace Command.MyRealWorld
{
    public class User
    {
        private TextEditor editor = new TextEditor();
        private List<Command> commands = new List<Command>();
        private int current = 0;

        public void ExecuteCommand(Command command)
        {
            command.Execute();
            commands.Add(command);
            current++;
        }

        public void Undo(int levels)
        {
            Console.WriteLine($"\n---- Undo {levels} levels");
            for (int i = 0; i < levels; i++)
            {
                if (current > 0)
                {
                    Command command = commands[--current];
                    command.UnExecute();
                }
            }
        }

        public void Redo(int levels)
        {
            Console.WriteLine($"\n---- Redo {levels} levels");
            for (int i = 0; i < levels; i++)
            {
                if (current < commands.Count)
                {
                    Command command = commands[current++];
                    command.Execute();
                }
            }
        }

        public TextEditor Editor => editor;
    }
}