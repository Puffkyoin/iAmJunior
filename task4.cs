using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string favoriteFood;
        int age;
        Console.WriteLine("Введите своё имя");
        name = Console.ReadLine();
        Console.WriteLine("Сколько тебе лет? (Введите число)");
        age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите своё любимое блюдо.(в единственном числе)");
        favoriteFood = Console.ReadLine();
        Console.WriteLine($"Тебя зовут {name}. Твой возраст {age} и твоё любимое блюдо {favoriteFood}.");
    }
}
    
