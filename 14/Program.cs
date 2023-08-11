using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            const int N = 17;
            string name;
            int key, min, 
                odd = 0,
                eve = 0;
            int[] arr = new int[17];


            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}\nНажмите любую клавишу...");
            Console.ReadKey();
            Random random = new Random();

            for ( ; ; )
            {                
                do
                {
                    Console.Clear();
                    Console.WriteLine("Данная программа заполняет массив из 17 элементов случайными числами, " +
                $"считает количество четных и нечетных элементов в нем и сортирует его линейным способом в порядке возрастания.");
                    Console.Write("\nВыберите пункт меню: \n" +
                    "1. Заполнить массив случайными числами\n" +
                    "2. Определить количество четных и нечетных элементов массива\n" +
                    "3. Отсортировать массив в порядке возрастания\n" +
                    "4. Выйти из программы\n" +
                    "Ввод: ");
                    key = Convert.ToInt32(Console.ReadLine());
                } while (key != 1 && key != 2 && key != 3 && key != 4);
                switch (key)
                {
                    case 1: // 1. Заполнить массив
                        {
                            Console.Clear();
                            Console.WriteLine("1. Заполнить массив случайными числами");

                            for (int i = 0; i < N; i++) // Заполнение массива случайными числами
                            {
                                arr[i] = random.Next(-100, 200);
                            }

                            Console.Write("Массив из 17 элементов, заполненный случайными числами в диапазоне от -100 до 200: ");
                            for (int i = 0; i < N; i++) // Вывод массива в консоль
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 2: // 2. Определить количество четных и нечетных элементов массива
                        {
                            Console.Clear();
                            Console.WriteLine("2. Определить количество четных и нечетных элементов массива");
                            for (int i = 0; i < N; i++) // Вывод массива в консоль
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();

                            for (int i = 0; i < N; i++) // Подсчет четных и нечентных элементов массива
                            {
                                if (arr[i] % 2 == 0)
                                {
                                    eve += 1;
                                }
                                else
                                {
                                    odd += 1;
                                }
                            }
                            Console.WriteLine($"\nМассив состоит из {eve} четных чисел и {odd} нечетных.");

                            if (eve > odd)
                            {
                                Console.WriteLine("Четных чисел больше, чем нечетных");
                            }
                            else if (odd > eve)
                            {
                                Console.WriteLine("Нечетных чисел больше, чем четных");
                            }
                            else
                            {
                                Console.WriteLine("Количество четных и нечентных чисел одинаково");
                            }
                            eve = odd = 0;
                        }
                        Console.WriteLine($"Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 3: // 3. Отсортировать массив в порядке возрастания
                        {
                            Console.Clear();
                            Console.WriteLine("3. Отсортировать массив в порядке возрастания");

                            for (int i = 0; i < N; i++) // Вывод массива в консоль
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();

                            for (int i = 0; i < N; i++) // Сортировка массива по возрастанию
                            {
                                for (int k = i; k < N; k++)
                                {
                                    if (arr[k] < arr[i])
                                    {
                                        min = arr[i];
                                        arr[i] = arr[k];
                                        arr[k] = min;
                                    }
                                }
                            }

                            Console.Write("Отсотированный массив: ");

                            for (int i = 0; i < N; i++) // Вывод отсортированного массива
                            {
                                Console.Write(arr[i] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.WriteLine($"Нажмите любую клавишу...");
                        Console.ReadKey();
                        break;
                    case 4: // Выход из программы
                        {
                            Console.Clear();
                            Console.WriteLine("4. Выйти из программы");
                            Console.WriteLine($"Всего доброго, {name}!");
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }
    }
}