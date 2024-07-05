using System;

class sq_feet
{
    static void Main()
    {
        Console.Write("Enter the length of the house (in feet): ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the house (in feet): ");
        double width = Convert.ToDouble(Console.ReadLine());

        double squareFeet = length * width;
        Console.WriteLine("Square feet of the house: " + squareFeet);
    }
}
