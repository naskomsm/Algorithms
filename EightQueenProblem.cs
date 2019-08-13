namespace Algorithms_and_data_structure
{
    using System;
    using System.Collections.Generic;

    public class EightQueenProblem
    {
        private int queenMark = 1;
        private int queenFieldsMark = 2;
        private int defaultBoardValue = 0;

        int[,] board;

        public EightQueenProblem()
        {
            board = new int[,] {
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
                { 0, 0, 0, 0, 0, 0, 0, 0 },
            };
        }

        public void Solve(int row)
        {
            if (row == 8)
            {
                int rowLength = this.board.GetLength(0);
                int colLength = this.board.GetLength(1);

                for (int i = 0; i < rowLength; i++)
                {
                    for (int j = 0; j < colLength; j++)
                    {
                        Console.Write(string.Format("{0} ", this.board[i, j]));
                    }

                    Console.Write(Environment.NewLine + Environment.NewLine);
                }

                Console.ReadLine();
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

        private bool CanPlaceQueen(int row, int col)
        {
            if (this.board[row, col] == 0)
            {
                this.board[row, col] = queenMark;
                return true;
            }

            return false;
        }

        private void MarkAttackedPositions(int givenRow, int givenCol)
        {
            int givenRowCopy = givenRow;
            int givenColCopy = givenCol;

            for (int col = givenCol + 1; col < this.board.GetLength(1); col++) // right
            {
                this.board[givenRow, col] = queenFieldsMark;
            }

            for (int row = givenRow + 1; row < this.board.GetLength(0); row++) // down
            {
                this.board[row, givenCol] = queenFieldsMark;
            }

            for (int col = givenCol - 1; col >= 0; col--) // left
            {
                this.board[givenRow, col] = queenFieldsMark;
            }

            for (int row = givenRow - 1 ; row >= 0; row--) // up
            {
                this.board[row, givenCol] = queenFieldsMark;
            }

            while (givenRowCopy < 7 && givenColCopy < 7) // bootom right diagonal
            {
                givenRowCopy++;
                givenColCopy++;

                this.board[givenRowCopy, givenColCopy] = queenFieldsMark;
            }

            givenRowCopy = givenRow;
            givenColCopy = givenCol;

            while (givenRowCopy < 7 && givenColCopy > 0) // bootom left diagonal
            {
                givenRowCopy++;
                givenColCopy--;

                this.board[givenRowCopy, givenColCopy] = queenFieldsMark;
            }

            givenRowCopy = givenRow;
            givenColCopy = givenCol;

            while (givenRowCopy > 0 && givenColCopy > 0) // top left diagonal
            {
                givenRowCopy--;
                givenColCopy--;

                this.board[givenRowCopy, givenColCopy] = queenFieldsMark;
            }

            givenRowCopy = givenRow;
            givenColCopy = givenCol;

            while (givenRowCopy > 0 && givenColCopy < 7) // top right diagonal
            {
                givenRowCopy--;
                givenColCopy++;

                this.board[givenRowCopy, givenColCopy] = queenFieldsMark;
            }
        }

        private void UnMarkAttackedPositions(int givenRow, int givenCol)
        {
           //
        }
    }
}
