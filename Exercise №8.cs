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
            int[] numbers = new int[10];
            int quanityOfRepeats;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomNumber, maxRandomNumber + 1);
                Console.Write(numbers[i] + " ");
            }

            Console.Write("\n\nНа сколько символов вы хотите сдвинуть список? Поле для ввода: ");
            quanityOfRepeats = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quanityOfRepeats; i++)
            {
                int firstNumberInArray = numbers[0];

                for (int j = 0; j < numbers.Length - 1; j++)
                    numbers[j] = numbers[j + 1];

                numbers[numbers.Length - 1] = firstNumberInArray;
            }

            Console.WriteLine("\n\nСдвинутый список: ");

            for (int i = 0; i < numbers.Length; i++)
                Console.Write(numbers[i] + " ");
        }
    }
}
