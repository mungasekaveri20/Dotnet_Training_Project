
using System;
namespace hello{

class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Kaveri..!");
        int a =int.Parse(Console.ReadLine());
        
        // // int a =Convert.ToInt32(Console.ReadLine());  //or int.parse(Console.ReadLine())
        // // int b=Convert.ToInt32(Console.ReadLine());


        //AND
        if(a>=18 && a<=60){
            Console.WriteLine("Eligible to vote");
        }
        else{
            Console.WriteLine("Not Eligible...");
        }


        //OR
        if(a>=18 || a<=60){
            Console.WriteLine("Eligible to vote");
        }
        else{
            Console.WriteLine("Not Eligible...");
        }


        //NOT

        if(!(a>=18 && a<=60)){
            Console.WriteLine("Not Eligible to vote");
        }
        else{
            Console.WriteLine("Eligible...");
        }




        
    }
}
}