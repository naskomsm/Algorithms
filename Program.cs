namespace Algorithms_and_data_structure
{
    public class Program
    {
        public static void Main()
        {
            Labyrinth labyrinth = new Labyrinth(3, 3);
            // you need to give the labyrinth - example --->
            // ---
            // -*-
            // --e
            labyrinth.Solve(0, 0, 'S');
        }
    }
}       
