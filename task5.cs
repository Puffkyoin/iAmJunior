using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 10;
        int y = 20;
        Console.WriteLine($"Старые значения:\n x = {x}\n y = {y}");
        int temp = x;
        x = y;
        y = temp;
        Console.WriteLine($"Новые значения:\n x = {x}\n y = {y}");
    }
}   