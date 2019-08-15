namespace Algorithms_and_data_structure
{
    public class FactorialRecursion
    {
        public long Factorial(int number)
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
    }
}
