using System;

class Program
{
    
    static int SquareByOddSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += 2 * i - 1;
        return sum;
    }

    // Задача 9: возвращает сумму 1² + 2² + … + n², используя SquareByOddSum
    static int SumOfSquares(int n)
    {
        int total = 0;
        for (int i = 1; i <= n; i++)
            total += SquareByOddSum(i);
        return total;
    }

    static void Main()
    {
        Console.Write("Введите n (n ≥ 1): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Ошибка: введите целое число, большее или равное 1.");
            return;
        }

        int result = SumOfSquares(n);
        Console.WriteLine($"Сумма 1² + 2² + … + {n}² = {result}");
    }
}
