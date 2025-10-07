using System;

namespace Command.MyRealWorld
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User user = new User();

            user.ExecuteCommand(new InsertTextCommand(user.Editor, "Hello", 0));
            user.ExecuteCommand(new InsertTextCommand(user.Editor, " World", 5));
            user.ExecuteCommand(new RemoveTextCommand(user.Editor, 5, 6));
            user.ExecuteCommand(new InsertTextCommand(user.Editor, " C#", 5));

            user.Undo(2);
            user.Redo(1);

            Console.WriteLine($"\nFinal content: \"{user.Editor.Content}\"");

            Console.ReadKey();
        }
    }
}