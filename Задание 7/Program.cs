using System;

class Program
{
    // Тот же метод для вычисления n! из задачи 5
    static long Factorial(int n)
    {
        long fact = 1;
        for (int i = 1; i <= n; i++)
            fact *= i;
        return fact;
    }

    static void Main()
    {
        Console.Write("Введите n (1 ≤ n ≤ 10): ");
        int n = int.Parse(Console.ReadLine()!);

        double sum = 0;
        // складываем 1/0! + 1/1! + … + 1/n!
        for (int i = 0; i <= n; i++)
            sum += 1.0 / Factorial(i);

        Console.WriteLine($"Сумма = {sum:F6}");
    }
}
