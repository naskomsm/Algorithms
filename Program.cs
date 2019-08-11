namespace Algorithms_and_data_structure
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            // Sum numbers with recursion
            var array = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var sum = Sum(array, 0);
            static int Sum(int[] array, int index)
            {
                if (index == array.Length)
                {
                    return 0;
                }

                return array[index] + Sum(array, index + 1);
            }

            // Factorial with recursion
            var factorial = Factorial(5);
            static long Factorial(int number)
            {
                if (number == 0)
                {
                    return 1;
                }

                //before recursion
                var result = number * Factorial(number - 1);
                //after recursion

                return result;
            }

            // Draw on console with recursioon
            //Print(5);
            static void Print(int number)
            {
                if (number == 0)
                {
                    return;
                }

                for (int i = 0; i < number; i++) // another solution -> Console.WriteLine(new string('*', number));
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                Print(number - 1);

                for (int i = 0; i < number; i++) // another solution -> Console.WriteLine(new string('#', number));
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            // Generating 0/1 Vectors
            //GenerateVector(new int[3], 0);
            static void GenerateVector(int[] vector, int index)
            {
                if (index == vector.Length)
                {
                    Console.WriteLine(string.Join(" ", vector));
                }
                else
                {
                    for (int i = 0; i <= 1; i++)
                    {
                        vector[index] = i;
                        GenerateVector(vector, index + 1);
                    }
                }
            }

            // Generating combinations
            //GenerateCombinations(new int[] { 1, 2, 3, 4, 5 }, new int[3], 0, -1);
            static void GenerateCombinations(int[] set, int[] vector, int index, int border)
            {
                if (index == vector.Length)
                {
                    Console.WriteLine(string.Join(" ", vector));
                }
                else
                {
                    for (int i = border + 1; i < set.Length; i++)
                    {
                        vector[index] = set[i];
                        GenerateCombinations(set, vector, index + 1, i);
                    }
                }
            }


            var matrix = new int[3][];
            matrix[0] = new int[3] { 2, 0, 3 };
            matrix[1] = new int[3] { 1, 0, 0 };
            matrix[2] = new int[3] { 0, 0, 1 };

            Backtracking(matrix, 0);
            static void Backtracking(int[][] sudoku, int initialRow)
            {
                var isSolution = false;
                foreach (var row in sudoku)
                {
                    if (row.All(x => x != default(int)))
                    {
                        isSolution = true;
                    }
                    else
                    {
                        isSolution = false;
                    }
                }

                if (isSolution)
                {
                    foreach (var row in sudoku)
                    {
                        Console.WriteLine(string.Join(" ", row));
                    }
                }

                else
                {
                    for (int i = 1; i <= 9; i++)
                    {
                        var currentRowNumbers = sudoku[initialRow];

                        if (currentRowNumbers.Any(number => number != default(int)) && currentRowNumbers.All(number => number != i))
                        {
                            for (int column = 0; column < currentRowNumbers.Length; column++)
                            {
                                var cell = currentRowNumbers[column];

                                if (cell == default(int))
                                {
                                    //checking the row above
                                    if (initialRow > 0)
                                    {
                                        for (int h = initialRow - 1; h >= 0; h--)
                                        {
                                            var previousRowNumbers = sudoku[h];
                                            if (previousRowNumbers[column] != i && currentRowNumbers.All(number => number != i))
                                            {
                                                currentRowNumbers[column] = i;
                                                Backtracking(sudoku, initialRow - 1);
                                                currentRowNumbers[column] = default(int);
                                            }
                                        }
                                    }

                                    //checking the row below
                                    if (initialRow < sudoku.Length)
                                    {
                                        for (int h = initialRow + 1; h < sudoku.Length; h++)
                                        {
                                            var nextRowNumbers = sudoku[h];
                                            if (nextRowNumbers[column] != i && currentRowNumbers.All(number => number != i))
                                            {
                                                currentRowNumbers[column] = i;
                                                Backtracking(sudoku, initialRow + 1);
                                                currentRowNumbers[column] = default(int);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
