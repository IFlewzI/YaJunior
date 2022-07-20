using System;
using System.Collections.Generic;
using System.Linq;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            bool isProgramRunning = true;
            Dictionary<string, string> dossiers = new Dictionary<string, string>();
            string userInput;

            while (isProgramRunning)
            {
                Console.Write("Введите номер нужной команды: " +
                    "\n1)Добавить досье" +
                    "\n2)Вывести все досье" +
                    "\n3)Удалить досье" +
                    "\n4)Выход" +
                    "\n\nПоле для ввода: ");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddDossier(ref dossiers);
                        break;
                    case "2":
                        PrintAllDossiers(dossiers);
                        break;
                    case "3":
                        DeleteDossier(ref dossiers);
                        break;
                    case "4":
                        isProgramRunning = false;
                        break;
                }

                Console.WriteLine("\nНажмите любую клавишу чтобы продолжить...\n");
                Console.ReadKey();

                if (userInput != "2")
                    Console.Clear();
            }
        }

        static void AddDossier(ref Dictionary<string, string> dossiers)
        {
            string fullName;
            string profession;

            Console.Write("\nВведите ФИО. Поле для ввода: ");
            fullName = Console.ReadLine();

            Console.Write("\nВведите должность. Поле для ввода: ");
            profession = Console.ReadLine();

            if (dossiers.ContainsKey(fullName))
                Console.WriteLine("\nУказанное ФИО уже есть в списке досье.");
            else
                dossiers.Add(fullName, profession);
        }

        static void PrintAllDossiers(Dictionary<string, string> dossiers)
        {
            if (dossiers.Count > 0)
            {
                foreach (var dossier in dossiers)
                {
                    string[] fullName = dossier.Key.Split();

                    Console.WriteLine();

                    for (int i = 0; i < fullName.Length; i++)
                        Console.Write(fullName[i] + '-');

                    Console.Write(dossier.Value);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\nВ списке нет ни одного досье");
            }
        }

        static void DeleteDossier(ref Dictionary<string, string> dossiers)
        {
            string fullName;

            Console.Write("\nВведите ФИО для последующего удаления. Поле для ввода: ");
            fullName = Console.ReadLine();

            if (dossiers.ContainsKey(fullName))
            {
                dossiers.Remove(fullName);
                Console.WriteLine("\nДосье успешно удалено");
            }
            else
                Console.WriteLine("\nДосье с таким ФИО не найдено.");
        }
    }
}
