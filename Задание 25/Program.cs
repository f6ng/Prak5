using System;

class Program
{
    /// <summary>
    /// Вычисляет расстояние между точками (x1, y1) и (x2, y2).
    /// </summary>
    public static double Distance(double x1, double y1, double x2, double y2)
    {
        double dx = x2 - x1;
        double dy = y2 - y1;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    static void Main()
    {
        // Считываем координаты первой точки
        Console.Write("Введите координаты первой точки (x1 y1): ");
        string[] first = Console.ReadLine()
                                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (first.Length != 2
            || !double.TryParse(first[0], out double x1)
            || !double.TryParse(first[1], out double y1))
        {
            Console.WriteLine("Ошибка ввода. Нужно ввести два числа через пробел.");
            return;
        }

        // Считываем координаты второй точки
        Console.Write("Введите координаты второй точки (x2 y2): ");
        string[] second = Console.ReadLine()
                                 .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (second.Length != 2
            || !double.TryParse(second[0], out double x2)
            || !double.TryParse(second[1], out double y2))
        {
            Console.WriteLine("Ошибка ввода. Нужно ввести два числа через пробел.");
            return;
        }

        // Вычисляем и выводим результат
        double dist = Distance(x1, y1, x2, y2);
        Console.WriteLine($"Расстояние между точками: {dist:F4}");
    }
}
