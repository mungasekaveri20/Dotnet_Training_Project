using System;

namespace StudentDetails
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of students: ");
            int numOfStudents = int.Parse(Console.ReadLine());

            int[] rollno = new int[numOfStudents];
            string[] name = new string[numOfStudents];
            string[] branch = new string[numOfStudents];
            int[] semester = new int[numOfStudents];
            string[] college = new string[numOfStudents];

            for (int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine("Enter details for student :"+i + 1);
                Console.Write("Roll No: ");
                rollno[i] = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                name[i] = Console.ReadLine();

                Console.Write("Branch: ");
                branch[i] = Console.ReadLine();

                Console.Write("Semester: ");
                semester[i] = int.Parse(Console.ReadLine());

                Console.Write("College: ");
                college[i] = Console.ReadLine();

                Console.WriteLine();
            }

            Console.WriteLine("Student Details:");
            for (int i = 0; i < rollno.Length; i++)
            {
                Console.WriteLine("Roll No: "+rollno[i]);
                Console.WriteLine("Name: {name[i]}"+name[i]);
                Console.WriteLine("Branch: "+branch[i]);
                Console.WriteLine("Semester: "+semester[i]);
                Console.WriteLine("College: "+college[i]);
                Console.WriteLine();
            }
            Console.WriteLine("Student Details:");
            //Console.WriteLine($"{"Roll No",-10} {"Name",-15} {"Branch",-20} {"Semester",-10} {"College",-30}");
            Console.WriteLine("Roll No\t\tName\t\tBranch\t\tSemester\tCollege");
            Console.WriteLine(new string('-', 85));

            for (int i = 0; i < rollno.Length; i++)
            {
                Console.WriteLine(rollno[i]+"\t\t"+name[i]+"\t\t"+branch[i]+"\t\t"+semester[i]+"\t\t"+college[i]);
            }
        }
    }
}