using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int summa = 0;
            int number = 6;

            Console.WriteLine("Сгенерированное число: {0}", number);

            for(int i = 0; i <= number; i++)
            {
                if ((i % 3 == 0) || (i % 5 == 0))
                {
                    summa += i;
                }
            }

            Console.WriteLine("Сумма чисел, кратных 3 или 5, но меньше {0}: {1}", number, summa);
        }
    }
}
