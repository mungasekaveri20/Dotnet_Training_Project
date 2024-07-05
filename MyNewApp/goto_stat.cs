using System;

class Program565
{
    static void Main()
    {
        int choice;

        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Option 1");
        Console.WriteLine("2. Option 2");
        Console.WriteLine("3. Option 3");

        choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine("You chose Option 1");
                goto case 4; // Jump to case 4
            case 2:
                Console.WriteLine("You chose Option 2");
                goto default; // Jump to default case
            case 3:
                Console.WriteLine("You chose Option 3");
                break; // Exit switch statement
            case 4:
                Console.WriteLine("This is case 4");
                break; // Exit switch statement
            default:
                Console.WriteLine("Invalid choice");
                break; // Exit switch statement
        }

        Console.WriteLine("End of program");
    }
}
