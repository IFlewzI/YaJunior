using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            int sumOfNumbers = 0;
            int productOfNumbers = 1;
            int requiredString = 2;
            int requiredColumn = 1;
            int[,] numbers = { 
                { 3, 2, 4, 5, 2, 3 }, 
                { 1, 1, 0, 4, 5, 4 }, 
                { 3, 4, 2, 1, 2, 3 }, 
                { 5, 2, 1, 3, 2, 4 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.Write(numbers[i, j] + " ");

                    if (i == requiredString - 1)
                        sumOfNumbers += numbers[i, j];

                    if (j == requiredColumn - 1)
                        productOfNumbers *= numbers[i, j];
                }
                
                Console.WriteLine();
            }

            Console.WriteLine("\nСумма строки №{0}: {1} \n\nПроизведение столбца №{2}: {3}", requiredString, sumOfNumbers, requiredColumn, productOfNumbers);
        }
    }
}
