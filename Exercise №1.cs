using System;
using System.Collections.Generic;
using System.Linq;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> words = new Dictionary<string, string>();
            bool isProgramRunning = true;
            string userInput;

            words.Add("рэйджквит", "Выход из игры из за сильной агрессии.");
            words.Add("ваншот", "Убийство одним выстрелом/ударом. Также 'ваншотным' могут называть противника с малым количеством здоровья.");
            words.Add("стан", "Ситуация или способность, которая ограничивает подвижность персонажа или полностью его останавливает.");
            words.Add("тильт", "Состояние игрока, когда он в порыве разочарования в проигрыше начинает играть хуже вновь проигрывая и ещё больше расстраиваясь.");
            words.Add("пик", "Словом 'пик' могут называть список героев, которых взяла команда. Но также есть слово 'пикнуть', которое означает быстро вылезти из укрытия и зайти обратно.");

            while (isProgramRunning)
            {
                Console.Clear();
                Console.WriteLine("Словарь геймера 2022.");
                Console.Write("\nВведите слово чтобы узнать его значение (Exit для выхода). Поле для ввода: ");
                userInput = Console.ReadLine();

                if (words.ContainsKey(userInput))
                {
                    Console.WriteLine($"\nСлово {userInput} имеет следующее толкование: {words[userInput]}");
                }
                else if (userInput.ToLower() == "exit")
                {
                    isProgramRunning = false;
                }
                else
                {
                    Console.WriteLine("\nСлово не найдено в словаре. ");
                }

                Console.WriteLine("\nНажмите любую кнопку чтобы продолжить... ");
                Console.ReadKey();
            }
        }
    }
}
