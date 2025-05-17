using System;

class Program
{

    static double GetPositionAfterStage(int N)
    {
        double position = 0.0;
        for (int k = 1; k <= N; k++)
        {
            double step = 1.0 / k;
            position += (k % 2 == 1 ? step : -step);
        }
        return position;
    }

    static double GetTotalPath(int N)
    {
        double total = 0.0;
        for (int k = 1; k <= N; k++)
            total += 1.0 / k;
        return total;
    }

    static void Main()
    {
        Console.Write("Введите число этапов N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N < 1)
        {
            Console.WriteLine("Ошибка: N должно быть целым числом ≥ 1.");
            return;
        }

        double pos = GetPositionAfterStage(N);
        double path = GetTotalPath(N);

        Console.WriteLine($"\nПосле {N}-го этапа он будет в {pos:F4} км от дома.");
        Console.WriteLine($"Общий пройденный путь: {path:F4} км.");
    }
}
