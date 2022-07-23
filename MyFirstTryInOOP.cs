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
            char[,] map =
            {
                {'#', '#', '#', '#', '#', '#', '#', '#', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
                {'#', ' ', '#', ' ', ' ', ' ', '#', ' ', '#'},
                {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
                {'#', '#', '#', '#', '#', '#', '#', '#', '#'},
            };
            int playerStartPositionX = 1;
            int playerStartPositionY = 1;

            Console.CursorVisible = false;

            Renderer renderer = new Renderer();
            Player player = new Player(playerStartPositionX, playerStartPositionY);
            Enemy enemy1 = new Enemy();

            while (isProgramRunning)
            {
                Console.Clear();

                renderer.DrawMap(map);
                renderer.DrawCreature(player);
                player.Move(map);
            }
        }
    }

    class Renderer
    {
        public void DrawMap(char[,] map)
        {
            Console.SetCursorPosition(0, 0);

            for (int i = 0; i < map.GetLength(1); i++)
            {
                for (int j = 0; j < map.GetLength(0); j++)
                    Console.Write(map[j, i]);

                Console.WriteLine();
            }
        }

        public void DrawCreature(Creature creature)
        {
            Console.SetCursorPosition(creature.PositionX, creature.PositionY);

            Console.Write(creature.Symbol);
        }
    }

    abstract class Creature
    {
        public char Symbol { get; protected set; }
        public string Direction { get; protected set; }
        public int PositionX { get; protected set; }
        public int PositionY { get; protected set; }

        protected virtual void GetDirection()
        {

        }

        public virtual void Move(char[,] map)
        {
            switch (Direction.ToLower())
            {
                case "up":
                    if (map[PositionX, PositionY - 1] != '#')
                        PositionY--;
                    break;
                case "down":
                    if (map[PositionX, PositionY + 1] != '#')
                        PositionY++;
                    break;
                case "left":
                    if (map[PositionX - 1, PositionY] != '#')
                        PositionX--;
                    break;
                case "right":
                    if (map[PositionX + 1, PositionY] != '#')
                        PositionX++;
                    break;
            }
        }
    }

    class Player : Creature
    {
        public Player(int positionX, int positionY)
        {
            PositionX = positionX;
            PositionY = positionY;
            Symbol = '@';
        }

        protected override void GetDirection()
        {
            ConsoleKeyInfo userKeyInput = Console.ReadKey();

            switch (userKeyInput.Key)
            {
                case ConsoleKey.UpArrow:
                    Direction = "up";
                    break;
                case ConsoleKey.DownArrow:
                    Direction = "down";
                    break;
                case ConsoleKey.LeftArrow:
                    Direction = "left";
                    break;
                case ConsoleKey.RightArrow:
                    Direction = "right";
                    break;
            }
        }

        public override void Move(char[,] map)
        {
            GetDirection();
            base.Move(map);
        }
    }

    class Enemy : Creature
    {

    }
}
