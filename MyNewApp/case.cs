using System;

class Program99
{
    static void Main()
    {
        string inputString = "Hello World!";
        string convertedString = ConvertToOppositeCase(inputString);

        Console.WriteLine("Original string: "+inputString);
        Console.WriteLine("Converted string: "+convertedString);
    }

    static string ConvertToOppositeCase(string input)
    {
        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsLower(chars[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
            }
            else if (char.IsUpper(chars[i]))
            {
                chars[i] = char.ToLower(chars[i]);
            }
            // If the character is neither uppercase nor lowercase, it remains unchanged
        }

        return new string(chars);
    }
}
