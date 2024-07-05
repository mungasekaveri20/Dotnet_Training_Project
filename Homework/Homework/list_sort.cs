using System;
using System.Collections.Generic;

class list_sort
{
    static void Main()
    {
        List<string> li = new List<string> { "siddhi", "abc", "abd", "jhg", "ghf" };

        li.Sort();

        Console.WriteLine("Sorted list of names:");
        foreach (string i in li)
        {
            Console.WriteLine(i);
        }
    }
}
