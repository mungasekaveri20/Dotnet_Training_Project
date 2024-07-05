using System;

class Program98
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before calling the method: " + number);

        // Call the method and pass the number by value
        ModifyValue(number);

        // The value of 'number' will remain unchanged
        Console.WriteLine("After calling the method: " + number);
    }

    static void ModifyValue(int num)
    {
        // Modify the parameter
        num = 20;
        Console.WriteLine("Inside the method: " + num);
    }
}
