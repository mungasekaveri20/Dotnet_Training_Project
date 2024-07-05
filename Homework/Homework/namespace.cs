using System;

namespace Company
{
    namespace Department
    {
        class Employee
        {
            public void Display()
            {
                Console.WriteLine("Hello, I am an employee of the company.");
            }
        }
    }
}

class namespace_program
{
    static void Main()
    {
        Company.Department.Employee emp = new Company.Department.Employee();
        emp.Display();
    }
}
