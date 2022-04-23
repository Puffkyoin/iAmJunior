using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Скалько Babuskas вы видите впереди?");
        int babushkas = Convert.ToInt32(Console.ReadLine());
        int waitTime = 10;
        int totalHoursWait = babushkas * waitTime/60;
        int totalMinutesWait = babushkas * waitTime % 60;
        Console.WriteLine($"Вы должны отстоять в очереди {totalHoursWait} час(а) и {totalMinutesWait} минут(ы)");
    }
}   