using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            bool isProgramRunning = true;
            bool isDataOkay = false;
            bool isNotepadExisting = false;
            string userTextInput;
            int userNumberInput;
            int consoleColor;
            int consoleTextColor;
            int randomNumber;
            // User Info
            string userName;
            float userAge;
            int minRandomNumber = 0;
            int maxRandomNumber = 0;
            string userNotepad = "default";

            Console.Write("Добрый день, дорогой пользователь! Добро пожаловать в SmartConsole2022. Для начала введите ваше имя. \nПоле для ввода: ");
            userName = Console.ReadLine();
            Console.Write("\nОчень приятно познакомиться, {0}! Теперь пожалуйста введите ваш возраст. \nПоле для ввода: ", userName);
            userAge = Convert.ToInt32(Console.ReadLine());

            if (userAge > 10)
            {
                while (isProgramRunning)
                {
                    Console.Write("\n{0}, введите номер нужной команды. Введите help, чтобы получить список команд. \nПоле для ввода: ", userName);
                    userTextInput = Console.ReadLine();

                    switch (userTextInput.ToLower())
                    {
                        case "help":
                            Console.WriteLine("\nСписок команд: " +
                                "\n1. Show My Info - выводит данные пользователя. " +
                                "\n2. Change My Info - позволяет изменить данные пользователя. " +
                                "\n3. Set Console Color - меняет цвет консоли, после выбора из выпадающего списка. " +
                                "\n4. Generate Random Number - создаёт и выводит на экран случайное число из заданного диапозона. " +
                                "\n5. Create Notepad - позволяет ввести данные, с возможностью их последующего вывода. " +
                                "\n6. Show Notepad - выводит ранее записанные данные на экран. " +
                                "\n7. Exit - завершает программу. ");
                            break;
                        case "1":
                            Console.WriteLine("\nДанные пользователя: \nИмя: {0} \nВозраст: {1}", userName, userAge);
                            break;
                        case "2":
                            Console.Write("\nВведите новое имя. Если хотите оставить старое, то введите skip. \nПоле для ввода: ");
                            userTextInput = Console.ReadLine();

                            if (userTextInput.ToLower() != "skip")
                                userName = userTextInput;

                            Console.Write("Теперь введите новый возраст. Если не хотите его менять, то введите skip. \nПоле для ввода: ");
                            userTextInput = Console.ReadLine();

                            if (userTextInput.ToLower() != "skip")
                                userAge = Convert.ToInt32(userTextInput);

                            Console.WriteLine("Отлично, данные успешно отредактированы.");
                            break;
                        case "3":
                            Console.Write("\nВведите номер нужного цвета консоли: " +
                                "\n1. Чёрный " +
                                "\n2. Белый " +
                                "\n3. Красный " +
                                "\n4. Оранжевый " +
                                "\n5. Жёлтый " +
                                "\n6. Зелёный " +
                                "\n7. Голубой " +
                                "\n8. Синий " +
                                "\n9. Фиолетовый " +
                                "\nПоле для ввода: ");
                            consoleColor = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nТеперь введите номер нужного цвета текста консоли: " +
                                "\n1. Чёрный " +
                                "\n2. Белый " +
                                "\n3. Красный " +
                                "\n4. Оранжевый " +
                                "\n5. Жёлтый " +
                                "\n6. Зелёный " +
                                "\n7. Голубой " +
                                "\n8. Синий " +
                                "\n9. Фиолетовый " +
                                "\nПоле для ввода: ");
                            consoleTextColor = Convert.ToInt32(Console.ReadLine());

                            switch (consoleColor)
                            {
                                case 1:
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    break;
                                case 2:
                                    Console.BackgroundColor = ConsoleColor.White;
                                    break;
                                case 3:
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    break;
                                case 4:
                                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                                    break;
                                case 5:
                                    Console.BackgroundColor = ConsoleColor.Yellow;
                                    break;
                                case 6:
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    break;
                                case 7:
                                    Console.BackgroundColor = ConsoleColor.Blue;
                                    break;
                                case 8:
                                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                                    break;
                                case 9:
                                    Console.BackgroundColor = ConsoleColor.Magenta;
                                    break;
                            }

                            switch (consoleTextColor)
                            {
                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    break;
                                case 2:
                                    Console.ForegroundColor = ConsoleColor.White;
                                    break;
                                case 3:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    break;
                                case 4:
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    break;
                                case 5:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    break;
                                case 6:
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    break;
                                case 7:
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    break;
                                case 8:
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    break;
                                case 9:
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    break;
                            }

                            Console.Clear();
                            Console.WriteLine("Консоль успешно обновлена!");
                            break;
                        case "4":
                            Console.Write("\nУкажите нижний предел случайного числа. \nПоле для ввода: ");
                            minRandomNumber = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Отлично, теперь укажите верхний предел \nПоле для ввода: ");
                            userNumberInput = Convert.ToInt32(Console.ReadLine());

                            do
                            {
                                if (userNumberInput <= minRandomNumber)
                                {
                                    isDataOkay = false;
                                    Console.WriteLine("Неверные данные. Верхний предел должен быть больше, чем нижний. Введите число больше {0}. \nПоле для ввода: ", minRandomNumber);
                                    userNumberInput = Convert.ToInt32(Console.ReadLine());
                                }
                                else
                                {
                                    isDataOkay = true;
                                    maxRandomNumber = userNumberInput;
                                }
                            } while (isDataOkay == false);

                            randomNumber = random.Next(minRandomNumber, maxRandomNumber + 1);
                            Console.WriteLine("\nПолучилось число {0}", randomNumber);
                            break;
                        case "5":
                            Console.Write("\nВведённый далее текст будет записан в <<Блокнот>>. \nПоле для ввода: ");
                            userNotepad = Console.ReadLine();
                            isNotepadExisting = true;
                            Console.WriteLine("\nТекст успешно записан.");
                            break;
                        case "6":
                            if (isNotepadExisting)
                                Console.WriteLine("\nВаш блокнот: \n{0}", userNotepad);
                            else
                                Console.WriteLine("\nБлокнота не существует. Воспользуйтесь сначала командой номер 5, чтобы создать его.");
                            break;
                        case "7":
                            Console.Write("\nВы уверены, что хотите выйти? \nНажмите Enter, чтобы продолжить. \nВведите 1, чтобы выйти. \nПоле для ввода: ");
                            userNumberInput = Convert.ToInt32(Console.ReadLine());

                            if (userNumberInput == 1)
                            {
                                Console.WriteLine("\nСпасибо за использование SmartConsole2022. Всего хорошего, {0}.", userName);
                                isProgramRunning = false;
                            }
                            break;
                        default:
                            Console.WriteLine("\nБыла введена неизвестная команда. Попробуйте ещё раз.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("\nИзвините, {0}, но вы ещё слишком юны, чтобы пользоваться программой. Всего хорошего!", userName);
            }
        }
    }
}
