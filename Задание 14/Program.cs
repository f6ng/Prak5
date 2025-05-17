using System;

class Program
{
    // Переводит строку s (цифры 0–9) из системы с основанием b в десятичное число
    static int ToDecimal(string s, int b)
    {
        int result = 0, i = 0;
        bool negative = s[0] == '-';
        if (negative) i = 1;

        for (; i < s.Length; i++)
            result = result * b + (s[i] - '0');

        return negative ? -result : result;
    }

    static void Main()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        Console.Write("Введите основание (2–10): ");
        int baseSys = int.Parse(Console.ReadLine());

        int decimalValue = ToDecimal(input, baseSys);
        Console.WriteLine($"В десятичной системе: {decimalValue}");
    }
}
