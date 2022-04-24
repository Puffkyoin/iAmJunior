using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько людей находятся впереди вас?");
        int peopleAhead = Convert.ToInt32(Console.ReadLine());
        int waitTimeInOnePoeple = 10;
        int perHourMinutes = 60;
        int totalHoursWait = peopleAhead * waitTimeInOnePoeple/perHourMinutes;
        int totalMinutesWait = peopleAhead * waitTime % perHourMinutes;
        Console.WriteLine($"Вы должны отстоять в очереди {totalHoursWait} час(а) и {totalMinutesWait} минут(ы)");
    }
}   
