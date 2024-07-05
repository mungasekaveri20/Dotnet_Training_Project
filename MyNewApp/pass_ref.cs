using System;

class Program67
{
    static void Main()
    {
        int number = 10;
        Console.WriteLine("Before calling the method: " + number);

        // Call the method and pass the number by reference
        ModifyValue(ref number);

        // The value of 'number' will be changed
        Console.WriteLine("After calling the method: " + number);
    }

    static void ModifyValue(ref int num)
    {
        // Modify the parameter
        num = 20;
        Console.WriteLine("Inside the method: " + num);
    }
}
