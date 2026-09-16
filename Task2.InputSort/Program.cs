using System;

namespace Task2.InputSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            while (true)
            {
                Console.Write("Введите количество элементов: ");
                if (int.TryParse(Console.ReadLine(), out n) && n > 0)
                {
                    break;
                }
                Console.WriteLine("Ошибка: Количество должно быть целым числом больше нуля.");
            }

            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент [{i}]: ");
                    string input = Console.ReadLine();
                    try
                    {
                        array[i] = int.Parse(input);
                        break; 
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите корректное целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число слишком большое или слишком маленькое для int!");
                    }
                }
            }

            Console.WriteLine($"\nИсходный массив:  {string.Join(", ", array)}");

            Console.Write("Обратный порядок: ");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + (i == 0 ? "" : ", "));
            }
            Console.WriteLine();

            int min = array[0];
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            Array.Sort(array);
            Console.WriteLine($"Отсортированный:  {string.Join(", ", array)}");

            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}