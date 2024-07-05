
// using System;
// using System.Reflection.Metadata.Ecma335;
// namespace hello{
 


//     // // for single class.............
//     //    class Car{
//     //     public void Greet(){
//     //         Console.WriteLine("Hello");
//     //     }

//     // private static void Main(string[] args)
//     // {
//     //     Console.WriteLine("Hello Kaveri..!");
//     //     //int a =int.Parse(Console.ReadLine());
//     //     Car obj = new Car();
        
//     //     obj.Greet();   
//     // }
//     //    }


//     class hello1{
//         public string s1="hello";
//         public int a=10;
//         public int b=30;

//     }
//     class hello2 :hello1{
//         int x,y;
//         Console.WriteLine(x+y);
//     }





// // }


// using System;

// class hello1
// {
//     public string s1 = "hello";
//     public int a = 10;
//     public int b = 30;
// }

// class hello2 : hello1
// {
//     public hello2()
//     {
//         //int x = 5; // Initialize x
//         //int y = 7; // Initialize y
//         //return a + b;
//         Console.WriteLine("Hello....."); // Print sum of x and y
//     }
// }
// class Program56
// {
//     static void Main(string[] args)
//     {
//         hello2 obj = new hello2();
//         //hello2 obj1 = new hello1(); // Create an instance of hello2
//     }
// }



using System;
namespace MyApplication
{
  // Abstract class
  abstract class Animal
  {
    // Abstract method (does not have a body)
    public abstract void animalSound();
    // Regular method
    public void sleep()
    {
      Console.WriteLine("Zzz");
    }
  }
  
  // Derived class (inherit from Animal)
  class Pig : Animal
  {
    public override void animalSound()
    {
      // The body of animalSound() is provided here
      Console.WriteLine("The pig says: wee wee");
    }
  }

  class Program
  {
    static void Main(string[] args)
    {
      Pig myPig = new Pig();  // Create a Pig object
      myPig.animalSound();
      myPig.sleep();
    }
  }
}