using System;

class goto_stmt
{
    static void Main()
    {
        int counter = 0;

    start:
        Console.WriteLine("Counter: " + counter);
        counter++;

        if (counter < 5)
        {
            goto start;
        }

        Console.WriteLine("End of loop");
    }
}
