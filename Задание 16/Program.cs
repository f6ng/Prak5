using System;

class Program
{

    static void PrintFibonacciUpTo(int m)
    {
        int prev = 0;
        int curr = 1;

        while (true)
        {
            Console.WriteLine(prev);
            if (prev > m)
                break;

            int next = prev + curr;
            prev = curr;
            curr = next;
        }
    }

    static void Main()
    {
        Console.Write("Введите максимальное значение M: ");
        if (int.TryParse(Console.ReadLine(), out int m))
        {
            PrintFibonacciUpTo(m);
        }
        else
        {
            Console.WriteLine("Ошибка: введено не целое число.");
        }
    }
}
