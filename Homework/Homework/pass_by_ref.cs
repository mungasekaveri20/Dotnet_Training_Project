using System;

class pass_by_ref
{
    static void Main()
    {
        int num = 10;
        Console.WriteLine("Before call: " + num);
        PassByReference(ref num);
        Console.WriteLine("After call: " + num);
    }

    static void PassByReference(ref int number)
    {
        number = 20;
    }
}
