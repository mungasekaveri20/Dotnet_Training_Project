
using System;
namespace hello{

class Program5
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello Kaveri..!");
        int a =int.Parse(Console.ReadLine());
        
        // // int a =Convert.ToInt32(Console.ReadLine());  //or int.parse(Console.ReadLine())
        // // int b=Convert.ToInt32(Console.ReadLine());


      
        if(a>=18 && a<=60){
            Console.WriteLine("Eligible to vote");
            if(a==18){
                Console.WriteLine("Eligible for marriage also");
            }
            
            else if(a>60){
                Console.WriteLine("Your are not eligible");
            }
        }
        else{
            Console.WriteLine("Enter valid input");
            if(a<18){
                Console.WriteLine("You are not eligible for votting");
            }
        }


       
        // if(a>=18 || a<=60){
        //     Console.WriteLine("Eligible to vote");
        // }
        // else{
        //     Console.WriteLine("Not Eligible...");
        // }

        // if(!(a>=18 && a<=60)){
        //     Console.WriteLine("Not Eligible to vote");
        // }
        // else{
        //     Console.WriteLine("Eligible...");
        // }




        
    }
}
}