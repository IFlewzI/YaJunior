using System;
using System.Collections.Generic;
using System.Linq;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            string[] array1 = { "1", "2", "1" };
            string[] array2 = { "3", "2" };
            List<object> result = new List<object>();

            UniteArrays(result, array1, array2);

            PrintArray(array1);
            PrintArray(array2);
            PrintArray(result);
        }

        static void PrintArray(object[] array)
        {
            foreach (var element in array)
                Console.Write(element + " ");
            Console.WriteLine();
        }

        static void PrintArray(List<object> list)
        {
            foreach (var element in list)
                Console.Write(element + " ");
            Console.WriteLine();
        }

        static void UniteArrays(List<object> result, object[] array1, object[] array2)
        {
            foreach (var element in array1)
            {
                if (result.Contains(element) == false)
                    result.Add(element);
            }

            foreach (var element in array2)
            {
                if (result.Contains(element) == false)
                    result.Add(element);
            }
        }
    }
}
