namespace Algorithms_and_data_structure.ShufflingAlgorithm
{
    using System;

    public class Fisher_YatesShuffle
    {
        //The generation of random numbers is too important to be left to chance. — Robert R.Coveyou
        public void Shuffle<T>(T[] source)
        {
            Random rnd = new Random();

            for (int i = 0; i < source.Length; i++)
            {
                // So basicly we are exchanging the currentElement position with other random element from the arrray..
                int r = i + rnd.Next(0, source.Length - i);
                T temp = source[i];
                source[i] = source[r];
                source[r] = temp;
            }
        }
    }
}
