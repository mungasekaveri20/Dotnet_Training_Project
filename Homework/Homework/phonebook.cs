using System;
using System.Collections.Generic;

class phoneBook
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        
        phoneBook.Add("John", "123-456-7890");
        phoneBook.Add("Anna", "987-654-3210");
        phoneBook.Add("Mark", "555-555-5555");

        Console.WriteLine("Phone Book:");
        foreach (var entry in phoneBook)
        {
            Console.WriteLine($"Name: {entry.Key}, Phone: {entry.Value}");
        }
    }
}
