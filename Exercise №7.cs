using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            string userName;
            string symbolsString = "";
            char outlineSymbol;
            int indent = 2;

            Console.Write("Введите имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите символ: ");
            outlineSymbol = Convert.ToChar(Console.ReadLine());

            for (int i = 0; i < userName.Length + indent; i++)
            {
                symbolsString += outlineSymbol;
            }

            Console.WriteLine("{0} \n{1}{2}{1} \n{0}", symbolsString, outlineSymbol, userName);
        }
    }
}
