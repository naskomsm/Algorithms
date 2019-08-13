namespace Algorithms_and_data_structure
{
    using System;
    using System.Collections.Generic;

    public class EightQueenProblem
    {
        private int size = 8;

        private HashSet<int> attackedRows;
        private HashSet<int> attackedCols;
        private HashSet<int> attackedRightDiagonals;
        private HashSet<int> attackedLeftDiagonals;

        private int[,] board;

        public EightQueenProblem()
        {
            this.attackedRows = new HashSet<int>();
            this.attackedCols = new HashSet<int>();
            this.attackedRightDiagonals = new HashSet<int>();
            this.attackedLeftDiagonals = new HashSet<int>();

            this.board = new int[size, size];
        }

        public void Solve(int row)
        {
            if (row == size)
            {
                PrintSolution();
            }

            else
            {
                for (int col = 0; col <= 7; col++)
                {
                    if (CanPlaceQueen(row, col))
                    {
                        MarkAttackedPositions(row, col);
                        Solve(row + 1);
                        UnMarkAttackedPositions(row, col);
                    }
                }
            }
        }

        private void PrintSolution()
        {
            int rowLength = this.board.GetLength(0);
            int colLength = this.board.GetLength(1);

            for (int row = 0; row < rowLength; row++)
            {
                for (int col = 0; col < colLength; col++)
                {
                    if (this.board[row, col] == 1)
                    {
                        Console.Write("* ");
                    }

                    else
                    {
                        Console.Write("- ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private bool CanPlaceQueen(int row, int col)
        {
            if (attackedRows.Contains(row))
            {
                return false;
            }

            if (attackedCols.Contains(col))
            {
                return false;
            }

            if(attackedLeftDiagonals.Contains(col - row))
            {
                return false;
            }

            if (attackedRightDiagonals.Contains(row + col))
            {
                return false;
            }

            return true;
        }

        private void MarkAttackedPositions(int row, int col)
        {
            this.board[row, col] = 1;
            attackedRows.Add(row);
            attackedCols.Add(col);
            attackedLeftDiagonals.Add(col - row);
            attackedRightDiagonals.Add(row + col);
        }

        private void UnMarkAttackedPositions(int row, int col)
        {
            board[row, col] = 0;
            attackedRows.Remove(row);
            attackedCols.Remove(col);
            attackedLeftDiagonals.Remove(col - row);
            attackedRightDiagonals.Remove(row + col);
        }
    }
}
