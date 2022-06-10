using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int requiredNumber = random.Next(0, 100000);
            int numberThatRaisingToAPower = 2;
            int requiredDegree = 0;
            int finalNumber = 0;

            for (int i = 0; finalNumber < requiredNumber; i++)
            {
                requiredDegree = i;
                finalNumber = Convert.ToInt32(Math.Pow(numberThatRaisingToAPower, requiredDegree));
            }

            Console.WriteLine("Чтобы получить число, которое будет больше {0}, нужно возвести {1} в степень {2} и получить число {3}. ",
                requiredNumber, numberThatRaisingToAPower, requiredDegree, finalNumber);
        }
    }
}
