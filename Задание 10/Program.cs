using System;

class Program
{
 
    static double AlternatingSum(int n)
    {
        double sum = 0.0;
        int sign = 1;          // сначала плюс (1/1)

        for (int i = 1; i <= n; i++)
        {
            sum += sign * (1.0 / i);
            sign = -sign;      // меняем знак на противоположный
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Введите n (n ≥ 1): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Ошибка: введите целое число ≥ 1.");
            return;
        }

        double result = AlternatingSum(n);
        Console.WriteLine($"Сумма ряда = {result:F6}");
    }
}
