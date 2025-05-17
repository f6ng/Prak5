using System;

class Program
{
    /// <summary>
    /// Возвращает пробег лыжника в N-й день (N ≥ 1).
    /// Первый день — 10 км, каждый следующий +10% от предыдущего.
    /// </summary>
    static double DistanceOnDay(int n)
    {
        double distance = 10.0;
        for (int day = 2; day <= n; day++)
            distance *= 1.1;  // увеличиваем на 10%
        return distance;
    }

    /// <summary>
    /// Возвращает суммарный пробег за первые N дней.
    /// </summary>
    static double TotalDistance(int n)
    {
        double total = 0.0;
        double distance = 10.0;
        for (int day = 1; day <= n; day++)
        {
            total += distance;
            distance *= 1.1;  // готовим расстояние для следующего дня
        }
        return total;
    }

    static void Main()
    {
        Console.Write("Введите число дней N: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Ошибка: введите целое N ≥ 1.");
            return;
        }

        double dayN = DistanceOnDay(n);
        double sum = TotalDistance(n);

        Console.WriteLine($"\nПробег в {n}-й день: {dayN:F2} км");
        Console.WriteLine($"Суммарный пробег за первые {n} дней: {sum:F2} км");
    }
}
