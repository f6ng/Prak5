using System;

class Program
{

    static double CalculateAverageMass(int count)
    {
        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            Console.Write($"Введите массу предмета {i + 1}: ");
            if (!double.TryParse(Console.ReadLine(), out double mass))
            {
                Console.WriteLine("Ошибка: введите число. Попробуем снова.");
                i--; // повторим ввод для этого же индекса
                continue;
            }
            sum += mass;
        }
        return sum / count;
    }

    static void Main()
    {
        Console.Write("Сколько предметов вы хотите взвесить? ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count <= 0)
        {
            Console.WriteLine("Ошибка: введите положительное целое число.");
            return;
        }

        double averageMass = CalculateAverageMass(count);
        Console.WriteLine($"\nСредняя масса предметов: {averageMass:F2}");
    }
}
