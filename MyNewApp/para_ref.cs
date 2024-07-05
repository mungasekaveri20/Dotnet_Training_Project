using System;

class Program909
{
    static void Main()
    {
        int valueNumber = 10;
        Console.WriteLine("Before calling ModifyValue (by value): "+valueNumber);
        ModifyValueByValue(valueNumber);
        Console.WriteLine("After calling ModifyValue (by value): "+valueNumber);

        Console.WriteLine();

        int[] referenceNumbers = { 1, 2, 3 };
        Console.WriteLine("Before calling ModifyArray (by reference):");
        foreach (int num in referenceNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        ModifyArrayByReference(referenceNumbers);
        Console.WriteLine("After calling ModifyArray (by reference):");
        foreach (int num in referenceNumbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void ModifyValueByValue(int number)
    {
        number = 20; // Changes the parameter, not the original variable
        Console.WriteLine("Inside ModifyValue (by value): "+number);
    }

    static void ModifyArrayByReference(int[] numbers)
    {
        numbers[0] = 10; // Changes the original array through reference
        numbers[1] = 20;
        numbers[2] = 30;
        Console.WriteLine("Inside ModifyArray (by reference): Modified the array.");
    }
}
