using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            string userMassage;
            int timesToRepeat;

            Console.Write("Какое сообщение вы хотите вывести? \nПоле для ввода: ");
            userMassage = Console.ReadLine();
            Console.Write("Ладно, а сколько раз его надо вывести? \nПоле для ввода: ");
            timesToRepeat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вуаля!");
            for (int i = 1; i <= timesToRepeat; i++)
            {
                Console.WriteLine(userMassage);
            }
        }
    }
}
