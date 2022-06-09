using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int numberForWhichWeSearchingMultiplesNumbers = random.Next(1, 27 + 1);
            int quanityOfMultiplesNumbers = 0;
            int requiredLengthOfMultilesNumbers = 3;

            Console.WriteLine("Изначальное число: {0}", numberForWhichWeSearchingMultiplesNumbers);

            for (int i = numberForWhichWeSearchingMultiplesNumbers; Convert.ToString(i).Length <= requiredLengthOfMultilesNumbers; i += numberForWhichWeSearchingMultiplesNumbers)
            {
                if (Convert.ToString(i).Length == requiredLengthOfMultilesNumbers)
                    quanityOfMultiplesNumbers++;
            }

            Console.WriteLine("Количество трёхзначных чисел, которые кратны {0}: {1}", numberForWhichWeSearchingMultiplesNumbers, quanityOfMultiplesNumbers);
        }
    }
}
