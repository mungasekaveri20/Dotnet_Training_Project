using System;

class Program12
{
    static void Main()
    {
        //    Console.WriteLine("Enter the number : ");
        int n = 5; // Number of rows

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            for (int k = 1; k <=  2*i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }
}





// using System;

// class Program13
// {
//     static void Main()
//     {
//         int n = 5; // Number of rows

//         for (int i = 1; i <= n; i++)
//         {
//             for (int j = 1; j <= n - i; j++)
//             {
//                 Console.Write(" ");
//             }

//             for (int k = 1; k <= i; k++)
//             {
//                 Console.Write("*");
//             }

//             Console.WriteLine();
//         }
//     }
// }





//using System;

// class Program14
// {
//     static void Main()
//     {
//         int n = 5;
//         for (int i = 1; i <= n; i++)
//         {
//             for (int j = i; j < n; j++)
//             {
//                 Console.Write(" ");
//             }
//             for (int k = 1; k <= (2 * i - 1); k++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }
//         for (int i = n - 1; i >= 1; i--)
//         {
//             for (int j = n; j > i; j--)
//             {
//                 Console.Write(" ");
//             }
//             for (int k = 1; k <= (2 * i - 1); k++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }
//     }
// }




// using System;

// class Program15
// {
//     static void Main()
//     {
//         int n = 4; // You can change this value to control the size of the pattern

//         // Upper half
//         for (int i = 1; i <= n; i++)
//         {
//             for (int j = 1; j <= i; j++)
//             {
//                 Console.Write("*");
//             }
//             Console.WriteLine();
//         }

//         // Lower half
//         for (int i = n - 1; i >= 1; i--)
//         {
//             for (int j = 1; j <= i; j++)
//             {
//                 Console.Write(" * ");
//             }
//             Console.WriteLine();
//         }
//     }
// }
