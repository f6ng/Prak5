using System;

class Program
{
    // Метод возвращает n^2 через сумму первых n нечётных чисел:
    // 1 + 3 + 5 + … + (2n – 1)
    static int SquareByOddSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += 2 * i - 1;  // i-я нечётная величина: 2*i–1
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Введите натуральное число n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 1)
        {
            Console.WriteLine("Ошибка: введите целое число ≥ 1.");
            return;
        }

        int square = SquareByOddSum(n);
        Console.WriteLine($"{n}² = {square}");
    }
}
