using System;

class Program
{
    /// <summary>
    /// Сколько месяцев потребуется, чтобы вклад, увеличивающийся каждый
    /// месяц на percent%, достиг суммы target.
    /// </summary>
    /// <param name="deposit">Начальная сумма вклада</param>
    /// <param name="percent">Ежемесячный процент (например, 5 — значит 5%)</param>
    /// <param name="target">Желаемая сумма накопления</param>
    /// <returns>Количество полных месяцев</returns>
    static int CalculateMonths(double deposit, double percent, double target)
    {
        int months = 0;
        while (deposit < target)
        {
            deposit += deposit * percent / 100;
            months++;
        }
        return months;
    }

    static void Main()
    {
        Console.Write("Введите начальную сумму вклада: ");
        double initial = double.Parse(Console.ReadLine());

        Console.Write("Введите ежемесячный процент (2–10): ");
        double rate = double.Parse(Console.ReadLine());

        Console.Write("Введите желаемую сумму для накопления: ");
        double target = double.Parse(Console.ReadLine());

        int months = CalculateMonths(initial, rate, target);
        Console.WriteLine($"\nПотребуется {months} месяцев, чтобы накопить {target} руб.");
    }
}
