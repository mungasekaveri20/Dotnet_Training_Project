using System;
using System.Diagnostics;
using System.Threading;

class stopwatch
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();

        Console.WriteLine("Press Enter to start the stopwatch...");
        Console.ReadLine();
        stopwatch.Start();

        Console.WriteLine("Press Enter to stop the stopwatch...");
        Console.ReadLine();
        stopwatch.Stop();

        Console.WriteLine("Elapsed Time: " + stopwatch.Elapsed);
    }
}
