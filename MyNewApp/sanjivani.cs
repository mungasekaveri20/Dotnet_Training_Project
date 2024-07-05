using System;

class Program56
{
    // public static object? C { get; private set; }

    static void Main(string[] args)
    {
        // Take user inputs for Student and Fee Details
        Console.Write("Enter Student Name: ");
        string studentName = Console.ReadLine();
        
        Console.Write("Enter USN: ");
        string usn = Console.ReadLine();
        
        Console.Write("Enter Branch and Semester (e.g., 7th Sem, CSE): ");
        string branch = Console.ReadLine();
        
        Console.Write("Enter Academic Year (e.g., 2023-2024): ");
        string academicYear = Console.ReadLine();
        
        // Console.Write("Enter Time (e.g., 11:45 AM): ");
        DateTime time = DateTime.Now;

        Console.Write("Enter Entrance Fee: ");
        decimal entranceFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Exams Fee: ");
        decimal examsFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Library Fee: ");
        decimal libraryFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Hostel Fee: ");
        decimal hostelFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Laboratory Fee: ");
        decimal laboratoryFee = decimal.Parse(Console.ReadLine());
        
        Console.Write("Enter Project and Class Fee: ");
        decimal projectAndClassFee = decimal.Parse(Console.ReadLine());

        // Calculate Total Fee
        decimal totalFee = entranceFee + examsFee + libraryFee + hostelFee + laboratoryFee + projectAndClassFee;
        decimal gst = totalFee * 0.18m;  // Assuming GST is 18%
        decimal grandTotal = totalFee + gst;

        // Display the Fee Receipt
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("\n\n\tSANJIVANI COLLEGE OF ENGINEERING");
        Console.WriteLine("\t    ~ Academic Fee Receipt ~");
        Console.WriteLine("Name: "+studentName);
        Console.WriteLine("USN: "+usn);
        Console.WriteLine("Branch: "+branch);
        Console.WriteLine("Academic Year: " + academicYear,"\t" + "Time :" + time);
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("1. Entrance Fee: \t\t\t"+entranceFee);
        Console.WriteLine("2. Exams Fee: \t\t\t\t"+examsFee);
        Console.WriteLine("3. Library Fee: \t\t\t"+libraryFee);
        Console.WriteLine("4. Hostel Fee: \t\t\t\t"+hostelFee);
        Console.WriteLine("5. Laboratory Fee: \t\t\t"+laboratoryFee);
        Console.WriteLine("6. Project and Class Fee: \t"+projectAndClassFee);
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Total: \t\t\t\t\t"+totalFee);
        Console.WriteLine("GST (18%): \t\t\t\t"+gst);
        Console.WriteLine("---------------------------------------------------");
        Console.WriteLine("Grand Total: \t\t\t\t"+grandTotal);
        Console.WriteLine("---------------------------------------------------");
    }
}