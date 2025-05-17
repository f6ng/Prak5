using System;

class Program
{

    static double SumOddPowers(double x)
    {
        double sum = 0.0;
        double term = x;      // текущее значение x^i, сначала x^1

        // пробегаем i = 1, 3, 5, 7, 9, 11
        for (int i = 1; i <= 11; i += 2)
        {
            sum += term / i;
            term *= x * x;   // повышаем степень с x^i до x^(i+2)
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Введите x: ");
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            Console.WriteLine("Ошибка: введите число.");
            return;
        }

        double result = SumOddPowers(x);
        Console.WriteLine($"Сумма ряда = {result:F6}");
    }
}
