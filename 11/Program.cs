using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}, эта программа выводит слово, в зависимости от введенного вами символа");

            Console.Write("Введите символ: \n" +
                "M, P, Z - мальчик \n" +
                "G, Q - девочка \n" +
                "W, R, D - ребёнок \n" +
                "другой символ - человек \n");
            char k = Convert.ToChar(Console.ReadLine());

            switch (k)
            {
                case 'M':
                case 'P':
                case 'Z': Console.WriteLine($"Так как вы ввели символ {k}, результат - мальчик") ;
                    break;
                case 'g':
                case 'q': Console.WriteLine($"Так как вы ввели символ {k}, результат - девочка");
                    break;
                case 'w':
                case 'r':
                case 'd': Console.WriteLine($"Так как вы ввели символ {k}, результат - ребенок");
                    break;
                default: Console.WriteLine($"Так как вы ввели символ {k}, результат - человек");
                    break;
            }
            Console.WriteLine($"Всего доброго, {name}");
        }
    }
}