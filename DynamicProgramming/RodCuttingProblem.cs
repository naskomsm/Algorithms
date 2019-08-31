namespace Algorithms_and_data_structure.DynamicProgramming
{
    using System;

    public class RodCuttingProblem
    {
        private int[] price;
        private int[] bestPrice;

        public RodCuttingProblem(int[] price)
        {
            this.price = price;
            this.bestPrice = new int[price.Length];
        }

        public int CutRod(int n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (bestPrice[n - 1] > 0)
            {
                return bestPrice[n - 1];
            }

            var currentBest = bestPrice[n - 1];

            for (int i = 0; i < n; i++)
            {
                currentBest = Math.Max(currentBest, price[i] + CutRod(n - 1 - i));

                if (currentBest > bestPrice[n - 1])
                {
                    bestPrice[n - 1] = currentBest;
                }
            }

            return bestPrice[n - 1];
        }
    }
}
