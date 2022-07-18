using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            object[] intArray = { 3, 5, 23, 12, 5 };
            object[] floatArray = { 3.2f, 5.31f, 23.1f, 12.7f, 6.66f };
            object[] stringArray = { "Лёха", "Гера", "Паша", "Саня", "Лаурентий" };
            object[] charArray = { 'E', 'M', 'I', 'N', 'E', 'M' };

            Console.WriteLine("Массивы до перемешивания: \n");

            PrintArray(intArray);
            PrintArray(floatArray);
            PrintArray(stringArray);
            PrintArray(charArray);

            Console.WriteLine("\nПроисходит перемешивание...\n");

            Shuffle(ref intArray);
            Shuffle(ref floatArray);
            Shuffle(ref stringArray);
            Shuffle(ref charArray);

            Console.WriteLine("Массивы после перемешивания: \n");

            PrintArray(intArray);
            PrintArray(floatArray);
            PrintArray(stringArray);
            PrintArray(charArray);
        }

        static void DecreaseArray(ref object[] array)
        {
            object[] tempArray = new object[array.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
                tempArray[i] = array[i];
        }

        static void ShiftArray(ref object[] array, int startPosition = 0)
        {
            object firstElement = array[startPosition];

            for (int i = startPosition; i < array.Length; i++)
            {
                if (i != array.Length - 1)
                    array[i] = array[i + 1];
            }

            array[array.Length - 1] = firstElement;
        }

        static void Shuffle(ref object[] array)
        {
            Random random = new Random();
            object[] tempArray = new object[array.Length];
            int elementIndex;

            for (int i = 0; i < tempArray.Length; i++)
            {
                elementIndex = random.Next(0, array.Length - 1);
                tempArray[i] = array[elementIndex];
                ShiftArray(ref array, elementIndex);
                DecreaseArray(ref array);
            }

            array = tempArray;
        }

        static void PrintArray(object[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine();
        }
    }
}
