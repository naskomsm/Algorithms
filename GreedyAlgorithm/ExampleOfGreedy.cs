namespace Algorithms_and_data_structure.GreedyAlgorithm
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ExampleOfGreedy
    {
        private const int coinsEachPlayerGet = 3;
        private string playerInTurn = "p1";

        private Dictionary<string, int> players;

        public ExampleOfGreedy()
        {
            this.players = new Dictionary<string, int>();
            this.players.Add("p1", 0);
            this.players.Add("p2", 0);
        }

        public void Play(int coins)
        {
            int initialCoins = coins;

            while (coins > 0)
            {
                if(coins - coinsEachPlayerGet >= 0)
                {
                    coins -= coinsEachPlayerGet;
                    this.players[playerInTurn] += coinsEachPlayerGet;

                    if (this.playerInTurn == "p1") this.playerInTurn = "p2";
                    else this.playerInTurn = "p1";
                }

                else
                {
                    this.players[playerInTurn] += coins;
                    coins = 0;
                }
            }

            Console.WriteLine($"Initial coins -> {initialCoins}");
            foreach (var kvp in this.players)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
