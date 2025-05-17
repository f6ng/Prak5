using System;

class BarleyCalculator
{
    /// <summary>
    /// Вычисляет площадь и урожайность ячменя после заданного года.
    /// </summary>
    /// <param name="yearNumber">
    /// Номер года: 1 — первый год (100 га, 20 ц/га).
    /// </param>
    /// <param name="area">[out] Площадь участка (га).</param>
    /// <param name="yieldPerHectare">[out] Урожайность (ц/га).</param>
    public static void CalculateBarleyStats(
        int yearNumber,
        out double area,
        out double yieldPerHectare)
    {
        const double initialArea = 100.0;
        const double initialYield = 20.0;
        const double areaGrowthRate = 1.05;   // +5% в год
        const double yieldGrowthRate = 1.02;  // +2% в год

        int exponent = yearNumber - 1;
        area = initialArea * Math.Pow(areaGrowthRate, exponent);
        yieldPerHectare = initialYield * Math.Pow(yieldGrowthRate, exponent);
    }

    static void Main()
    {
        int n = 5; // пример
        CalculateBarleyStats(n, out double area, out double yield);
        double totalHarvest = area * yield;

        Console.WriteLine($"После {n}-го года:");
        Console.WriteLine($"  Площадь        = {area:F2} га");
        Console.WriteLine($"  Урожайность    = {yield:F2} ц/га");
        Console.WriteLine($"  Общий сбор     = {totalHarvest:F2} ц");
    }
}
