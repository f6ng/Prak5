using System;

class Program22_1
{
    // Метод возвращает урожайность (ц/га) за указанный год
    public static double CalculateYield(int yearNumber)
    {
        const double initialYield = 20.0;      // ц/га в 1-й год
        const double growthRate = 1.02;        // +2% в год

        int exponent = yearNumber - 1;         // для 1-го года — степень 0
        return initialYield * Math.Pow(growthRate, exponent);
    }

    static void Main()
    {
        Console.Write("Введите номер года (N ≥ 1): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
        {
            double yield = CalculateYield(n);
            Console.WriteLine($"Урожайность за {n}-й год: {yield:F2} ц/га");
        }
        else
        {
            Console.WriteLine("Ошибка: введите целое число ≥ 1.");
        }
    }
}
