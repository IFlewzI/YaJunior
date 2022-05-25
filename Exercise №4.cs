using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int summa = 0;
            int minRandomNumber = 0;
            int maxRandomNumber = 100;
            int firstSuitableNumber = 3;
            int secondSuitableNumber = 5;
            int number = random.Next(minRandomNumber, maxRandomNumber + 1);

            Console.WriteLine("Сгенерированное число: {0}", number);

            for (int i = 0; i <= number; i++)
            {
                if ((i % firstSuitableNumber == 0) || (i % secondSuitableNumber == 0))
                {
                    summa += i;
                }
            }

            Console.WriteLine("Сумма чисел, кратных {0} или {1}, но меньше {2}: {3}", firstSuitableNumber, secondSuitableNumber, number, summa);
        }
    }
}
