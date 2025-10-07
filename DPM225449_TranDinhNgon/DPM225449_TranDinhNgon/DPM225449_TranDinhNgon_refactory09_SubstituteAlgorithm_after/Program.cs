using System;
using System.Collections.Generic;

class Program
{
    string FoundPerson(string[] people)
    {
        List<string> candidates = new List<string>() { "Don", "John", "Kent" };

        for (int i = 0; i < people.Length; i++)
        {
            if (candidates.Contains(people[i]))
            {
                return people[i];
            }
        }

        return String.Empty;
    }

    static void Main()
    {
        Program program = new Program();
        string[] people = { "Alice", "Kent", "Bob" };
        Console.WriteLine("Found: " + program.FoundPerson(people));
    }
}