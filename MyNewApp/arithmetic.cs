
using System;
namespace hello{

class Program1
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Kaveri..!");
        //int a =10;
        //int b= 20;
        int a =Convert.ToInt32(Console.ReadLine());  //or int.parse(Console.ReadLine())
        int b=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition :"+(a+b));
        Console.WriteLine("Substraction :"+(a-b));
        Console.WriteLine("Multiplication :"+(a*b));
        Console.WriteLine("Division :"+(a/b));
       // int a = 30;
        // int b=30;
        // int c = a+b;
        // Console.WriteLine($"This is addition :{c}");

        

    }
}
}