using System;

public class Program
{
    private static double ReadNumber(string prompt)
    {
        double number;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Ошибка! Введите корректное число: ");
        }
        return number;
    }

    private static string GetName()
    {
        Console.Write("Введите ваше имя: ");
        return Console.ReadLine();
    }

    private static double Add(double a, double b) => a + b;

    private static double Multiply(double a, double b) => a * b;

    private static bool IsEven(int num) => num % 2 == 0;

    public static void Main()
    {
        string name = GetName();
        Console.WriteLine($"Привет, {name}!");

        double num1 = ReadNumber("Введите первое число: ");
        double num2 = ReadNumber("Введите второе число: ");

        Console.WriteLine($"Сумма: {Add(num1, num2)}");
        Console.WriteLine($"Произведение: {Multiply(num1, num2)}");

        if (IsEven((int)num1))
            Console.WriteLine($"{num1} - чётное");
        else
            Console.WriteLine($"{num1} - нечётное");

        if (IsEven((int)num2))
            Console.WriteLine($"{num2} - чётное");
        else
            Console.WriteLine($"{num2} - нечётное");
    }
}
