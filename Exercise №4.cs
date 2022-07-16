using System;

namespace idk_why__it_s_just_existing
{
    class Program
    {
        static void Main()
        {
            bool isGameRunning = true;
            string[] stringMap = {
            "####################",
            "#$    ###$###### $ #",
            "# ###        ### # #",
            "###$# #####    # # #",
            "#   #   $ #$#   $# #",
            "# #### ###### #### #",
            "#          $#    # #",
            "# #### #### # #### #",
            "#      #       $   #",
            "###### # # ##### ###",
            "#$   # # #        $#",
            "#    #  $#     #   #",
            "# ##### ###### ### #",
            "#       $#$        #",
            "####################",
            };
            char[,] map = new char[stringMap.Length, stringMap[0].Length];
            char playerSymbol = '@';
            int playerXPosition = 6;
            int playerYPosition = 16;
            int playerHP = 10;
            int playerMoney = 0;
            char moneySymbol = '$';
            int maxMoneyOnMap = 0;
            bool isPlayerDamaged = false;

            ConvertStringMapIntoChar(ref map, stringMap, ref maxMoneyOnMap, moneySymbol);

            Console.CursorVisible = false;

            while (isGameRunning)
            {
                DrawMap(map);
                DrawPlayer(playerXPosition, playerYPosition, playerSymbol);
                DrawBar(22, playerHP, ConsoleColor.DarkRed, playerSymbol);
                DrawBar(23, playerMoney, ConsoleColor.DarkYellow, moneySymbol, maxMoneyOnMap);

                Console.SetCursorPosition(0, 25);
                Console.WriteLine("Блок сверху: '" + map[playerXPosition - 1, playerYPosition] + "'");
                Console.WriteLine("Блок снизу : '" + map[playerXPosition + 1, playerYPosition] + "'");
                Console.WriteLine("Блок слева : '" + map[playerXPosition, playerYPosition - 1] + "'");
                Console.WriteLine("Блок справа: '" + map[playerXPosition, playerYPosition + 1] + "'");

                MovePlayer(ref playerXPosition, ref playerYPosition, map, ref isPlayerDamaged);
                CheckPlayerCollision(ref isGameRunning, ref isPlayerDamaged, map, playerXPosition, playerYPosition, ref playerHP, ref playerMoney, maxMoneyOnMap, moneySymbol);
            }
        }

        static void DrawMap(char[,] map)
        {
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < map.GetLength(1); i++)
            {
                for (int j = 0; j < map.GetLength(0); j++)
                    Console.Write(map[j, i]);

                Console.WriteLine();
            }
        }

        static void ConvertStringMapIntoChar(ref char[,] charMap, string[] stringMap, ref int maxMoneyOnMap, char moneySymbol)
        {
            for (int i = 0; i < stringMap.Length; i++)
            {
                for (int j = 0; j < stringMap[i].Length; j++)
                {
                    charMap[i, j] = stringMap[i][j];
                    if (charMap[i, j] == moneySymbol)
                        maxMoneyOnMap++;
                }
            }
        }

        static void DrawPlayer(int playerXPosition, int playerYPosition, char playerSymbol)
        {
            Console.SetCursorPosition(playerXPosition, playerYPosition);
            Console.Write(playerSymbol);
        }

        static void DrawBar(int position, int levelOfOccupancy, ConsoleColor barColor = ConsoleColor.White, char symbol = '#', int barSize = 10)
        {
            string bar = "";

            for (int i = 0; i < barSize; i++)
            {
                if (i < levelOfOccupancy)
                    bar += symbol;
                else
                    bar += '_';
            }

            Console.SetCursorPosition(0, position);
            Console.ForegroundColor = barColor;
            Console.Write("[{0}]", bar);
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(0, 0);
        }

        static void MovePlayer(ref int playerXPosition, ref int playerYPosition, char[,] map, ref bool isPlayerDamaged)
        {
            ConsoleKeyInfo userKeyInput = Console.ReadKey();

            switch (userKeyInput.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[playerXPosition, playerYPosition - 1] != '#')
                        playerYPosition--;
                    else
                        isPlayerDamaged = true;
                    break;
                case ConsoleKey.DownArrow:
                    if (map[playerXPosition, playerYPosition + 1] != '#')
                        playerYPosition++;
                    else
                        isPlayerDamaged = true;
                    break;
                case ConsoleKey.LeftArrow:
                    if (map[playerXPosition - 1, playerYPosition] != '#')
                        playerXPosition--;
                    else
                        isPlayerDamaged = true;
                    break;
                case ConsoleKey.RightArrow:
                    if (map[playerXPosition + 1, playerYPosition] != '#')
                        playerXPosition++;
                    else
                        isPlayerDamaged = true;
                    break;
            }
        }

        static void CheckPlayerCollision(ref bool isGameRunning, ref bool isPlayerDamaged, char[,] map, int playerXPosition, int playerYPosition, ref int playerHP, ref int playerMoney, int maxMoneyOnMap, char moneySymbol)
        {
            if (map[playerXPosition, playerYPosition] == moneySymbol)
            {
                playerMoney++;
                map[playerXPosition, playerYPosition] = ' ';

                if (playerMoney >= maxMoneyOnMap)
                {
                    Console.Clear();
                    Console.WriteLine("Игра окончена. Вы победили!");
                    isGameRunning = false;
                }
            }

            if (isPlayerDamaged)
            {
                playerHP--;
                isPlayerDamaged = false;

                if (playerHP <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("Игра окончена. Вы умерли.");
                    isGameRunning = false;
                }
            }
        }
    }
}

