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
                        AddDossier(ref names, ref professions);
                        break;
                    case "2":
                        PrintAllDossiers(names, professions);
                        break;
                    case "3":
                        DeleteDossier(ref names, ref professions);
                        break;
                    case "4":
                        FindDossierByLastName(ref names, ref professions);
                        break;
                    case "5":
                        isProgramRunning = false;
                        break;
                    default:
                        Console.WriteLine("\nТакой команды нет. Попробуйте ещё раз");
                        break;
                }

                Console.WriteLine("\nНажмите любую кнопку чтобы продолжить... \n");
                Console.ReadKey();

                if (userInput != "2" && userInput != "5")
                    Console.Clear();
            }
        }

        static string[] ChangeStringArraySize(string[] array, int quanityOfChanges)
        {
            string[] tempArray = new string[array.Length + quanityOfChanges];

            if (quanityOfChanges > 0)
            {
                for (int i = 0; i < array.Length; i++)
                    tempArray[i] = array[i];
            }
            else if (quanityOfChanges < 0)
            {
                for (int i = 0; i < tempArray.Length; i++)
                    tempArray[i] = array[i];
            }

            return array = tempArray;
        }

        static string[] IncreaseArray(string[] array, string lineToAdd = "")
        {
            string[] tempArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
                tempArray[i] = array[i];

            tempArray[tempArray.Length - 1] = lineToAdd;
            return tempArray;
        }

        static string[] DecreaseArray(string[] array)
        {
            string[] tempArray = new string[array.Length - 1];

            for (int i = 0; i < tempArray.Length; i++)
                tempArray[i] = array[i];

            return tempArray;
        }

        static void AddDossier(ref string[] names, ref string[] professions)
        {
            Console.Write("\nВведите ФИО. Поле для ввода: ");
            string dossierName = Console.ReadLine();
            Console.Write("\nВведите должность. Поле для ввода: ");
            string dossierProfession = Console.ReadLine();

            names = IncreaseArray(names, dossierName);
            professions = IncreaseArray(professions, dossierProfession);

            Console.WriteLine("\nДосье добавлено. ");
        }

        static void PrintAllDossiers(string[] names, string[] professions)
        {
            if (names.Length > 0)
            {
                for (int i = 0; i < names.Length; i++)
                    PrintSpecificDossier(names, professions, i);

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("\nВ списке нет ни одного досье.");
            }
        }

        static void DeleteDossier(ref string[] names, ref string[] professions)
        {
            if (names.Length > 0)
            {
                bool isDataOkay = false;
                int dossierNumber;

                do
                {
                    Console.Write("\nВведите номер досье, которое хотите удалить. Поле для ввода: ");
                    dossierNumber = Convert.ToInt32(Console.ReadLine());

                    if (dossierNumber > 0 && dossierNumber <= names.Length)
                    {
                        for (int i = dossierNumber - 1; i < names.Length; i++)
                        {
                            if (i < names.Length - 1)
                            {
                                names[i] = names[i + 1];
                                professions[i] = professions[i + 1];
                            }
                        }

                        names = DecreaseArray(names);
                        professions = DecreaseArray(professions);
                        isDataOkay = true;
                    }
                    else
                    {
                        Console.WriteLine("Были указаны неверные данные. Укажите число от 1 до {0}", names.Length);
                        isDataOkay = false;
                    }
                } while (isDataOkay == false);

                Console.WriteLine("\nДосье удалено. ");
            }
            else
            {
                Console.WriteLine("Для удаления список должен содержать как минимум одно досье");
            }
        }

        static void PrintSpecificDossier(string[] names, string[] professions, int index)
        {
            string[] fullName;

            fullName = names[index].Split(' ');
            Console.Write("\n" + (index + 1) + ") ");

            for (int i = 0; i < fullName.Length; i++)
                Console.Write(fullName[i] + '-');

            Console.Write(professions[index]);
        }

        static void FindDossierByLastName(string[] names, string[] professions)
        {
            bool isDossierFinded = false;
            string[] fullName;
            string lastName;

            Console.Write("\nВведите фамилию. Поле для ввода: ");
            lastName = Console.ReadLine();

            for (int i = 0; i < names.Length; i++)
            {
                fullName = names[i].Split(' ');
                if (lastName == fullName[0])
                {
                    PrintSpecificDossier(names, professions, i);

                    isDossierFinded = true;
                }
            }

            Console.WriteLine();

            if (!isDossierFinded)
                Console.Write("Досье не найдено. \n");
        }
    }
}
