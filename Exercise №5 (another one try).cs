using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            float usd = 100;
            float rub = 500;
            float howMuchMoneyToConvert = 10;
            float rateRubleToDollar = 56;
            float rateDollarToRuble = 1 / rateRubleToDollar;

            Console.WriteLine("Ваш баланс: \nДоллары: {0} \nРубли: {1}", usd, rub);
            Console.WriteLine("\nПроисходит конвертация {0} долларов в рубли...", howMuchMoneyToConvert);

            if (usd - howMuchMoneyToConvert >= 0)
            {
                usd -= howMuchMoneyToConvert;
                rub += howMuchMoneyToConvert * rateRubleToDollar;
            }
            else
            {
                Console.WriteLine("Недостаточно средств для конвертации.");
            }

            Console.WriteLine("\nОбновлённый баланс: \nДоллары: {0} \nРубли: {1}", usd, rub);

            howMuchMoneyToConvert = 112;
            Console.WriteLine("\nА теперь происходит конвертация {0} рублей в доллары...", howMuchMoneyToConvert);

            if (rub - howMuchMoneyToConvert >= 0)
            {
                rub -= howMuchMoneyToConvert;
                usd += howMuchMoneyToConvert * rateDollarToRuble;
            }
            else
            {
                Console.WriteLine("Недостаточно средств для конвертации.");
            }

            Console.WriteLine("\nОбновлённый баланс: \nДоллары: {0} \nРубли: {1}", usd, rub);
        }
    }
}
