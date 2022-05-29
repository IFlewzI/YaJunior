using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            bool isDataOkay = false;
            string userTextInput;
            int userNumberInput;
            int fromWhichCurrency;
            int toWhichCurrency;
            float howMuchMoneyToConvert;
            float currencyAvailibleToConvert = 0;
            float goldenCoins = 2;
            float silverCoins = 10;
            float copperCoins = 500;
            float referenceCoins = 0; // Валюта - эталон
            float goldenToReference = 100f;
            float silverToReference = 10f;
            float copperToReference = 1f;

            Console.WriteLine("\nВаш баланс: \nЗолотые монеты: {0} \nСеребрянные монеты: {1} \nМедные монеты: {2}", goldenCoins, silverCoins, copperCoins);

            while (true)
            {
                do
                {
                    Console.WriteLine("\nКакую валюту вы хотите конвертировать?");
                    Console.Write("1. Золотые монеты \n2. Серебрянные монеты \n3. Медные монеты \nВведите цифру нужной валюты: ");
                    userNumberInput = Convert.ToInt32(Console.ReadLine());

                    if ((userNumberInput >= 1) && (userNumberInput <= 3))
                    {
                        isDataOkay = true; 
                    }
                    else
                    {
                        isDataOkay = false;
                        Console.WriteLine("Были введены неверные данные. Попробуйте использовать цифры от 1 до 3");
                    }
                } while (isDataOkay == false);
                fromWhichCurrency = userNumberInput;

                do
                {
                    Console.WriteLine("\nКакую валюту вы хотите получить?");
                    Console.Write("1. Золотые монеты \n2. Серебрянные монеты \n3. Медные монеты \nВведите цифру нужной валюты: ");
                    userNumberInput = Convert.ToInt32(Console.ReadLine());

                    if ((userNumberInput >= 1) && (userNumberInput <= 3))
                    {
                        isDataOkay = true;
                    }
                    else
                    {
                        isDataOkay = false;
                        Console.WriteLine("Были введены неверные данные. Попробуйте использовать цифры от 1 до 3");
                    }
                } while (isDataOkay == false);

                toWhichCurrency = userNumberInput;

                switch (fromWhichCurrency)
                {
                    case 1:
                        switch (toWhichCurrency)
                        {
                            case 2:
                                currencyAvailibleToConvert = goldenCoins * goldenToReference / silverToReference;
                                break;
                            case 3:
                                currencyAvailibleToConvert = goldenCoins * goldenToReference / copperToReference;
                                break;
                        }
                        break;
                    case 2:
                        switch (toWhichCurrency)
                        {
                            case 1:
                                currencyAvailibleToConvert = silverCoins * silverToReference / goldenToReference;
                                break;
                            case 3:
                                currencyAvailibleToConvert = silverCoins * silverToReference / copperToReference;
                                break;
                        }
                        break;
                    case 3:
                        switch (toWhichCurrency)
                        {
                            case 1:
                                currencyAvailibleToConvert = copperCoins * copperToReference / goldenToReference;
                                break;
                            case 2:
                                currencyAvailibleToConvert = copperCoins * copperToReference / silverToReference;
                                break;
                        }
                        break;
                }

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
                /*
                referenceCoins = howMuchMoneyToConvert * referenceValues[toWhichCurrency - 1];
                allCurrencys[fromWhichCurrency - 1] -= referenceCoins / referenceValues[fromWhichCurrency - 1];
                allCurrencys[toWhichCurrency - 1] += howMuchMoneyToConvert;
                */
                switch (fromWhichCurrency)
                {
                    case 1:
                        referenceCoins = howMuchMoneyToConvert * goldenToReference;
                        switch (toWhichCurrency)
                        {
                            case 2:
                                goldenCoins -= howMuchMoneyToConvert / goldenToReference;
                                silverCoins += howMuchMoneyToConvert;
                                break;
                            case 3:
                                goldenCoins -= howMuchMoneyToConvert / goldenToReference;
                                copperCoins += howMuchMoneyToConvert;
                                break;
                        }
                        break;
                    case 2:
                        referenceCoins = howMuchMoneyToConvert * silverToReference;
                        switch (toWhichCurrency)
                        {
                            case 1:
                                silverCoins -= howMuchMoneyToConvert / silverToReference;
                                goldenCoins += howMuchMoneyToConvert;
                                break;
                            case 3:
                                silverCoins -= howMuchMoneyToConvert / silverToReference;
                                copperCoins += howMuchMoneyToConvert;
                                break;
                        }
                        break;
                    case 3:
                        referenceCoins = howMuchMoneyToConvert * copperToReference;
                        switch (toWhichCurrency)
                        {
                            case 1:
                                copperCoins -= howMuchMoneyToConvert / copperToReference;
                                goldenCoins += howMuchMoneyToConvert;
                                break;
                            case 2:
                                copperCoins -= howMuchMoneyToConvert / copperToReference;
                                silverCoins += howMuchMoneyToConvert;
                                break;
                        }
                        break;
                }
                Console.WriteLine(referenceCoins);

                Console.WriteLine("\nВаш баланс: \nЗолотые монеты: {0} \nСеребрянные монеты: {1} \nМедные монеты: {2}", goldenCoins, silverCoins, copperCoins);

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
