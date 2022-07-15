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
            "#     ######## #   #",
            "# ###        # # # #",
            "### # #####    # # #",
            "#   #     # #    # #",
            "# #### ###### #### #",
            "#           #    # #",
            "# #### #### # #### #",
            "#      #           #",
            "###### # # ##### ###",
            "#    # # #         #",
            "#    #   #     #   #",
            "# ##### ###### ### #",
            "#        #         #",
            "####################", 
            };
            char[,] map = new char[stringMap.Length, stringMap[0].Length];
            
            ConvertStringMapIntoChar(ref map, stringMap);

            char playerSymbol = '@';
            int playerXPosition = 4;
            int playerYPosition = 11;
            char enemySymbol = 'H';

            Console.CursorVisible = false;

            while (isGameRunning)
            {
                DrawMap(map);
                DrawPlayer(playerXPosition, playerYPosition, playerSymbol);
                MovePlayer(ref playerXPosition, ref playerYPosition, map);
            }
        }

        static void DrawMap(char[,] map)
        {
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                    Console.Write(map[i, j]);

                Console.WriteLine();
            }
        }

        static void ConvertStringMapIntoChar(ref char[,] charMap, string[] stringMap)
        {
            for (int i = 0; i < stringMap.Length; i++)
            {
                for (int j = 0; j < stringMap[i].Length; j++)
                    charMap[i, j] = stringMap[i][j];
            }
        }

        static void DrawPlayer(int playerXPosition, int playerYPosition, char playerSymbol)
        {
            Console.SetCursorPosition(playerXPosition, playerYPosition);
            Console.Write(playerSymbol);
        }

        static void MovePlayer(ref int playerXPosition, ref int playerYPosition, char[,] map)
        {
            ConsoleKeyInfo userKeyInput = Console.ReadKey();

            switch (userKeyInput.Key)
            {
                case ConsoleKey.UpArrow:
                    if (map[playerXPosition, playerYPosition - 1] != '#')
                        playerYPosition--;
                    break;
                case ConsoleKey.DownArrow:
                    if (map[playerXPosition, playerYPosition + 1] != '#')
                        playerYPosition++;
                    break;
                case ConsoleKey.LeftArrow:
                    if (map[playerXPosition - 1, playerYPosition] != '#')
                        playerXPosition--;
                    break;
                case ConsoleKey.RightArrow:
                    if (map[playerXPosition + 1, playerYPosition] != '#')
                        playerXPosition++;
                    break;
            }
        }
    }
}
