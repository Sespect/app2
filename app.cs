using System;

public class Program
{
    public static double ReadNumber(string prompt)
    {
        double number;
        Console.Write(prompt);
        while (!double.TryParse(Console.ReadLine(), out number))
        {
            Console.Write("Ошибка! Введите число: ");
        }
        return number;
    }

    public static double MultiplyNumbers(double a, double b)
    {
        return a * b;
    }

    public static void Main()
    {
        double num1 = ReadNumber("Введите первый множитель: ");
        double num2 = ReadNumber("Введите второй множитель: ");
        
        double result = MultiplyNumbers(num1, num2);
        Console.WriteLine($"Результат умножения: {result}");
    }
}
