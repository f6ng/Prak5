using System;

class Program
{

    static void PrintDigits(int n)
    {
        if (n < 0)
        {
            Console.WriteLine("-"); // выводим знак минус отдельно
            n = -n;
        }
        // сначала напечатаем все старшие цифры
        if (n >= 10)
            PrintDigits(n / 10);
        // затем текущую (последнюю в оставшемся числе) цифру
        Console.WriteLine(n % 10);
    }

    static void Main()
    {
        Console.Write("Введите целое число N: ");
        if (int.TryParse(Console.ReadLine(), out int number))
            PrintDigits(number);
        else
            Console.WriteLine("Ошибка: введено не целое число.");
    }
}
