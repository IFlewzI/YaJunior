using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            int hourDuration = 60;
            int waitingTimeForOneGranny = 10;
            int overallWaitingTime;
            int waitingHours;
            int waitingMinutes;
            int grannysCount;

            Console.Write("Вы приходите в больницу и перед вами очередь к врачу. Сколько старушек вы видите? ");
            grannysCount = Convert.ToInt32(Console.ReadLine());

            waitingHours = grannysCount * waitingTimeForOneGranny / hourDuration;
            waitingMinutes = grannysCount * waitingTimeForOneGranny % hourDuration;

            Console.WriteLine("Для очереди в {0} бабуль, вам необходимо прождать {1} часов и {2} минут", grannysCount, waitingHours, waitingMinutes);
        }
    }
}
