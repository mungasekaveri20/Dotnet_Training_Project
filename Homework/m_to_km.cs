using System;

class m_to_km
{
    static void Main()
    {
        Console.Write("Enter distance in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        
        double kilometers = meters / 1000;
        Console.WriteLine("Distance in kilometers: " + kilometers);

        Console.Write("Enter distance in kilometers: ");
        kilometers = Convert.ToDouble(Console.ReadLine());

        meters = kilometers * 1000;
        Console.WriteLine("Distance in meters: " + meters);
    }
}
