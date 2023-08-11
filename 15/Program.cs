using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int key, a;
            int[,] array = new int[8, 8];

            Console.Write("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}!");
            Console.Write("\nНажмите любую клавишу... ");
            Console.ReadKey();

            Random random = new Random(); // Создание объекта класса Random
            for (; ; )
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Данная программа заполняет двумерный массив 8*8 случайными числами в диапазоне [-300; 500], " +
                    "заменяет все элементы главной диагонали массива на -1 и сортирует все четные строки в порядке убывания");
                    Console.Write("Выберите пункт меню:\n" +
                    "1. Заполнить двумерный массив размером 8*8 случайными числами\n" +
                    "2. Заменить все элементы главной диагонали массива на -1\n" +
                    "3. Отсортировать все четные строки массива в порядке убывания\n" +
                    "4. Выйти из программы\n" +
                    "Ввод: ");
                    key = Convert.ToInt32(Console.ReadLine());
                } while (key != 1 && key != 2 && key != 3 && key != 4);
                switch (key)
                {
                    case 1: // 1. Заполнить двумерный массив размером 8*8 случайными числами
                        {
                            Console.Clear();
                            Console.WriteLine("1. Заполнить двумерный массив размером 8*8 случайными числами");
                            for (int i = 0; i < 8; i++) // Заполнение массива случайными числами
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    array[i, j] = random.Next(-300, 500);
                                }
                            }

                            Console.WriteLine("Содержание массива: ");
                            for (int i = 0; i < 8; i++) // Вывод массива в консоль
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    Console.Write(array[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("2. Заменить все элементы главной диагонали массива на -1");

                            Console.WriteLine("Массив до замены элементов: ");
                            for (int i = 0; i < 8; i++) // Вывод массива в консоль
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    Console.Write(array[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }

                            for (int i = 0; i < 8; i++) // Замена всех элементов главной диагонали массива на -1
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    if (i == j)
                                    {
                                        array[i, j] = -1;
                                    }
                                }
                            }

                            Console.WriteLine("\nМассива после замены элементов: ");
                            for (int i = 0; i < 8; i++) // Вывод массива в консоль
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    Console.Write(array[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("3. Отсортировать все четные строки массива в порядке убывания");

                            Console.WriteLine("Массив до сортировки: ");
                            for (int i = 0; i < 8; i++) // Вывод массива в консоль
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    Console.Write(array[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("\nМассив после сортировки: ");
                            for (int i = 0; i < 8; i++) // Сортировка четных строк массива массива
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    if (i % 2 == 1)
                                    {
                                        for (int k = j; k < 8; k++)
                                        {
                                            if (array[i, k] > array[i, j])
                                            {
                                                a = array[i, j];
                                                array[i, j] = array[i, k];
                                                array[i, k] = a;
                                            }
                                        }
                                    }
                                }
                            }

                            for (int i = 0; i < 8; i++) // Вывод массива в консоль
                            {
                                for (int j = 0; j < 8; j++)
                                {
                                    Console.Write(array[i, j] + "\t");
                                }
                                Console.WriteLine();
                            }
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 4:
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }
    }
}