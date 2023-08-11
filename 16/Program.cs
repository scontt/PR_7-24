using System;
using System.Diagnostics.CodeAnalysis;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[9]; arr[1] = new int[4]; arr[2] = new int[4];
            string name;
            int key;


            Console.Write("Введите имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"Здравствуйте, {name}!");
            Console.Write("\nНажмите любую клавишу... ");
            Console.ReadKey();

            for (; ; )
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Данная программа заполняет два ступенчатых массива и помещает результат выполнения операций " +
                        "над ними в третий массив");
                    Console.Write("Выберите пункт: \n" +
                    "1. Заполнить первый массив из 9 чисел\n" +
                    "2. Заполнить второй массив из 4 чисел\n" +
                    "3. Высчитать сумму положительных элементов первого массива\n" +
                    "4. Высчитать сумму отрицательных элементов второго массива\n" +
                    "5. Высчитать количество четных элементов первого массива\n" +
                    "6. Высчитать количество нечетных элементов второго массива\n" +
                    "7. Вывести весь ступенчатый массив\n"+
                    "8. Выйти из программы\n" +
                    "Ввод: ");
                    key = Convert.ToInt32(Console.ReadLine());
                } while (key != 1 && key != 2 && key != 3 && key != 4 && key != 5 && key != 6 && key != 7 && key != 8);
                switch (key)
                {
                    case 1: // Заполнить первый массив
                        {
                            Console.Clear();
                            Console.WriteLine("1. Заполнить первый массив из 9 чисел");
                            Console.WriteLine("Введите значения массива");
                            for (int i = 0; i < 9; i++) // Ввод первого массива
                            {
                                Console.Write($"{i + 1} элемент: ");
                                arr[0][i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.Clear();
                            Console.WriteLine("Вы ввели массив");
                            for (int i = 0; i < 9; i++) // Вывод первого массива
                            {
                                Console.Write(arr[0][i] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 2: // Заполнить второй массив из 4 чисел
                        {
                            Console.Clear();
                            Console.WriteLine("1. Заполнить второй массив 4 чисел");
                            Console.WriteLine("Введите значения массива");
                            for (int i = 0; i < 4; i++) // Ввод второго массива
                            {
                                Console.Write($"{i + 1} элемент: ");
                                arr[1][i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.Clear();
                            Console.WriteLine("Вы ввели массив");
                            for (int i = 0; i < 4; i++) // Вывод второго массива
                            {
                                Console.Write(arr[1][i] + " ");
                            }
                            Console.WriteLine();
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 3: // Высчитать сумму положительных элементов первого массива
                        {
                            Console.Clear();
                            Console.WriteLine("3. Высчитать сумму положительных элементов первого массива");
                            Console.WriteLine("Первый массив");
                            for (int i = 0; i < 9; i++)
                            {
                                Console.Write(arr[0][i] + " ");
                            }
                            int sum = 0;
                            Console.Write("\nПоложительные числа: ");
                            for (int i = 0; i < 9; i++) // Складывание и вывод положительных элементов первого массива
                            {
                                if (arr[0][i] > 0)
                                {
                                    sum += arr[0][i];
                                    Console.Write(arr[0][i] + " ");
                                }
                            }
                            arr[2][0] = sum;
                            Console.WriteLine("\nСумма положительных элементов первого массива равна " + arr[2][0]);
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 4: // Высчитать сумму отрицательных элементов второго массива
                        {
                            Console.Clear();
                            Console.WriteLine("4. Высчитать сумму отрицательных элементов второго массива");
                            Console.WriteLine("Второй массив");
                            for (int i = 0; i < 4; i++)
                            {
                                Console.Write(arr[1][i] + " ");
                            }
                            int sum = 0;
                            Console.Write("\nНечетные числа: ");
                            for (int i = 0; i < 4; i++) // Складывание и вывод отрицательных элементов второго массива
                            {
                                if (arr[1][i] < 0)
                                {
                                    sum += arr[1][i];
                                    Console.Write(arr[1][i] + " ");
                                }
                            }
                            arr[2][1] = sum;
                            Console.WriteLine("\nСумма отрицательных элементов второго массива равна " + arr[2][1]);
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 5: // Высчитать количество четных элементов первого массива
                        {
                            Console.Clear();
                            Console.WriteLine("5. Высчитать количество четных элементов первого массива");
                            Console.WriteLine("Первый массив");
                            for (int i = 0; i < 9; i++)
                            {
                                Console.Write(arr[0][i] + " ");
                            }
                            int even = 0;
                            Console.Write("\nЧетные числа: ");
                            for (int i = 0; i < 9; i++) // Подсчет и вывод четных чисел из певрого массива
                            {
                                if (arr[0][i] % 2 == 0)
                                {
                                    even++;
                                    Console.Write(arr[0][i] + " ");
                                }
                            }
                            arr[2][2] = even;
                            Console.WriteLine("\nЧетных чисел: " + even);
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 6: // Высчитать количество нечетных элементов второго массива
                        {
                            Console.Clear();
                            Console.WriteLine("4. Высчитать сумму отрицательных элементов второго массива");
                            Console.WriteLine("Второй массив");
                            for (int i = 0; i < 4; i++)
                            {
                                Console.Write(arr[1][i] + " ");
                            }
                            int odd = 0;
                            Console.Write("\nНечетные числа: ");
                            for (int i = 0; i < 4; i++) // Подсчет и вывод нечетных чисел из второго массива
                            {
                                if (Math.Abs(arr[1][i]) % 2 == 1)
                                {
                                    odd++;
                                    Console.Write(arr[1][i] + " ");
                                }
                            }
                            arr[2][3] = odd;
                            Console.WriteLine("\nНечетных чисел: " + odd);
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 7: // Вывести весь ступенчатый массив
                        {
                            Console.Clear();
                            Console.WriteLine("7. Вывести весь ступенчатый массив");
                            Console.WriteLine("Весь ступенчатый массив");
                            foreach (var row in arr)
                                Console.WriteLine(string.Join("\t", row));
                        }
                        Console.Write("\nНажмите любую клавишу... ");
                        Console.ReadKey();
                        break;
                    case 8: // Выйти из программы
                        {
                            Environment.Exit(0);
                        }
                        break;
                }
            }
        }
    }
}