using System;

class Program
{
    // Метод печатает число m ровно n раз, разделяя элементы пробелом
    static void PrintSeries(int m, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(m);
            if (i < n - 1)
                Console.Write(" ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        const int M = 20;  // по условию M = 20

        Console.Write("Введите длину ряда N: ");
        if (!int.TryParse(Console.ReadLine(), out int N) || N < 0)
        {
            Console.WriteLine("Ошибка: введите неотрицательное целое число.");
            return;
        }

        PrintSeries(M, N);
    }
}
