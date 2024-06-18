
using System;
namespace hello{

class Program3
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Kaveri..!");
        //int a =10;
        //int b= 20;
        // int a;
        // int b;
        
    
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        int c;
        c=a;
        a=b;
        b=c;

        Console.WriteLine("first: "+a);
        Console.WriteLine("second: "+b);


    }
}
}