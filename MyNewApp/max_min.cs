
using System;
namespace hello{

class Program2
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Kaveri..!");
        //int a =10;
        //int b= 20;
        int a =Convert.ToInt32(Console.ReadLine());  //or int.parse(Console.ReadLine())
        int b=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("minimum number is: "+Math.Min(a,b));
        Console.WriteLine("Maximum number is: "+Math.Max(a,b));

    }
}
}