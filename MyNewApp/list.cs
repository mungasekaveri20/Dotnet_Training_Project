using System;
using System.Collections.Generic;

class Program76
{
    static void Main()
    {
        // Define a list of names
        List<string> names = new List<string>()
        {
            "Alice",
            "Bob",
            "Charlie",
            "David",
            "Eve"
        };

        // Sort the list of names in alphabetical order
        names.Sort();

        // Output the sorted list of names
        Console.WriteLine("Sorted list of names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
