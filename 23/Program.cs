using System;
using System.IO;
using System.Text;

struct Processor
{
    public string corp, name, cooling, frequency, price, cores, cache;
    public Processor(string a, string b, string c, string d, string e, string f, string g)
    {
        corp = a;
        name = b;
        cooling = c;
        price = d;
        frequency = e;
        cores = f;
        cache = g;
    }
}

class Program
{
    static void Main()
    {
        string name, freq;
        int key, k = 0, n = 0;
        Processor processor;
        BinaryWriter input;
        BinaryReader output;

        Console.Write("Введите имя: ");
        name = Console.ReadLine();

        for (; ; )
        {
            do
            {
                Console.Clear();
                Console.WriteLine($"Здравствуйте, {name}, данная программа заполняет структуру в двоичном файле и производит" +
                    $"с ней операции в соответствии с выбором.");
                Console.WriteLine("Выберите пункт:\n" +
                    "1. Заполнить и сохранить в двоичном файле данные о процессорах\n" +
                    "2. Вывести на экран данные в соответствии с критерием\n" +
                    "3. Выйти из программы\n");
                key = Convert.ToInt32(Console.ReadLine());
            } while (key != 1 && key != 2 && key != 3);
            switch (key)
            {
                case 1:
                    {
                        Console.Clear();
                        Console.WriteLine("1. Заполнить и сохранить в двоичном файле данные о процессорах");
                        Console.WriteLine("Введите информацию о процессорах и по окончании нажмите Enter:");
                        try
                        {
                            input = new BinaryWriter(new FileStream(@"C:\Users\1\Desktop\data.dat", FileMode.Create));
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        try
                        {
                            for (; ; )
                            {
                                Console.Write("Название фирмы-производителя: ");
                                processor.corp = Console.ReadLine();
                                if (processor.corp == "") break;
                                Console.Write("Наименование процессора: ");
                                processor.name = Console.ReadLine();
                                if (processor.name == "") break;
                                Console.Write("Тип охлаждения: ");
                                processor.cooling = Console.ReadLine();
                                if (processor.cooling == "") break;
                                Console.Write("Цена: ");
                                processor.price = Console.ReadLine();
                                if (processor.price == "") break;
                                Console.Write("Частота (в МГц): ");
                                processor.frequency = Console.ReadLine();
                                if (processor.frequency == "") break;
                                Console.Write("Количество ядер: ");
                                processor.cores = Console.ReadLine();
                                if (processor.cores == "") break;
                                Console.Write("Объем кэш-памяти: ");
                                processor.cache = Console.ReadLine();
                                if (processor.cache == "") break;
                                Console.WriteLine();
                                input.Write(processor.corp);
                                input.Write(processor.name);
                                input.Write(processor.cooling);
                                input.Write(processor.price);
                                input.Write(processor.frequency);
                                input.Write(processor.cores);
                                input.Write(processor.cache);
                                k++;
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                        finally
                        {
                            input.Close();
                        }
                        Console.WriteLine("Данные записаны в файл\n");
                    }
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                case 2: // 2. Вывести на экран данные в соответствии с критерием
                    {
                        Console.Clear();
                        Console.WriteLine("2. Вывести на экран данные в соответствии с критерием");
                        if (k == 0) Console.WriteLine("Данные отсутствуют");
                        else
                        {
                            try
                            {
                                output = new BinaryReader(new FileStream(@"C:\Users\1\Desktop\data.dat", FileMode.Open));
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                            try
                            {
                                Console.Write("Введите частоту процессоров: ");
                                freq = Console.ReadLine();
                                Console.WriteLine($"Список с данными о процессорах с частотой {freq}:");
                                while (output.PeekChar() > -1)
                                {
                                    processor.corp = output.ReadString();
                                    processor.name = output.ReadString();
                                    processor.cooling = output.ReadString();
                                    processor.price = output.ReadString();
                                    processor.frequency = output.ReadString();
                                    processor.cores = output.ReadString();
                                    processor.cache = output.ReadString();
                                    if (processor.frequency.Equals(freq, StringComparison.OrdinalIgnoreCase))
                                    {
                                        Console.WriteLine($"Название корпорации: {processor.corp}\n" +
                                            $"Название процессора: {processor.name}\n" +
                                            $"Тип охлаждения: {processor.cooling}\n" +
                                            $"Цена: {processor.price}\n" +
                                            $"Частота: {processor.frequency} МГц\n" +
                                            $"Количество ядер: {processor.cores}\n" +
                                            $"Объем кэш-памяти: {processor.cache} МБ");
                                        n++;
                                    }
                                }
                                if (n == 0)
                                {
                                    Console.WriteLine("Нет совпадений.");
                                }
                                n = 0;
                            }
                            catch (Exception)
                            {
                                throw;
                            }
                            finally
                            {
                                output.Close();
                            }
                        }
                    }
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                case 3: Environment.Exit(0); // 3. Выйти из программы
                    break;
            }
        }
    }
}