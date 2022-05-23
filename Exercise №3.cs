using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            int step = 7;
            int maxNumber = 96;
            for (int i = 5; i <= maxNumber; i += step)
            {
                Console.Write(i + " ");
            }
            /* Цикл for был выбран потому, что легко выводить закономерные последовательности чисел, одна из которых и была представлена в задании.
             * Нужно было только выявить эту самую закономерность и подставить в цикл.
             */
        }
    }
}
