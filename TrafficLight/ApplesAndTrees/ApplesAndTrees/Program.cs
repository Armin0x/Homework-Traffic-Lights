using System;

namespace ApplesAndTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = 8, m = 5, branches = 12;
            int totalTrees, totalBoxes, boxes;
            string numTrees;
            int rest;
            Console.WriteLine("Please enter the number of trees:");

            numTrees = Console.ReadLine();
            int.TryParse(numTrees, out totalTrees);
            rest = (totalTrees * n * branches) % m;
            totalBoxes = (totalTrees * n * branches) / m;
            boxes = rest + totalBoxes;

            Console.WriteLine("The total number of branches you will need is:  " + boxes);
            Console.ReadLine();
        }
    }
}
