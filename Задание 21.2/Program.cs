using System;

class Program
{
    static double TotalDistanceAfterStages(int N)
    {
        double total = 0.0;
        for (int k = 1; k <= N; k++)
            total += 1.0 / k;
        return total;
    }

    static void Main()
    {
        Console.Write("Введите число этапов N: ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            double totalPath = TotalDistanceAfterStages(N);
            Console.WriteLine($"\nОбщий пройденный путь после {N}-го этапа: {totalPath:F4} км.");
        }
        else
        {
            Console.WriteLine("Ошибка: введите целое число N ≥ 1.");
        }
    }
}
