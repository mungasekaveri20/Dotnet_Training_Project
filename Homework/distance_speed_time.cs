using System;

class distance_speed_time
{
    static void Main()
    {
        Console.Write("Enter distance (in meters): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (in seconds): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double speed = distance / time;
        Console.WriteLine("Speed (m/s): " + speed);

        Console.Write("Enter speed (m/s): ");
        speed = Convert.ToDouble(Console.ReadLine());

        time = distance / speed;
        Console.WriteLine("Time (s): " + time);
    }
}
