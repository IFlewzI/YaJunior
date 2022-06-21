using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            bool isProgramRunning = true;
            string userInput;
            float[] numbers = new float[1];

            while (isProgramRunning)
            {
                Console.Write("\nВведите число или команду exit/sum. Поле для ввода: ");
                userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "sum":
                        float sumOfNumbers = 0;

                        for (int i = 0; i < numbers.Length; i++)
                            sumOfNumbers += numbers[i];

                        Console.WriteLine("\nСумма всех введённых чисел равна: {0}", sumOfNumbers);
                        break;
                    case "exit":
                        isProgramRunning = false;
                        break;
                    default:
                        numbers[numbers.Length - 1] = Convert.ToInt32(userInput);
                        float[] tempNumbers = new float[numbers.Length + 1];

                        for (int i = 0; i < numbers.Length; i++)
                            tempNumbers[i] = numbers[i];

                        numbers = tempNumbers;
                        break;
                }
            }
        }
    }
}
