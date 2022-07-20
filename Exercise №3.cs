using System;
using System.Collections.Generic;
using System.Linq;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>();
            bool isProgramRunning = true;
            string userInput;

            while (isProgramRunning)
            {
                Console.Write("Введите число или слово sum (exit для выхода). Поле для ввода: ");
                userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "sum":
                        Sum(numbers);
                        break;
                    case "exit":
                        isProgramRunning = false;
                        break;
                    default:
                        AddNumber(ref numbers, userInput);
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void Sum(List<int> numbers)
        {
            int sum = 0;

            for (int i = 0; i < numbers.Count; i++)
                sum += numbers[i];

            Console.WriteLine("\nСумма всех введённых ранее чисел: " + sum);
        }

        static void AddNumber(ref List<int> numbers, string userInput)
        {
            int convertedNumber;

            if (int.TryParse(userInput, out convertedNumber))
            {
                numbers.Add(convertedNumber);
                Console.WriteLine("\nЧисло было успешно добавлено.");
            }
            else
            {
                Console.WriteLine("\nБыло введено не число и не команда.");
            }
        }
    }
}
