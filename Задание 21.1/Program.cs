using System;

class Program
{

    static double DistanceAfterStage(int N)
    {
        double position = 0.0;
        for (int k = 1; k <= N; k++)
        {
            // если этап нечётный — прибавляем, иначе — вычитаем
            position += (k % 2 == 1 ? 1.0 / k : -1.0 / k);
        }
        return position;
    }

    static void Main()
    {
        Console.Write("Введите число этапов N: ");
        if (int.TryParse(Console.ReadLine(), out int N) && N > 0)
        {
            double pos = DistanceAfterStage(N);
            Console.WriteLine($"\nПосле {N}-го этапа он будет в {pos:F4} км от дома.");
        }
        else
        {
            Console.WriteLine("Ошибка: введите целое число N ≥ 1.");
        }
    }
}
