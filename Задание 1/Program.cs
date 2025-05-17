using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // читаем N из консоли
        int n = int.Parse(Console.ReadLine() ?? "0");
        // повторяем 20 N раз и склеиваем через пробел
        Console.WriteLine(string.Join(" ", Enumerable.Repeat(20, n)));
    }
}
