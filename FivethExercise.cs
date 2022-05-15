using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            string dish = "Пина колада";
            string drink = "Пюре с котлетой";
            string boofer;

            Console.WriteLine("Вот ваше блюдо: {0}, а также ваш напиток: {1}.", dish, drink); // Неверный вывод

            boofer = dish;
            dish = drink;
            drink = boofer;

            Console.WriteLine("Ой, то есть я хотела сказать ваше блюдо: {0}, а также ваш напиток: {1}.", dish, drink); // Верный вывод
        }
    }
}
