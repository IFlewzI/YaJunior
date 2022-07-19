using System;
using System.Collections.Generic;
using System.Linq;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Queue<int> clientsOrders = new Queue<int>();
            clientsOrders.Enqueue(2300);
            clientsOrders.Enqueue(430);
            clientsOrders.Enqueue(1550);
            clientsOrders.Enqueue(540);

            bool isProgramRunning = true;
            bool isPlayerPassedQuickTimeEvent = false;
            int quickTimeEventLength = 3;
            int money = 0;
            int clientsServed = 0;

            while (isProgramRunning)
            {
                Console.Clear();
                Console.SetCursorPosition(10, 0);
                Console.WriteLine("Ultimate Shop Master Rising\n");
                Console.WriteLine("\nТекущий баланс: {0} рублей", money);
                Console.WriteLine("\nКлиент №" + (clientsServed + 1));
                Console.WriteLine("\nСумма покупки: " + clientsOrders.Peek());
                Console.WriteLine("\nПроисходит процесс обслуживания... ");

                CreateQuickTimeEvent(ref isPlayerPassedQuickTimeEvent, quickTimeEventLength);

                if (isPlayerPassedQuickTimeEvent)
                {
                    Console.WriteLine("\n\nКлиент обслужен! Вы получаете {0} рублей на счёт!", clientsOrders.Peek());
                    money += clientsOrders.Dequeue();
                }
                else
                {
                    Console.WriteLine("\n\nВы не смогли обслужить клиента. Он ушёл.");
                    clientsOrders.Dequeue();
                }

                CheckDayEnd(ref isProgramRunning, clientsOrders.Count, money);

                clientsServed++;
                Console.WriteLine("\nНажмите любую клавишу, чтобы продолжить играть!");
                Console.ReadKey();
            }
        }

        static void CreateQuickTimeEvent(ref bool isPlayerPassedQuickTimeEvent, int quickTimeEventLength)
        {
            Random random = new Random();
            char[] keysForQuickTimeEvent = { '<', '^', '>' };
            char[] keysThatPlayerNeedToClick = new char[quickTimeEventLength];
            char[] keysThatPlayerClicked = new char[quickTimeEventLength];

            for (int i = 0; i < keysThatPlayerNeedToClick.Length; i++)
                keysThatPlayerNeedToClick[i] = keysForQuickTimeEvent[random.Next(0, keysForQuickTimeEvent.Length)];

            Console.Write("\nЧтобы обслужить клиента вам нужно нажать стрелки в следующем порядке: ");

            for (int i = 0; i < keysThatPlayerNeedToClick.Length; i++)
                Console.Write(keysThatPlayerNeedToClick[i] + " ");

            for (int i = 0; i < keysThatPlayerNeedToClick.Length; i++)
            {
                ConsoleKeyInfo pressedKey = Console.ReadKey();

                switch (pressedKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        keysThatPlayerClicked[i] = '<';
                        break;
                    case ConsoleKey.UpArrow:
                        keysThatPlayerClicked[i] = '^';
                        break;
                    case ConsoleKey.RightArrow:
                        keysThatPlayerClicked[i] = '>';
                        break;
                }
            }

            for (int i = 0; i < keysThatPlayerClicked.Length; i++)
            {
                if (keysThatPlayerClicked[i] == keysThatPlayerNeedToClick[i])
                {
                    isPlayerPassedQuickTimeEvent = true;
                }
                else
                {
                    isPlayerPassedQuickTimeEvent = false;
                    break;
                }
            }
        }

        static void PrintMoney(int money)
        {

        }

        static void CheckDayEnd(ref bool isProgramRunning, int clientsLeft, int money)
        {
            if (clientsLeft <= 0)
            {
                Console.WriteLine("\nНа сегодня рабочий день окончен! За сегодня вы заработали: {0} рублей", money);
                isProgramRunning = false;
            }
        }
    }
}
