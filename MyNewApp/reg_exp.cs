using System;
using System.Text.RegularExpressions;

class Program980
{
    static void Main()
    {
        // Example 1: Validate an email address
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string email = "example@example.com";
        bool isEmailValid = Regex.IsMatch(email, emailPattern);
        Console.WriteLine("Is the email" +email ,"valid?" +isEmailValid);
         

        // Example 2: Find all digits in a string
        string digitPattern = @"\d+";
        string input = "The year is 2024 and the month is June.";
        MatchCollection digitMatches = Regex.Matches(input, digitPattern);
        Console.WriteLine("Digits found in the string:");
        foreach (Match match in digitMatches)
        {
            Console.WriteLine(match.Value);
        }

        // Example 3: Replace all whitespace with a single space
        string whitespacePattern = @"\s+";
        string text = "This   is  an   example   with   irregular  spacing.";
        string replacedText = Regex.Replace(text, whitespacePattern, " ");
        Console.WriteLine("Original text: "+text);
        Console.WriteLine("Replaced text: "+replacedText);
    }
}
