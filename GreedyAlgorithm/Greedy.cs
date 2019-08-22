namespace Algorithms_and_data_structure.GreedyAlgorithm
{
    using System;
    using System.Collections.Generic;

    public class Greedy
    {
        private Stack<double> coins;
        private Stack<double> sortedCoins;
        private double sumToAchieve;
        private Dictionary<double, int> coinsCounter;

        public Greedy(double[] coins, double sumToAchieve)
        {
            this.coins = new Stack<double>();
            this.coinsCounter = new Dictionary<double, int>();
            this.sumToAchieve = sumToAchieve;

            FulfillStack(coins);
            this.sortedCoins = SortStack(this.coins);
        }

        private void FulfillStack(double[] coins)
        {
            foreach (var coin in coins)
            {
                this.coins.Push(coin);
            }
        }

        private Stack<double> SortStack(Stack<double> input)
        {
            Stack<double> tmpStack = new Stack<double>();

            while (input.Count > 0)
            {
                double tmp = input.Pop();

                while (tmpStack.Count > 0 && tmpStack.Peek() > tmp)
                {
                    input.Push(tmpStack.Pop());
                }

                tmpStack.Push(tmp);
            }
            return tmpStack;
        }

        public void Calculate()
        {
            double currentSum = 0;

            while (currentSum < sumToAchieve)
            {
                if (currentSum + this.sortedCoins.Peek() <= sumToAchieve)
                {
                    currentSum += this.sortedCoins.Peek();
                    currentSum = Math.Round(currentSum, 2);

                    if (!this.coinsCounter.ContainsKey(this.sortedCoins.Peek()))
                    {
                        this.coinsCounter.Add(this.sortedCoins.Peek(), 0);
                    }

                    this.coinsCounter[this.sortedCoins.Peek()]++;
                }

                else
                {
                    this.sortedCoins.Pop();
                }
            }

            Console.WriteLine("Coins used: ");

            foreach (var coin in this.coinsCounter)
            {
                Console.WriteLine($"{coin.Key}, times used: {coin.Value}");
            }

            Console.WriteLine($"Sum: {sumToAchieve}");
        }
    }
}
