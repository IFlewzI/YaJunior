using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            bool isProgramRunning = true;
            string[] names = new string[0];
            string[] professions = new string[0];
            string userInput;
            string userName;
            string userProfession;

            while (isProgramRunning)
            {
                Console.Write("Введите номер нужной команды: \n" +
                    "\n1) Добавить новое досье. " +
                    "\n2) Вывести все досье. " +
                    "\n3) Удалить досье. " +
                    "\n4) Поиск досье по фамилии." +
                    "\n5) Выход." +
                    "\nПоле для ввода: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.Write("\nВведите ФИО. Поле для ввода: ");
                        userName = Console.ReadLine();
                        Console.Write("\nВведите должность. Поле для ввода: ");
                        userProfession = Console.ReadLine();

                        AddDossier(ref names, ref professions, userName, userProfession);

                        Console.WriteLine("\nДосье добавлено. Нажмите любую кнопку чтобы продолжить... ");
                        Console.ReadKey();
                        break;
                    case "2":
                        PrintAllDossiers(names, professions, '-');

                        Console.WriteLine("\n\nНажмите любую кнопку чтобы продолжить... \n");
                        Console.ReadKey();
                        break;
                    case "3":
                        DeleteDossier(ref names, ref professions);

                        Console.WriteLine("\nДосье удалено. Нажмите любую кнопку чтобы продолжить...");
                        Console.ReadKey();
                        break;
                    case "4":
                        findDossierByLastName(ref names, ref professions);

                        Console.WriteLine("\nНажмите любую кнопку чтобы продолжить...");
                        Console.ReadKey();
                        break;
                    case "5":
                        isProgramRunning = false;
                        break;
                    default:
                        Console.WriteLine("\nТакой команды нет. Попробуйте ещё раз");
                        break;
                }

                if (userInput != "2" && userInput != "5")
                    Console.Clear();
            }
        }

        static void AddDossier(ref string[] names, ref string[] professions, string dossierName, string dossierProfession)
        {
            string[] tempNames = new string[names.Length + 1];
            string[] tempProfessions = new string[names.Length + 1];

            for (int i = 0; i < names.Length; i++)
                tempNames[i] = names[i];

            for (int i = 0; i < professions.Length; i++)
                tempProfessions[i] = professions[i];

            tempNames[tempNames.Length - 1] = dossierName;
            tempProfessions[tempProfessions.Length - 1] = dossierProfession;

            names = tempNames;
            professions = tempProfessions;
        }

        static void PrintAllDossiers(string[] names, string[] professions, char symbol)
        {
            if (names.Length > 0)
            {
                string[] fullName;

                for (int i = 0; i < names.Length; i++)
                {
                    fullName = names[i].Split(' ');
                    Console.Write("\n" + (i + 1) + ") ");

                    for (int j = 0; j < fullName.Length; j++)
                        Console.Write(fullName[j] + symbol);

                    Console.Write(professions[i]);
                }
            }
            else
            {
                Console.WriteLine("В списке нет ни одного досье.");
            }
        }

        static void DeleteDossier(ref string[] names, ref string[] professions)
        {
            string[] tempNames = new string[names.Length - 1];

            if (names.Length > 0)
            {
                Console.Write("\nВведите номер досье, которое хотите удалить. ");
                int dossierNumber = Convert.ToInt32(Console.ReadLine());

                if (dossierNumber > 0 && dossierNumber <= names.Length)
                {
                    for (int i = dossierNumber - 1; i < names.Length; i++)
                    {
                        if (i < names.Length - 1)
                            names[i] = names[i + 1];
                    }

                    for (int i = 0; i < names.Length; i++)
                    {
                        if (i < names.Length - 1)
                            tempNames[i] = names[i];
                    }

                    names = tempNames;
                }
                else
                {
                    Console.WriteLine("Были указаны неверные данные. Укажите число от 1 до {0}", names.Length);
                }
            }
            else
            {
                Console.WriteLine("Для удаления список должен содержать как минимум одно досье");
            }
        }

        static void findDossierByLastName(ref string[] names, ref string[] professions)
        {
            bool isDossierFinded = false;
            string[] fullName;
            string lastName;

            Console.Write("\nВведите фамилию. Поле для ввода: ");
            lastName = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                fullName = names[i].Split(' ');
                if (lastName == fullName[1])
                {
                    Console.Write("\n" + (i + 1) + ") ");

                    for (int j = 0; j < fullName.Length; j++)
                        Console.Write(fullName[j] + '-');

                    Console.Write(professions[i]);

                    isDossierFinded = true;
                    break;
                }
            }

            if (!isDossierFinded)
                Console.Write("Досье не найдено. ");
        }
    }
}
