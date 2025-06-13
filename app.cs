using System;

public class Program
{
    public static string GetName()
    {
        Console.Write("Введите ваше имя: ");
        return Console.ReadLine();
    }

    public static void Main()
    {
        string name = GetName();
        Console.WriteLine($"Привет, {name}!");
    }
}

