using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько людей находятся впереди вас?");
        int peopleAhead = Convert.ToInt32(Console.ReadLine());
        int waitTimeInOnePerson = 10;
        int perHourMinutes = 60;
        int totalHoursWait = peopleAhead * waitTimeInOnePerson/perHourMinutes;
        int totalMinutesWait = peopleAhead * waitTimeInOnePerson % perHourMinutes;
        Console.WriteLine($"Вы должны отстоять в очереди {totalHoursWait} час(а) и {totalMinutesWait} минут(ы)");
    }
}   
