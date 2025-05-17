using System;

class Program
{
    // Метод возвращает сумму факториалов от 1! до n!
    static long SumFactorials(int n)
    {
        long sum = 0;
        long fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *= i;       // вычисляем i!
            sum += fact;     // добавляем его к сумме
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

        long result = SumFactorials(n);
        Console.WriteLine($"Сумма 1! + 2! + … + {n}! = {result}");
    }
}
