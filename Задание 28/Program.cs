using System;

class Program
{
    // Перегрузка для сложения двух чисел
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // Перегрузка для сложения трёх чисел
    public static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    // Перегрузка для сложения четырёх чисел
    public static int Add(int a, int b, int c, int d)
    {
        return a + b + c + d;
    }

    static void Main()
    {
        Console.Write("Сколько чисел складываем (2, 3 или 4)? ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count < 2 || count > 4)
        {
            Console.WriteLine("Ошибка: введите 2, 3 или 4.");
            return;
        }

        Console.Write($"Введите {count} целых чисел через пробел: ");
        string[] parts = Console.ReadLine()
                                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length != count)
        {
            Console.WriteLine($"Ошибка: ожидаются ровно {count} чисел.");
            return;
        }

        int[] nums = new int[count];
        for (int i = 0; i < count; i++)
        {
            if (!int.TryParse(parts[i], out nums[i]))
            {
                Console.WriteLine("Ошибка: введите корректные целые числа.");
                return;
            }
        }

        int result;
        switch (count)
        {
            case 2:
                result = Add(nums[0], nums[1]);
                break;
            case 3:
                result = Add(nums[0], nums[1], nums[2]);
                break;
            default: // count == 4
                result = Add(nums[0], nums[1], nums[2], nums[3]);
                break;
        }

        Console.WriteLine($"Результат сложения: {result}");
    }
}
