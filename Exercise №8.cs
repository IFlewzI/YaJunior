using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            bool isAccessGot = false;
            string password = "hot.dog";
            string userInput;
            int attemptsNumber = 3;
            int currentAttempt = 1;
            int attemptsLeft;

            for (int i = 0; i < attemptsNumber; i++)
            {
                Console.Write("Попытка №{0}. \nВведите пароль: ", currentAttempt);
                userInput = Console.ReadLine();

                attemptsLeft = attemptsNumber - currentAttempt;

                if (userInput == password)
                {
                    Console.WriteLine("Доступ получен.");
                    isAccessGot = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Осталось попыток: {0}", attemptsLeft);
                }

                currentAttempt++;
            }

            if (isAccessGot)
                Console.WriteLine("\nСекретное сообщение: На самом деле Хот Доги делаются не из собак... Ну, в большинстве случаев)");
            else
                Console.WriteLine("\nВы потратили все попытки. В доступе отказано.");
        }
    }
}
