using System;

namespace Task1.Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 101); 
            }

            Console.WriteLine($"Массив: {string.Join(", ", array)}");

            int sum = 0;
            double product = 1.0; 
            int evenCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                product *= array[i];

                if (array[i] % 2 == 0)
                {
                    evenCount++;
                }
            }

            double average = (double)sum / array.Length;

            int aboveAverageCount = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > average)
                {
                    aboveAverageCount++;
                }
            }

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product:E2}");
            Console.WriteLine($"Чётных чисел: {evenCount}");
            Console.WriteLine($"Больше среднего ({average:F1}): {aboveAverageCount}");
        }
    }
}