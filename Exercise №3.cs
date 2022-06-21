using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int[] numbers = new int[30];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(0, 10);
                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine("\n\nЛокальные максимумы: ");

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    if (numbers[i] > numbers[i + 1])
                        Console.Write(numbers[i] + " ");
                }
                else if (i == numbers.Length - 1)
                {
                    if (numbers[i] > numbers[i - 1])
                        Console.Write(numbers[i] + " ");
                }
                else
                {
                    if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                        Console.Write(numbers[i] + " ");
                }
            }
        }
    }
}
