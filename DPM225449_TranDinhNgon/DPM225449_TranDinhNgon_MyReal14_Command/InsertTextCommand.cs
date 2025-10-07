namespace Command.MyRealWorld
{
    public class InsertTextCommand : Command
    {
        private TextEditor editor;
        private string text;
        private int position;

        public InsertTextCommand(TextEditor editor, string text, int position)
        {
            this.editor = editor;
            this.text = text;
            this.position = position;
        }

        public override void Execute()
        {
            editor.Insert(text, position);
        }

        public override void UnExecute()
        {
            editor.Remove(position, text.Length);
        }
    }
}