using System;

class Program
{
    static void Main(string[] args)
    {
        int firstVariable = 10;
        int secondVariable = 20;
        Console.WriteLine($"Старые значения:\n первая переменная = {firstVariable}\n вторая переменная = {secondVariable}");
        int temp = firstVariable;
        firstVariable = secondVariable;
        secondVariable = temp;
        Console.WriteLine($"Новые значения:\n первая переменная = {firstVariable}\n вторая переменная = {secondVariable}");
    }
}   
