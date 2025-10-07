using System;

namespace MyReal18Memento
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SalesProspect s = new SalesProspect();
            s.Name = "Nguyen Van A";
            s.Phone = "0901 234 567";
            s.Budget = 50000.0;

            ProspectMemory m = new ProspectMemory();
            m.Memento = s.SaveMemento();

            s.Name = "Tran Thi B";
            s.Phone = "0987 654 321";
            s.Budget = 200000.0;

            s.RestoreMemento(m.Memento);

            Console.ReadKey();
        }
    }
}
