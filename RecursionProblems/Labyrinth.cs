namespace Algorithms_and_data_structure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Labyrinth
    {
        private char[,] labyrinth;
        private List<char> path;

        public Labyrinth(int rows, int cols)
        {
            this.path = new List<char>();
            InitializeLabyrinth(rows, cols);
        }

        private void InitializeLabyrinth(int rows, int cols)
        {
            this.labyrinth = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string symbols = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    this.labyrinth[row, col] = symbols[col];
                }
            }
        }

        public void Solve(int row, int col, char direction)
        {
            if (OutSideOfLabyrinth(row, col))
            {
                return;
            }

            path.Add(direction);

            if (IsExit(row, col))
            {
                PrintSolution();
            }

            else if (IsPassable(row, col))
            {
                //mark path
                this.labyrinth[row, col] = 'x';

                Solve(row + 1, col, 'D'); // down
                Solve(row - 1, col, 'U'); // up
                Solve(row, col + 1, 'R'); // right
                Solve(row, col - 1, 'L'); // left

                //unmark path
                this.labyrinth[row, col] = '-';
            }

            path.RemoveAt(path.Count - 1);
        }

        private void PrintSolution()
        {
            Console.WriteLine(string.Join(string.Empty,path.Skip(1)));
        }

        private bool IsPassable(int row, int col)
        {
            //already visited
            if (this.labyrinth[row, col] == 'x')
            {
                return false;
            }

            //wall
            if (this.labyrinth[row, col] == '*')
            {
                return false;
            }

            return true;
        }

        private bool IsExit(int row, int col)
        {
            return this.labyrinth[row, col] == 'e';
        }

        private bool OutSideOfLabyrinth(int row, int col)
        {
            if (row < 0 || row >= this.labyrinth.GetLength(0))
            {
                return true;
            }

            if (col < 0 || col >= this.labyrinth.GetLength(1))
            {
                return true;
            }

            return false;
        }
    }
}
