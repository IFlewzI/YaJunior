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
            int[] numbers = new int[30];
            int currentQuanityOfRepeats = 1;
            int maxQuanityOfRepeats = 0;
            int currentRepeatingNumber;
            int theMostRepeatingNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(minRandomNumber, maxRandomNumber + 1);
                Console.Write(numbers[i] + " ");
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentQuanityOfRepeats++;
                    currentRepeatingNumber = numbers[i];

                    if (currentQuanityOfRepeats > maxQuanityOfRepeats)
                    {
                        maxQuanityOfRepeats = currentQuanityOfRepeats;
                        theMostRepeatingNumber = currentRepeatingNumber;
                    }   
                }
                else
                {
                    currentQuanityOfRepeats = 1;
                }
            }

            Console.WriteLine("\n\nБольше всего повторялся символ: '{0}'. Он повторялся {1} раз", theMostRepeatingNumber, maxQuanityOfRepeats);
        }
    }
}
