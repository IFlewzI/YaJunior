using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            bool isDataOkay = false;
            int userNumberInput;
            string userTextInput;
            int fromWhichCurrency;
            int toWhichCurrency;
            float howMuchMoneyToConvert;
            float referenceCoins;
            float currencyAvailibleToConvert;
            float goldenCoins = 2;
            float silverCoins = 10;
            float copperCoins = 500;
            float[] allCurrencys = new float[3] { goldenCoins, silverCoins, copperCoins };
            float[] referenceValues = new float[3] { 100, 10, 1 }; // Ценность каждой валюты относительно эталона

            Console.WriteLine("\nВаш баланс: \nЗолотые монеты: {0} \nСеребрянные монеты: {1} \nМедные монеты: {2}", allCurrencys[0], allCurrencys[1], allCurrencys[2]);

            while (true)
            {
                do
                {
                    Console.WriteLine("\nКакую валюту вы хотите конвертировать?");
                    Console.Write("1. Золотые монеты \n2. Серебрянные монеты \n3. Медные монеты \nВведите цифру нужной валюты: ");
                    userNumberInput = Convert.ToInt32(Console.ReadLine());

                    if ((userNumberInput >= 1) && (userNumberInput <= allCurrencys.Length))
                    {
                        isDataOkay = true; 
                    }
                    else
                    {
                        isDataOkay = false;
                        Console.WriteLine("Были введены неверные данные. Попробуйте использовать цифры от 1 до {0}", allCurrencys.Length);
                    }
                } while (isDataOkay == false);
                fromWhichCurrency = userNumberInput;

                do
                {
                    Console.WriteLine("\nКакую валюту вы хотите получить?");
                    Console.Write("1. Золотые монеты \n2. Серебрянные монеты \n3. Медные монеты \nВведите цифру нужной валюты: ");
                    userNumberInput = Convert.ToInt32(Console.ReadLine());

                    if ((userNumberInput >= 1) && (userNumberInput <= allCurrencys.Length))
                    {
                        isDataOkay = true;
                    }
                    else
                    {
                        isDataOkay = false;
                        Console.WriteLine("Были введены неверные данные. Попробуйте использовать цифры от 1 до {0}", allCurrencys.Length);
                    }
                } while (isDataOkay == false);

                toWhichCurrency = userNumberInput;
                currencyAvailibleToConvert = allCurrencys[fromWhichCurrency - 1] * referenceValues[fromWhichCurrency - 1] / referenceValues[toWhichCurrency - 1];

                Console.Write("\nВы можете получить до {0} нужной валюты. \nСколько из этого вы хотите получить? Поле для ввода: ", currencyAvailibleToConvert);
                
                do
                {
                    userNumberInput = Convert.ToInt32(Console.ReadLine());

                    if ((userNumberInput >= 0) && (userNumberInput <= currencyAvailibleToConvert))
                    {
                        isDataOkay = true;
                    }
                    else
                    {
                        isDataOkay = false;
                        Console.WriteLine("Ошибка. Укажите число, соответствующее диапозону от 0 до {0} \nПоле для ввода: ", currencyAvailibleToConvert);
                    }
                } while (isDataOkay == false);

                howMuchMoneyToConvert = userNumberInput;
                referenceCoins = howMuchMoneyToConvert * referenceValues[toWhichCurrency - 1];
                allCurrencys[fromWhichCurrency - 1] -= referenceCoins / referenceValues[fromWhichCurrency - 1];
                allCurrencys[toWhichCurrency - 1] += howMuchMoneyToConvert;

                Console.WriteLine("\nВаш баланс: \nЗолотые монеты: {0} \nСеребрянные монеты: {1} \nМедные монеты: {2}", allCurrencys[0], allCurrencys[1], allCurrencys[2]);

                Console.Write("\nПродолжить обмен? \nДля выхода из программы введите - exit. \nДля продолжения нажмите Enter \nПоле для ввода: ");
                userTextInput = Console.ReadLine();

                if (userTextInput.ToLower() == "exit") 
                {
                    break;
                }
            }
        }
    }
}
