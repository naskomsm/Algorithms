namespace Algorithms_and_data_structure
{
    public class RecursionSumNumbers
    {
        public int Sum(int[] array, int index)
        {
            if (index == array.Length)
            {
                return 0;
            }

            return array[index] + Sum(array, index + 1);
        }
    }
}
