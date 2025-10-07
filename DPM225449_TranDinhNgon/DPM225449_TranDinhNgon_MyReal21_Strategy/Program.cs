using System;

namespace MyReal21Strategy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            SortedList studentRecords = new SortedList();

            studentRecords.Add("Nguyen Van A");
            studentRecords.Add("Tran Thi B");
            studentRecords.Add("Le Van C");
            studentRecords.Add("Pham Thi D");
            studentRecords.Add("Hoang Van E");

            studentRecords.SetSortStrategy(new QuickSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new ShellSort());
            studentRecords.Sort();

            studentRecords.SetSortStrategy(new MergeSort());
            studentRecords.Sort();

            Console.ReadKey();
        }
    }
}
