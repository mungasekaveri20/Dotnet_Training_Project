using System;
using System.Text.RegularExpressions;

class regular_exp
{
    static void Main()
    {
        string input = "The quick brown fox jumps over the lazy dog. Email: example@example.com";
        
        // Pattern to find all words
        string wordPattern = @"\b\w+\b";
        MatchCollection wordMatches = Regex.Matches(input, wordPattern);
        Console.WriteLine("Words:");
        foreach (Match match in wordMatches)
        {
            Console.WriteLine(match.Value);
        }

        // Pattern to find email addresses
        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}\b";
        MatchCollection emailMatches = Regex.Matches(input, emailPattern);
        Console.WriteLine("\nEmail addresses:");
        foreach (Match match in emailMatches)
        {
            Console.WriteLine(match.Value);
        }
    }
}
