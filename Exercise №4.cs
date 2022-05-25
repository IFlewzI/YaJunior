using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int summa = 0;
            int number = random.Next(0, 101);
            int firstSuitableNumber = 3;
            int secondSuitableNumber = 5;

            Console.WriteLine("Сгенерированное число: {0}", number);

            for (int i = 0; i <= number; i++)
            {
                if ((i % firstSuitableNumber == 0) || (i % secondSuitableNumber == 0))
                {
                    summa += i;
                }
            }

            Console.WriteLine("Сумма чисел, кратных 3 или 5, но меньше {0}: {1}", number, summa);
        }
    }
}
