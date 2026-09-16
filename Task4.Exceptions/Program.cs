using System;

namespace Task4.Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    string input = Console.ReadLine();
                    try
                    {
                        array[i] = int.Parse(input);
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число слишком большое!");
                    }
                }
            }

            while (true)
            {
                Console.Write($"\nВведите индекс для вывода (0-{array.Length - 1}): ");
                string indexInput = Console.ReadLine();

                try
                {
                    int index = int.Parse(indexInput);

                    int value = array[index];
                    Console.WriteLine($"Элемент по индексу {index} равен: {value}");
                    break; 
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine("Ошибка: Индекс вне границ массива.");
                    Console.WriteLine($"Детали: {ex.Message}");
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ошибка: Введен некорректный формат индекса.");
                }
            }
        }
    }
}