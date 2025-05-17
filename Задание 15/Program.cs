using System;

class Program
{
    /// <summary>
    /// Запрашивает у пользователя целое число от 1 до 100 (включительно)
    /// и возвращает его, повторяя ввод до корректного значения.
    /// </summary>
    static int ReadNumberInRange()
    {
        int n;
        do
        {
            Console.Write("Введите число от 1 до 100: ");
        }
        while (!int.TryParse(Console.ReadLine(), out n) || n < 1 || n > 100);
        return n;
    }

    static void Main()
    {
        int number = ReadNumberInRange();
        Console.WriteLine($"Вы ввели: {number}");
    }
}
