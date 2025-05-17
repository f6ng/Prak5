using System;

class Program
{

    static double CalculateAverage(int[] grades)
    {
        double sum = 0;
        foreach (int g in grades)
            sum += g;
        return sum / grades.Length;
    }

    static void Main()
    {
        int[] grades = new int[10];
        for (int i = 0; i < grades.Length; i++)
        {
            Console.Write($"Введите оценку {i + 1} (0–100): ");
            // Простейшая проверка: если ввод некорректен, пусть бросит исключение
            grades[i] = int.Parse(Console.ReadLine());
        }

        double average = CalculateAverage(grades);
        Console.WriteLine($"\nСредняя оценка ученика: {average:F2}");
    }
}
