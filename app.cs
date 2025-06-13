using System;

public class Program
{
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static void Main()
    {
        Console.Write("Введите число: ");
        int num = int.Parse(Console.ReadLine());
        
        if (IsEven(num))
        {
            Console.WriteLine($"{num} — четное число.");
        }
        else
        {
            Console.WriteLine($"{num} — нечетное число.");
        }
    }
}
