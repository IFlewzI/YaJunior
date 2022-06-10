using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int number = random.Next(1, 27 + 1);
            int quanityOfMultiplesNumbers = 0;
            int requiredLengthOfMultilesNumbers = 3;

            Console.WriteLine("Изначальное число: {0}", number);

            for (int i = number; Convert.ToString(i).Length <= requiredLengthOfMultilesNumbers; i += number)
            {
                if (Convert.ToString(i).Length == requiredLengthOfMultilesNumbers)
                    quanityOfMultiplesNumbers++;
            }

            Console.WriteLine("Количество трёхзначных чисел, которые кратны {0}: {1}", number, quanityOfMultiplesNumbers);
        }
    }
}
