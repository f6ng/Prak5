using System;

class Program
{
    // Метод возвращает сумму ряда 1 + 1/1! + … + 1/n!
    static double SumSeries(int n)
    {
        double sum = 1.0;   // начинаем с 1 (нулевой член ряда)
        double fact = 1.0;  // текущий факториал (0! = 1)

        for (int i = 1; i <= n; i++)
        {
            fact *= i;          // вычисляем i!
            sum += 1.0 / fact;  // добавляем 1/i!
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Введите n (1 ≤ n ≤ 10): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1 || n > 10)
        {
            Console.WriteLine("Ошибка: введите целое число от 1 до 10.");
            return;
        }

        double result = SumSeries(n);
        Console.WriteLine($"Сумма 1 + 1/1! + … + 1/{n}! = {result}");
    }
}
