namespace Singleton.Structural
{
    public class Singleton
    {
        static Singleton instance;

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
}