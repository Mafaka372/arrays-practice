using System;

namespace Final.Task
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string[] students = { "Анна", "Борис", "Виктор", "Галина" };
            int[] grades      = { 85, 92, 78, 95 };

            Console.WriteLine($"{"Имя",-10} | {"Баллы",5}");
            Console.WriteLine(new string('-', 18));
            
            int sum = 0;
            int maxGrade = grades[0];

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i],-10} | {grades[i],5}");
                sum += grades[i];

                if (grades[i] > maxGrade)
                {
                    maxGrade = grades[i];
                }
            }

            int bestStudentIndex = Array.IndexOf(grades, maxGrade);
            string bestStudent = students[bestStudentIndex];

            double average = (double)sum / grades.Length;

            Console.WriteLine(new string('-', 18));
            Console.WriteLine($"Лучший студент: {bestStudent} ({maxGrade} баллов)");
            Console.WriteLine($"Средний балл группы: {average:F1}");
        }
    }
}