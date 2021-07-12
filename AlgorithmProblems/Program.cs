using System;

namespace AlgorithmProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to Algorithm problems");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Permutation combination of Word");
            Console.WriteLine("2) Exit");
            Console.WriteLine("\r\nSelect  an option:");
            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("enter string to find Permutation\n");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    PermutationOfWord.Permute(str, 0, n - 1);
                    break;
               
                default:
                    Console.WriteLine("enter the right option");
                    break;
                   

            }
        }
    }
}
