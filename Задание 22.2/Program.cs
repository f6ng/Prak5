using System;

class Program22_2
{
    // Метод возвращает площадь участка (га) за указанный год
    public static double CalculateArea(int yearNumber)
    {
        const double initialArea = 100.0;      // га в 1-й год
        const double growthRate = 1.05;        // +5% в год

        int exponent = yearNumber - 1;         // для 1-го года — степень 0
        return initialArea * Math.Pow(growthRate, exponent);
    }

    static void Main()
    {
        Console.Write("Введите номер года (N ≥ 1): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
        {
            double area = CalculateArea(n);
            Console.WriteLine($"Площадь участка за {n}-й год: {area:F2} га");
        }
        else
        {
            Console.WriteLine("Ошибка: введите целое число ≥ 1.");
        }
    }
}
