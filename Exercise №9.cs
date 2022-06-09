using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int N = random.Next(1, 27 + 1);
            int quanityOfMultiplesNumbers = 0;

            Console.WriteLine("Изначальное число: {0}", N);

            for (int i = N; Convert.ToString(i).Length < 4; i += N)
            {
                if (Convert.ToString(i).Length == 3)
                    quanityOfMultiplesNumbers++;
            }

            Console.WriteLine("Количество трёхзначиных чисел, которые кратны {0}: {1}", N, quanityOfMultiplesNumbers);
        }
    }
}
