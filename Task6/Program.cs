using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");

            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Результат");

            if (a % 2 == 0)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");

            Console.ReadLine();
        }
    }
}
