using System;

class Marksheet
{
    static void Main()
    {
        Console.Write("Enter student's name: ");
        string name = Console.ReadLine();
        
        Console.Write("Enter marks for Math: ");
        int math = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for Science: ");
        int science = int.Parse(Console.ReadLine());

        Console.Write("Enter marks for English: ");
        int english = int.Parse(Console.ReadLine());

        int total = math + science + english;
        double average = total / 3.0;

        Console.WriteLine("\nMarksheet:");
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Math: " + math);
        Console.WriteLine("Science: " + science);
        Console.WriteLine("English: " + english);
        Console.WriteLine("Total: " + total);
        Console.WriteLine("Average: " + average);
    }
}
