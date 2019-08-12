namespace Algorithms_and_data_structure
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Sudoku
    {
        List<int> bannedNumbers;

        public Sudoku()
        {
            this.bannedNumbers = new List<int>();
        }

        public void Solve(int[][] sudoku, int initialRow, int initialCol)
        {
            if (sudoku[0].All(x => x != default(int)) && sudoku[1].All(x => x != default(int)) && sudoku[2].All(x => x != default(int)))
            {
                foreach (var row in sudoku)
                {
                    Console.WriteLine(string.Join(" ", row));
                }
            }

            else
            {

                for (int i = 1; i <= 3; i++)
                {

                    var currentRowNumbers = sudoku[initialRow];
                    for (int column = initialCol; column < currentRowNumbers.Length; column++)
                    {
                        if (currentRowNumbers[column] != default(int) && !bannedNumbers.Contains(currentRowNumbers[column]))
                        {
                            continue;
                        }

                        var isOkToPutNumberInCell = true;

                        //directions checker
                        for (int left = column; left >= 0; left--)
                        {
                            if (currentRowNumbers[left] == i)
                            {
                                isOkToPutNumberInCell = false;
                                break;
                            }
                        }

                        for (int right = column; right <= currentRowNumbers.Length - 1; right++)
                        {
                            if (currentRowNumbers[right] == i)
                            {
                                isOkToPutNumberInCell = false;
                                break;
                            }
                        }

                        for (int up = initialRow; up >= 0; up--)
                        {
                            if (sudoku[up][column] == i)
                            {
                                isOkToPutNumberInCell = false;
                                break;
                            }
                        }

                        for (int down = initialRow; down <= sudoku.Length - 1; down++)
                        {
                            if (sudoku[down][column] == i)
                            {
                                isOkToPutNumberInCell = false;
                                break;
                            }
                        }

                        if (isOkToPutNumberInCell)
                        {
                            if (!this.bannedNumbers.Contains(i))
                            {
                                currentRowNumbers[column] = i;
                                bannedNumbers = new List<int>();
                            }

                            else
                            {
                                break;
                            }

                            if (currentRowNumbers.All(x => x != default(int)))
                            {
                                Solve(sudoku, initialRow + 1, initialCol);
                            }

                            else
                            {
                                Solve(sudoku, initialRow, initialCol);
                            }
                        }

                        else
                        {
                            if (i == 3)
                            {
                                bannedNumbers.Add(currentRowNumbers[column - 1]);
                                Solve(sudoku, initialRow, initialCol);
                            }

                            break;
                        }
                    }
                }
            }
        }

    }
}
