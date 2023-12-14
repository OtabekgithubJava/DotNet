using System;

namespace Class_1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Puzzle15 game = new Puzzle15();
            game.PrintBoard();  

            while (true)
            {
                var key = Console.ReadKey(true);

                Console.Clear();
                Console.WriteLine(key.Key);

                if (key.Key == ConsoleKey.DownArrow)
                {
                    game.MoveTile(Direction.Down);
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    game.MoveTile(Direction.Up);
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    game.MoveTile(Direction.Right);
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    game.MoveTile(Direction.Left);
                }
                else
                {
                    // Handle other keys if needed
                }

                game.PrintBoard();
            }
        }
    }
}
