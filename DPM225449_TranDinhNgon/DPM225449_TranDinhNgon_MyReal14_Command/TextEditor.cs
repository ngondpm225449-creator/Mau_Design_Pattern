using System;

namespace Command.MyRealWorld
{
    public class TextEditor
    {
        private string content = "";

        public void Insert(string text, int position)
        {
            if (position < 0 || position > content.Length) position = content.Length;
            content = content.Insert(position, text);
            Console.WriteLine($"Inserted \"{text}\" at {position}: {content}");
        }

        public void Remove(int position, int length)
        {
            if (position < 0 || position + length > content.Length) return;
            string removed = content.Substring(position, length);
            content = content.Remove(position, length);
            Console.WriteLine($"Removed \"{removed}\" from {position}: {content}");
        }

        public string GetText(int position, int length)
        {
            if (position < 0 || position + length > content.Length) return "";
            return content.Substring(position, length);
        }

        public string Content => content;
    }
}