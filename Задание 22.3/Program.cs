using System;

class Program22_3
{
    const double initialArea = 100.0;      // га в 1-й год
    const double areaGrowth = 1.05;        // +5% в год
    const double initialYield = 20.0;      // ц/га в 1-й год
    const double yieldGrowth = 1.02;       // +2% в год

    // Площадь в i-й год
    public static double CalculateArea(int year)
        => initialArea * Math.Pow(areaGrowth, year - 1);

    // Урожайность в i-й год
    public static double CalculateYield(int year)
        => initialYield * Math.Pow(yieldGrowth, year - 1);

    // Суммарный сбор за первые years лет
    public static double CalculateTotalHarvest(int years)
    {
        double sum = 0.0;
        for (int i = 1; i <= years; i++)
        {
            double area = CalculateArea(i);
            double yield = CalculateYield(i);
            sum += area * yield;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Введите число лет (N ≥ 1): ");
        if (int.TryParse(Console.ReadLine(), out int n) && n >= 1)
        {
            double totalHarvest = CalculateTotalHarvest(n);
            Console.WriteLine($"Общий сбор за первые {n} лет: {totalHarvest:F2} ц");
        }
        else
        {
            Console.WriteLine("Ошибка: введите целое число ≥ 1.");
        }
    }
}
