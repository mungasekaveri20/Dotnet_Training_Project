
using System;
namespace hello{

class Program7
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Kaveri..!");
        

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if(a>=b){
            a+=b;
            a++;
            Console.WriteLine(a);

        }
        else{
            b--;
            Console.WriteLine(b);

        }
        Console.WriteLine("Program executed.....");

    }
}
}