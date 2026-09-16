using System;

namespace Task3.Unique
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };
            Console.WriteLine($"Исходный:  {string.Join(", ", source)}");

            int[] unique = GetUnique(source);
            Console.WriteLine($"Уникальные: {string.Join(", ", unique)}");
        }

        public static int[] GetUnique(int[] source)
        {
            if (source.Length == 0) return new int[0];
            int[] tempResult = new int[source.Length];
            int uniqueCount = 0;

            for (int i = 0; i < source.Length; i++)
            {
                bool alreadyExists = false;

                for (int j = 0; j < uniqueCount; j++)
                {
                    if (source[i] == tempResult[j])
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    tempResult[uniqueCount] = source[i];
                    uniqueCount++;
                }
            }

            int[] finalResult = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                finalResult[i] = tempResult[i];
            }

            return finalResult;
        }
    }
}