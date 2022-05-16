using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Console.Write("Вы приходите в больницу и перед вами очередь к врачу. Сколько старушек вы видите? ");
            
            int grannysCount = Convert.ToInt32(Console.ReadLine());
            int hourDuration = 60;
            int waitingTimeForOneGranny = 10;
            int overallWaitingTime = grannysCount * waitingTimeForOneGranny;
            int waitingHours;
            int waitingMinutes;

            waitingHours = overallWaitingTime / hourDuration;
            waitingMinutes = overallWaitingTime % hourDuration;

            Console.WriteLine("Для очереди в {0} бабуль, вам необходимо прождать {1} часов и {2} минут", grannysCount, waitingHours, waitingMinutes);
        }
    }
}
