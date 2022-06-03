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
            int fromWhichCurrency = 0;
            int toWhichCurrency = 0;
            int currencysNumber = 3;
            float eur = 50f;
            float usd = 100f;
            float rub = 500f;
            float howMuchMoneyToConvert;
            float moneyAvailibleToConvert;
            float rateDollarToRuble = 50f;
            float rateEuroToRuble = 75f;
            float rateDollarToEuro = rateDollarToRuble / rateEuroToRuble;
            float rateRubleToEuro = 1 / rateEuroToRuble;
            float rateEuroToDollar = 1 / rateDollarToEuro;
            float rateRubleToDollar = 1 / rateDollarToRuble;

            Console.WriteLine("Ваш баланс: \nЕвро: {0} \nДоллары: {1} \nРубли: {2}", eur, usd, rub);

            do
            {
                do
                {
                    Console.Write("\nКакую валюту вы хотите конвертировать? \n\nВведите номер нужной валюты: \n1. Евро \n2. Доллары \n3. Рубли \nПоле для ввода: ");
                    userNumberInput = Convert.ToInt32(Console.ReadLine());

                    if (userNumberInput >= 1 && userNumberInput <= currencysNumber)
                    {
                        isDataOkay = true;
                        fromWhichCurrency = userNumberInput;
                    }
                    else
                    {
                        isDataOkay = false;
                        Console.WriteLine("Были введены неверные данные, попробуйте числа от 1 до {0}", currencysNumber);
                    }
                } while (isDataOkay == false);

                do
                {
                    Console.Write("\nКакую валюту вы хотите получить из конвертированной? \n\nВведите номер нужной валюты: \n1. Евро \n2. Доллары \n3. Рубли \nПоле для ввода: ");
                    userNumberInput = Convert.ToInt32(Console.ReadLine());

                    if (userNumberInput >= 1 && userNumberInput <= currencysNumber)
                    {
                        isDataOkay = true;
                        toWhichCurrency = userNumberInput;
                    }
                    else
                    {
                        isDataOkay = false;
                        Console.WriteLine("Были введены неверные данные, попробуйте числа от 1 до {0}", currencysNumber);
                    }
                } while (isDataOkay == false);

                Console.Write("\nСколько денег вы хотите конвертировать? \nПоле для ввода: ");
                howMuchMoneyToConvert = Convert.ToInt32(Console.ReadLine());

                switch (fromWhichCurrency)
                {
                    case 1:
                        switch (toWhichCurrency)
                        {
                            case 1:
                                Console.WriteLine("Вы не можете конвертировать валюту саму в себя");
                                break;
                            case 2:
                                moneyAvailibleToConvert = eur;

                                if (howMuchMoneyToConvert < 0 || eur - howMuchMoneyToConvert < 0)
                                {
                                    do
                                    {
                                        Console.Write("Было введено невозможное число валюты для конвертации. Введите число от 0 до {0}. \nПоле для ввода: ", moneyAvailibleToConvert);
                                        userNumberInput = Convert.ToInt32(Console.ReadLine());

                                        if (userNumberInput >= 0 && eur - userNumberInput >= 0)
                                        {
                                            isDataOkay = true;
                                            howMuchMoneyToConvert = userNumberInput;
                                        }
                                        else
                                        {
                                            isDataOkay = false;
                                        }
                                    } while (isDataOkay == false);
                                }

                                eur -= howMuchMoneyToConvert;
                                usd += howMuchMoneyToConvert * rateEuroToDollar;
                                Console.WriteLine("\nКонвертация была произведена успешно!\n");
                                break;
                            case 3:
                                moneyAvailibleToConvert = eur;

                                if (howMuchMoneyToConvert < 0 || eur - howMuchMoneyToConvert < 0)
                                {
                                    do
                                    {
                                        Console.Write("Было введено невозможное число валюты для конвертации. Введите число от 0 до {0}. \nПоле для ввода: ", moneyAvailibleToConvert);
                                        userNumberInput = Convert.ToInt32(Console.ReadLine());

                                        if (userNumberInput >= 0 && eur - userNumberInput >= 0)
                                        {
                                            isDataOkay = true;
                                            howMuchMoneyToConvert = userNumberInput;
                                        }
                                        else
                                        {
                                            isDataOkay = false;
                                        }
                                    } while (isDataOkay == false);
                                }

                                eur -= howMuchMoneyToConvert;
                                rub += howMuchMoneyToConvert * rateEuroToRuble;
                                Console.WriteLine("\nКонвертация была произведена успешно!\n");
                                break;
                        }
                        break;
                    case 2:
                        switch (toWhichCurrency)
                        {
                            case 1:
                                moneyAvailibleToConvert = usd;

                                if (howMuchMoneyToConvert < 0 || usd - howMuchMoneyToConvert < 0)
                                {
                                    do
                                    {
                                        Console.Write("Было введено невозможное число валюты для конвертации. Введите число от 0 до {0}. \nПоле для ввода: ", moneyAvailibleToConvert);
                                        userNumberInput = Convert.ToInt32(Console.ReadLine());

                                        if (userNumberInput >= 0 && usd - userNumberInput >= 0)
                                        {
                                            isDataOkay = true;
                                            howMuchMoneyToConvert = userNumberInput;
                                        }
                                        else
                                        {
                                            isDataOkay = false;
                                        }
                                    } while (isDataOkay == false);
                                }

                                usd -= howMuchMoneyToConvert;
                                eur += howMuchMoneyToConvert * rateDollarToEuro;
                                Console.WriteLine("\nКонвертация была произведена успешно!\n");
                                break;
                            case 2:
                                Console.WriteLine("Вы не можете конвертировать валюту саму в себя");
                                break;
                            case 3:
                                moneyAvailibleToConvert = usd;

                                if (howMuchMoneyToConvert < 0 || usd - howMuchMoneyToConvert < 0)
                                {
                                    do
                                    {
                                        Console.Write("Было введено невозможное число валюты для конвертации. Введите число от 0 до {0}. \nПоле для ввода: ", moneyAvailibleToConvert);
                                        userNumberInput = Convert.ToInt32(Console.ReadLine());

                                        if (userNumberInput >= 0 && usd - userNumberInput >= 0)
                                        {
                                            isDataOkay = true;
                                            howMuchMoneyToConvert = userNumberInput;
                                        }
                                        else
                                        {
                                            isDataOkay = false;
                                        }
                                    } while (isDataOkay == false);
                                }

                                usd -= howMuchMoneyToConvert;
                                rub += howMuchMoneyToConvert * rateDollarToRuble;
                                Console.WriteLine("\nКонвертация была произведена успешно!\n");
                                break;
                        }
                        break;
                    case 3:
                        switch (toWhichCurrency)
                        {
                            case 1:
                                moneyAvailibleToConvert = rub;

                                if (howMuchMoneyToConvert < 0 || rub - howMuchMoneyToConvert < 0)
                                {
                                    do
                                    {
                                        Console.Write("Было введено невозможное число валюты для конвертации. Введите число от 0 до {0}. \nПоле для ввода: ", moneyAvailibleToConvert);
                                        userNumberInput = Convert.ToInt32(Console.ReadLine());

                                        if (userNumberInput >= 0 && rub - userNumberInput >= 0)
                                        {
                                            isDataOkay = true;
                                            howMuchMoneyToConvert = userNumberInput;
                                        }
                                        else
                                        {
                                            isDataOkay = false;
                                        }
                                    } while (isDataOkay == false);
                                }

                                rub -= howMuchMoneyToConvert;
                                eur += howMuchMoneyToConvert * rateRubleToEuro;
                                Console.WriteLine("\nКонвертация была произведена успешно!\n");
                                break;
                            case 2:
                                moneyAvailibleToConvert = rub;

                                if (howMuchMoneyToConvert < 0 || rub - howMuchMoneyToConvert < 0)
                                {
                                    do
                                    {
                                        Console.Write("Было введено невозможное число валюты для конвертации. Введите число от 0 до {0}. \nПоле для ввода: ", moneyAvailibleToConvert);
                                        userNumberInput = Convert.ToInt32(Console.ReadLine());

                                        if (userNumberInput >= 0 && rub - userNumberInput >= 0)
                                        {
                                            isDataOkay = true;
                                            howMuchMoneyToConvert = userNumberInput;
                                        }
                                        else
                                        {
                                            isDataOkay = false;
                                        }
                                    } while (isDataOkay == false);
                                }

                                rub -= howMuchMoneyToConvert;
                                usd += howMuchMoneyToConvert * rateRubleToDollar;
                                Console.WriteLine("\nКонвертация была произведена успешно!\n");
                                break;
                            case 3:
                                Console.WriteLine("Вы не можете конвертировать валюту саму в себя");
                                break;
                        }
                        break;
                }

                Console.WriteLine("\nОбновлённый баланс: \nЕвро: {0} \nДоллары: {1} \nРубли: {2}", eur, usd, rub);

                Console.Write("\nХотите ли вы продолжить использование программы? \nНажмите Enter, чтобы продолжить. \nВведите exit, чтобы выйти. \nПоле для ввода: ");
                userTextInput = Console.ReadLine();
            } while (userTextInput.ToLower() != "exit");
        }
    }
}
