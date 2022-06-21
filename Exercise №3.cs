using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int minRandomNumber = 0;
            int maxRandomNumber = 9;
            int[] numbers = new int[30];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomNumber, maxRandomNumber + 1);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nЛокальные максимумы: ");

            if (numbers[0] > numbers[1])
                Console.Write(numbers[0] + " ");

            if (numbers[numbers.Length - 1] > numbers[numbers.Length - 2])
                Console.Write(numbers[numbers.Length - 1] + " ");

            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                    Console.Write(numbers[i] + " ");
            }
        }
    }
}
