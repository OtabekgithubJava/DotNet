using System;

namespace Class_1
{
    public class Puzzle15
    {
        private string[] tiles;
        private string[][] board;
        private int emptyX;
        private int emptyY;

        public Puzzle15()
        {
            tiles = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", " " };
            board = new string[4][];
            emptyX = 3;
            emptyY = 3;
            GenerateBoard();
        }

        private void GenerateBoard()
        {
            Random random = new Random();
            tiles = tiles.OrderBy(x => random.Next()).ToArray(); 

            for (int i = 0; i < 4; i++)
            {
                board[i] = new string[4];
                for (int j = 0; j < 4; j++)
                {
                    board[i][j] = tiles[i * 4 + j];
                    if (board[i][j] == " ")
                    {
                        emptyX = i;
                        emptyY = j;
                    }
                }
            }
        }

        public void PrintBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(board[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void MoveTile(Direction direction)
        {
            int newX = emptyX;
            int newY = emptyY;

            if (direction == Direction.Up && emptyX > 0)
            {
                newX = emptyX - 1;
            }
            else if (direction == Direction.Down && emptyX < 3)
            {
                newX = emptyX + 1;
            }
            else if (direction == Direction.Left && emptyY > 0)
            {
                newY = emptyY - 1;
            }
            else if (direction == Direction.Right && emptyY < 3)
            {
                newY = emptyY + 1;
            }

            if (newX != emptyX || newY != emptyY)
            {
                Swap(emptyX, emptyY, newX, newY);
                emptyX = newX;
                emptyY = newY;
            }
        }

        private void Swap(int x1, int y1, int x2, int y2)
        {
            string temp = board[x1][y1];
            board[x1][y1] = board[x2][y2];
            board[x2][y2] = temp;
        }
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
}
