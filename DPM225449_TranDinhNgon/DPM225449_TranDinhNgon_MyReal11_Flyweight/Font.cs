namespace Flyweight.MyRealWorld
{
    public abstract class Font
    {
        protected string family;
        protected int size;
        protected bool bold;
        protected bool italic;

        public abstract void Display(string text, int position);
    }
}