namespace Command.MyRealWorld
{
    public class RemoveTextCommand : Command
    {
        private TextEditor editor;
        private int position;
        private int length;
        private string removedText;

        public RemoveTextCommand(TextEditor editor, int position, int length)
        {
            this.editor = editor;
            this.position = position;
            this.length = length;
        }

        public override void Execute()
        {
            removedText = editor.GetText(position, length);
            editor.Remove(position, length);
        }

        public override void UnExecute()
        {
            editor.Insert(removedText, position);
        }
    }
}