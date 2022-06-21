using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int[,] numbers = new int[10, 10];
            int maxNumber = int.MinValue;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    numbers[i, j] = random.Next(0, 10);

                    if (maxNumber < numbers[i, j])
                        maxNumber = numbers[i, j];

                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("\nМаксимальное число в матрице: {0}", maxNumber);
            Console.WriteLine("\nИзменённая матрица: \n");

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i, j] == maxNumber)
                        numbers[i, j] = 0;

                    Console.Write(numbers[i, j] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
