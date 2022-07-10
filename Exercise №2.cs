using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            int barSize;
            int percentageOfOccupancy = 0;

            Console.Write("Укажите величину шкалы. Поле для ввода: ");
            barSize = Convert.ToInt32(Console.ReadLine());

            while (true)
            {
                DrawBar(percentageOfOccupancy, barSize);

                Console.Write("Укажите процент заполненности шкалы. Поле для ввода: ");
                percentageOfOccupancy = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            }
        }

        static void DrawBar(int percentageOfOccupancy, int barSize)
        {
            string bar = "";

            for (int i = 0; i < barSize; i++)
            {
                if (i < percentageOfOccupancy / 10)
                    bar += '#';
                else
                    bar += '_';
            }

            Console.SetCursorPosition(0, 4);
            Console.Write("[{0}]", bar);
            Console.SetCursorPosition(0, 0);
        }
    }
}
