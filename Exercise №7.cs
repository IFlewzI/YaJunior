using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            string userName;
            char strokeSymbol;
            int indent = 2;

            void printStrokedName(string name, char symbol)
            {
                for (int i = 0; i < name.Length + indent; i++)
                {
                    Console.Write(symbol);
                }

                Console.WriteLine("\n{0}{1}{2}", symbol, name, symbol);

                for (int i = 0; i < name.Length + indent; i++)
                {
                    Console.Write(symbol);
                }
            }

            Console.Write("Введите имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите символ: ");
            strokeSymbol = Convert.ToChar(Console.ReadLine());

            printStrokedName(userName, strokeSymbol);
        }
    }
}
