
using System;
namespace hello{

class Program6
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Kaveri..!");
       //for boxing..........
        int a = 37;
        object obj = a;
        a=89;
        Console.WriteLine("boxing..........."+a);
        Console.WriteLine("boxing........."+obj);

        // for unboxing.................
        int b = (int) obj; 
       // Console.WriteLine(b);
        obj=45;
        Console.WriteLine("hello unboxing...."+obj);
        Console.WriteLine("hello unboxing...."+b);





        //secong program........


        //boxing..........
        int x = int.Parse(Console.ReadLine());
        string y = Console.ReadLine(); 
        object obj1 = x;
        object obj2 = y;
        x=34;
        y="kaveri";

        Console.WriteLine("boxing...."+obj1);
        Console.WriteLine("boxing...."+obj2); 
        Console.WriteLine("boxing...."+x); 
        Console.WriteLine("boxing...."+y);

        //Console.WriteLine(""+x);
        //unboxing................

        int m = (int) obj1; 
        string n =  (string) obj2;
       
        obj1=45;
        obj2="my program";

        Console.WriteLine("hello unboxing...."+obj1);
        Console.WriteLine("hello unboxing...."+obj2);
        Console.WriteLine("hello unboxing...."+m);

        Console.WriteLine("hello unboxing...."+n);
    }
}
}