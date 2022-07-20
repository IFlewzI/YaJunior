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
                        int sum = 0;

                        for (int i = 0; i < numbers.Count; i++)
                            sum += numbers[i];

                        Console.WriteLine("\nСумма всех введённых ранее чисел: " + sum);
                        break;
                    case "exit":
                        isProgramRunning = false;
                        break;
                    default:
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
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
