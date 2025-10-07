using System.Collections.Generic;

namespace Strategy.RealWorld
{
    public abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}