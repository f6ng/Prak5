using System;

class Triangle
{
    /// <summary>
    /// Вычисляет периметр треугольника по трём сторонам.
    /// </summary>
    /// <param name="a">Длина первой стороны.</param>
    /// <param name="b">Длина второй стороны.</param>
    /// <param name="c">Длина третьей стороны.</param>
    /// <returns>Периметр треугольника.</returns>
    public static double Perimeter(double a, double b, double c)
    {
        return a + b + c;
    }

    static void Main()
    {
        Console.WriteLine("Введите длины трёх сторон треугольника через пробел:");
        string input = Console.ReadLine();
        string[] parts = input.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 3
            || !double.TryParse(parts[0], out double a)
            || !double.TryParse(parts[1], out double b)
            || !double.TryParse(parts[2], out double c))
        {
            Console.WriteLine("Ошибка ввода. Убедитесь, что введены три числа.");
            return;
        }

        double p = Perimeter(a, b, c);
        Console.WriteLine($"Периметр треугольника со сторонами {a}, {b}, {c} равен {p:F2}.");
    }
}
