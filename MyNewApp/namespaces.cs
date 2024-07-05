using System;

// Define a namespace
namespace MyCompany.Project
{
    // Define a class within the namespace
    public class MyClass
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Hello from MyClass in MyCompany.Project namespace!");
        }
    }
}

// Another namespace
namespace AnotherNamespace
{
    // Another class in a different namespace
    public class AnotherClass
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Hello from AnotherClass in AnotherNamespace!");
        }
    }
}

class Program89
{
    static void Main()
    {
        // Create an instance of MyClass and call its method
        MyCompany.Project.MyClass myClassInstance = new MyCompany.Project.MyClass();
        myClassInstance.DisplayMessage();

        // Create an instance of AnotherClass and call its method
        AnotherNamespace.AnotherClass anotherClassInstance = new AnotherNamespace.AnotherClass();
        anotherClassInstance.DisplayMessage();
    }
}
