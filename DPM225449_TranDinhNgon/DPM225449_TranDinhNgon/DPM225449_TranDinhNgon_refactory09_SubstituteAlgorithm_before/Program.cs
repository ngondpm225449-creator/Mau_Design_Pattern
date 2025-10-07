using System;

class Program
{
    string FoundPerson(string[] people)
    {
        string[] candidates = { "Don", "John", "Kent" };
        return Array.Find(candidates, candidate => Array.Exists(people, person => person == candidate)) ?? string.Empty;
    }

    static void Main()
    {
        Program program = new Program();
        string[] people = { "Alice", "Kent", "Bob" };
        Console.WriteLine("Found: " + program.FoundPerson(people));
    }
}