using System;

class Daylight
{
    static void Main()
    {
        TimeZoneInfo localZone = TimeZoneInfo.Local;
        Console.WriteLine("Local Time Zone: " + localZone.DisplayName);
        Console.WriteLine("Daylight Saving Time: " + (localZone.IsDaylightSavingTime(DateTime.Now) ? "Yes" : "No"));
        Console.WriteLine("Daylight Name: " + localZone.DaylightName);
        Console.WriteLine("Standard Name: " + localZone.StandardName);
    }
}
