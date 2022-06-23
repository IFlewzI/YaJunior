using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            int minRandomNumber = -9;
            int maxRandomNumber = 9;
            bool isArraySorted = false;
            int[] numbers = new int[10];
            int[] tempNumbers = new int[numbers.Length];
            int quanityOfTransferedNumbers = 0;
            int minUntransferedNumber;


            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomNumber, maxRandomNumber + 1);
                Console.Write(numbers[i] + " ");
            }

            while (isArraySorted != true)
            {
                minUntransferedNumber = int.MaxValue;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < minUntransferedNumber)
                        minUntransferedNumber = numbers[i];
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] == minUntransferedNumber)
                    {
                        tempNumbers[quanityOfTransferedNumbers] = numbers[i];
                        numbers[i] = int.MaxValue;
                        quanityOfTransferedNumbers++;
                        break;
                    }
                }

                if (quanityOfTransferedNumbers == numbers.Length)
                {
                    numbers = tempNumbers;
                    isArraySorted = true;
                }
            }

            Console.WriteLine("\n\nОтсортированный массив: ");

            foreach (int number in numbers)
                Console.Write(number + " ");
        }
    }
}
