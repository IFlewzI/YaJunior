using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            bool isProgramRunning = true;
            int barSize;
            int percentageOfOccupancy = 0;
            int maxPercents = 100;

            Console.Write("Укажите величину шкалы. Поле для ввода: ");
            barSize = Convert.ToInt32(Console.ReadLine());

            while (isProgramRunning)
            {
                DrawBar(percentageOfOccupancy, barSize, maxPercents);

                Console.Write("Укажите процент заполненности шкалы. Поле для ввода: ");
                percentageOfOccupancy = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
            }
        }

        static void DrawBar(int percentageOfOccupancy, int barSize, int maxPercents = 100)
        {
            string bar = "";
            float percentsToFillOneSegment = maxPercents / barSize;
            int quanityOfSegmentsToFill = Convert.ToInt32(percentageOfOccupancy / percentsToFillOneSegment);

            for (int i = 0; i < barSize; i++)
            {
                if (i < quanityOfSegmentsToFill)
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
