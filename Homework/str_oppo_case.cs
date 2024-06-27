using System;

class str_oppo_case
{
    static void Main()
    {
        string input = "Hello World";
        char[] chars = input.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsUpper(chars[i]))
            {
                chars[i] = char.ToLower(chars[i]);
            }
            else if (char.IsLower(chars[i]))
            {
                chars[i] = char.ToUpper(chars[i]);
            }
        }

        string result = new string(chars);
        Console.WriteLine("Original string: " + input);
        Console.WriteLine("Opposite case string: " + result);
    }
}
