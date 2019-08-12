namespace Algorithms_and_data_structure
{
    public class Program
    {
        public static void Main()
        {
            // Sum numbers recursivly
            var sumNumbers = new RecursionSumNumbers();
            var sum = sumNumbers.Sum(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 0);

            // Factorial with recursion
            var factorial = new FactorialRecursion();
            var result = factorial.Factorial(5);


            // Draw on console with recursioon
            var drawObj = new DrawRecursion();
            //drawObj.Print(5);

            // Generating 0/1 Vectors
            var vectorGenerator = new VectorGenerator();
            //vectorGenerator.Generate(new int[3], 0);

            // Generating combinations
            var combinationsGenerator = new CombinationsGenerator();
            //combinationsGenerator.Generate(new int[] { 1, 2, 3, 4, 5 }, new int[3], 0, -1);


            // Sudoku 3x3 basic demo
            var sudoku = new Sudoku();

            // just making some example to see if it actually seek for the solution, can change the numbers however i like. It works only with numbers to 3...Becouse it is a simple demo :D
            int[][] threeByThreeSudoku = new int[3][];
            threeByThreeSudoku[0] = new int[3] { 0, 0, 1 };
            threeByThreeSudoku[1] = new int[3] { 0, 0, 0 };
            threeByThreeSudoku[2] = new int[3] { 0, 0, 0 };

            sudoku.Solve(threeByThreeSudoku, 0,0);
        }
    }
}
