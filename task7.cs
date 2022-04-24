using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите ваш баланс золота");
        int gold = Convert.ToInt32(Console.ReadLine());
        int exchangeRateGoldInCristal = 100;
        Console.WriteLine($"Добрвй день. Какое количество кристалов вы хотите обменять сегодня? На данный момент курс составляет 1 к {exchangeRate}");
        int cristals = Convert.ToInt32(Console.ReadLine());
        gold -= cristals * exchangeRateGoldInCristal;
        Console.WriteLine($" Огромное спасибо за покупку. Приходите ещё!\n Инвентарь:\n Золото = {gold}\n Кристаллы = {cristals}");
    }
}   
