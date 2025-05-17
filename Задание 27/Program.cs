using System;

class Program
{
    // Перегрузка для трёх чисел
    public static int MinOfThree(int a, int b, int c)
    {
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        return min;
    }

    // Перегрузка для четырёх чисел
    public static int MinOfThree(int a, int b, int c, int d)
    {
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;
        return min;
    }

    // Перегрузка для пяти чисел
    public static int MinOfThree(int a, int b, int c, int d, int e)
    {
        int min = a;
        if (b < min) min = b;
        if (c < min) min = c;
        if (d < min) min = d;
        if (e < min) min = e;
        return min;
    }

    static void Main()
    {
        Console.Write("Сколько чисел будем сравнивать (3, 4 или 5)? ");
        if (!int.TryParse(Console.ReadLine(), out int count) || count < 3 || count > 5)
        {
            Console.WriteLine("Неверный ввод. Введите 3, 4 или 5.");
            return;
        }

        Console.Write($"Введите {count} целых чисел через пробел: ");
        string[] parts = Console.ReadLine()
                                .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

        if (parts.Length != count)
        {
            Console.WriteLine($"Нужно было ввести ровно {count} чисел.");
            return;
        }

        int[] nums = new int[count];
        for (int i = 0; i < count; i++)
        {
            if (!int.TryParse(parts[i], out nums[i]))
            {
                Console.WriteLine("Ошибка: введите только целые числа.");
                return;
            }
        }

        int minimum;
        switch (count)
        {
            case 3:
                minimum = MinOfThree(nums[0], nums[1], nums[2]);
                break;
            case 4:
                minimum = MinOf
