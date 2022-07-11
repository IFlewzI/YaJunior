using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            ReadInt();
        }

        static void ReadInt()
        {
            string userInput;
            int integer;

            Console.Write("Введите целое число. Поле для ввода: ");
            userInput = Console.ReadLine();

            while (int.TryParse(userInput, out integer) == false)
            {
                Console.Clear();
                Console.Write("Были введены неверные данные, попробуйте ввести целое число ещё раз. Поле для ввода: ");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("\nЦелое число которое вы ввели: " + integer);
        }
    }
}
