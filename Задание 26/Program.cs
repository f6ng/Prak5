using System;

class Program
{
    /// <summary>
    /// Возвращает минимальное из трёх целых чисел.
    /// </summary>
    public static int MinOfThree(int a, int b, int c)
    {
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        return min;
    }

    static void Main()
    {
        Console.WriteLine("Введите три целых числа через пробел:");
        string[] parts = Console.ReadLine()
                                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 3
            || !int.TryParse(parts[0], out int a)
            || !int.TryParse(parts[1], out int b)
            || !int.TryParse(parts[2], out int c))
        {
            Console.WriteLine("Ошибка: введите ровно три целых числа.");
            return;
        }

        int minimum = MinOfThree(a, b, c);
        Console.WriteLine($"Минимальное из чисел {a}, {b} и {c} — это {minimum}.");
    }
}
