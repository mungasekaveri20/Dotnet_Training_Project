using System;

class Program111
{
    static void Main()
    {
        // Example strings
        string str1 = "Hello";
        string str2 = "World";

        // Concatenate the strings
        string concatenatedString = ConcatenateStrings(str1, str2);

        // Print the result
        Console.WriteLine("First string: " + str1);
        Console.WriteLine("Second string: " + str2);
        Console.WriteLine("Concatenated string: " + concatenatedString);
    }

    // Function to concatenate two strings
    static string ConcatenateStrings(string str1, string str2)
    {
        return str1 +" "+ str2;
    }
}
