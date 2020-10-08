using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число в см:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"{a / 100}м");
        }
    }
}
