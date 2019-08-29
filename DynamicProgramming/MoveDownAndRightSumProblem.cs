namespace Algorithms_and_data_structure.DynamicProgramming
{
    using System;
    using System.Collections.Generic;

    public class MoveDownAndRightSumProblem
    {
        private int[,] matrix;
        private int[,] solutionMatrix;

        public MoveDownAndRightSumProblem(int rows, int cols, int[,] givenMatrix)
        {
            this.matrix = new int[rows, cols];
            this.solutionMatrix = new int[rows, cols];

            this.matrix = givenMatrix;
        }

        public void Solve()
        {
            SolveRowAndCol(0, 0);

            for (int row = 1; row < this.solutionMatrix.GetLength(0); row++)
            {
                for (int col = 1; col < this.solutionMatrix.GetLength(1); col++)
                {
                    FindBestSolution(row, col);
                }
            }

            FindPath(0, 0);
        }

        private void FindPath(int row, int col)
        {
            var result = new List<int>() { this.solutionMatrix[row, col] };

            while (row < this.solutionMatrix.GetLength(0) && col < this.solutionMatrix.GetLength(1))
            {
                if (row + 1 >= this.solutionMatrix.GetLength(0))
                {
                    result.Add(this.matrix[row, col + 1]);
                    row++;
                }

                else if (col + 1 >= this.solutionMatrix.GetLength(1))
                {
                    result.Add(this.matrix[row + 1, col]);
                    col++;
                }

                else if (this.solutionMatrix[row + 1, col] > this.solutionMatrix[row, col + 1])
                {
                    result.Add(this.matrix[row + 1, col]);
                    row++;
                }

                else
                {
                    result.Add(this.matrix[row, col + 1]);
                    col++;
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }

        private void FindBestSolution(int row, int col)
        {
            if (this.solutionMatrix[row - 1, col] > this.solutionMatrix[row, col - 1])
            {
                this.solutionMatrix[row, col] = this.solutionMatrix[row - 1, col] + this.matrix[row, col];
            }

            else
            {
                this.solutionMatrix[row, col] = this.solutionMatrix[row, col - 1] + this.matrix[row, col];
            }
        }

        private void SolveRowAndCol(int initialRow, int initialCol)
        {
            var defaultSolution = this.matrix[initialRow, initialCol];
            this.solutionMatrix[0, 0] = defaultSolution;

            for (int row = 1; row < this.matrix.GetLength(0); row++)
            {
                this.solutionMatrix[row, 0] = this.solutionMatrix[row - 1, 0] + this.matrix[row, 0];
            }

            for (int col = 1; col < this.matrix.GetLength(1); col++)
            {
                this.solutionMatrix[0, col] = this.solutionMatrix[0, col - 1] + this.matrix[0, col];
            }
        }
    }
}
