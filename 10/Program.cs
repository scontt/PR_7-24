using System;

namespace ConsoleApp1
{
    class Program
    {
        static int FirstMeth()
        {
            int sum = 0;

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}, эта программа считает положительные числа из введенных вами. " +
                "Введите четыре целых числа");

            Console.Write("Первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Четвертое число: ");
            int d = Convert.ToInt32(Console.ReadLine());

            sum = a > 0 ? sum += a : sum += 0;
            sum = b > 0 ? sum += b : sum += 0;
            sum = c > 0 ? sum += c : sum += 0;
            sum = d > 0 ? sum += d : sum += 0;

            Console.WriteLine($"Сумма положительных, среди введенных вами, чисел равна {sum}");
            Console.WriteLine($"Всего доброго, {name}!");

            return sum;
        }

        static int SecondMeth()
        {
            int sum = 0;

            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}, эта программа считает положительные числа из введенных вами. " +
                "Введите четыре целых числа");

            Console.Write("Первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Четвертое число: ");
            int d = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                sum += a;
            }
            if (b > 0)
            {
                sum += b;
            }
            if (c > 0)
            {
                sum += c;
            }
            if (d > 0)
            {
                sum += d;
            }

            Console.WriteLine($"Сумма положительных, среди введенных вами, чисел равна {sum}");
            Console.WriteLine($"Всего доброго, {name}!");

            return sum;
        }

        static void Main()
        {
            
        }
    }
}