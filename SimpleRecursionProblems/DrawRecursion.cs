namespace Algorithms_and_data_structure
{
    using System;

    public class DrawRecursion
    {
        public void Print(int number)
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
    }
}
