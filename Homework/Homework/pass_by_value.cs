using System;

class pass_by_value
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine("Before call: " + num);
        PassByValue(num);
        Console.WriteLine("After call: " + num);
    }

    static void PassByValue(int number)
    {
        number = 20;
    }
}
