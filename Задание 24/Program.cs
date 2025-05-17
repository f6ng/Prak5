using System;

class PowerCalculator
{
    /// <summary>
    /// Возводит целое число в неотрицательную целую степень.
    /// </summary>
    /// <param name="baseValue">Основание степени.</param>
    /// <param name="exponent">Показатель степени (неотрицательное число).</param>
    /// <returns>Результат baseValue^exponent.</returns>
    /// <exception cref="ArgumentException">
    /// Бросается, если exponent &lt; 0.
    /// </exception>
    public static int GetPow(int baseValue, int exponent)
    {
        if (exponent < 0)
            throw new ArgumentException("Показатель степени должен быть неотрицательным.");

        int result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseValue;
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Введите основание и показатель степени через пробел: ");
        string[] parts = Console.ReadLine()
                                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != 2
            || !int.TryParse(parts[0], out int baseValue)
            || !int.TryParse(parts[1], out int exponent))
        {
            Console.WriteLine("Неверный ввод. Введите два целых числа.");
            return;
        }

        try
        {
            int power = GetPow(baseValue, exponent);
            Console.WriteLine($"{baseValue}^{exponent} = {power}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
