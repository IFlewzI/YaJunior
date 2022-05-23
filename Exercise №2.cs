using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            string userInput;

            do
            {
                Console.Write("Введите текст: ");
                userInput = Console.ReadLine();
            } while (userInput.ToLower() != "exit");
        }
    }
}
