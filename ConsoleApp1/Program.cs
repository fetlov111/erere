// See https://aka.ms/new-console-template for more information
using System;
 
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("ведите второе число: ");
            int y = int.Parse(Console.ReadLine());

            Random random = new Random();
            int k = random.Next(x, y);
            int count = 0;
            string str;

            Console.WriteLine("угадайчисло в интервале от {0} до {1}\n", x, y);

            do
            {
                Console.Write("твой вариант: ");
                str = Console.ReadLine();

                if (int.Parse(str) < k)
                    Console.WriteLine("задуманное число больше");
                if (int.Parse(str) > k)
                    Console.WriteLine("задуманное число меньше");

                count++;
            }
            while (int.Parse(str) != k);

            Console.WriteLine("Кравчик, ты угадал с {0} попытки", count);
            Console.ReadLine();
        }
    }
}