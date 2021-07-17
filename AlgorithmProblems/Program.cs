using System;
using System.IO;


 namespace AlgorithmProblems
 {
    class Program
    {
        static void Main(string[] args)

        {
            string filepath = @"C:\Users\user\source\repos\AlgorithmProblems\AlgorithmProblems\textArray.txt";
            string text = File.ReadAllText(filepath);
            string[] textArray = text.Split(" ");
            Console.WriteLine("welcome to Algorithm problems");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Permutation combination of Word");
            Console.WriteLine("2) BinarySearchTree");
            Console.WriteLine("3) Insertion Sort");
            Console.WriteLine("4) Bubble Sort");
            Console.WriteLine("5) Merge Sort");
            Console.WriteLine("6) Anagram");
            Console.WriteLine("7) Primenum");
            Console.WriteLine("8) Prime and palindrome");
            Console.WriteLine("9) Exit");
            Console.WriteLine("\r\nSelect  an option:");
            switch(Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("enter string to find Permutation\n");
                    string str = Console.ReadLine();
                    int n = str.Length;
                    PermutationOfWord.Permute(str, 0, n - 1);
                    break;

                case "2":
                    BinarySearch<string> binarySearch = new BinarySearch<string>(textArray);
                    Console.WriteLine("Enter the word to search:");
                    string word = Console.ReadLine();
                    int found = binarySearch.FindWord(word, 0, textArray.Length);
                    if (found == 1)
                    {
                        Console.WriteLine("{0} is found", word);
                    }
                    else
                    {
                        Console.WriteLine("{0} is not found", word);
                    }
                    break;

                    break;
                case "3":
                    InsertionSort<string> insertionSort = new InsertionSort<string>();
                    insertionSort.Sort(textArray);
                    insertionSort.Display(textArray);
                    break;

                case "4":
                    int[] intarray = { 9, 5, 2, 4, 1, 6  };
                    Bubble<int> bubble = new Bubble<int>();
                    intarray = bubble.Sort(intarray);
                    bubble.Display(intarray);
                    break;

                case "5":
                    int start = 0;
                    int end = textArray.Length;
                    MergeSort<string> mergeSort = new MergeSort<string>();
                    mergeSort.mergeSort(textArray, start, end - 1);
                    mergeSort.Display(textArray);
                    break;

                case "6":
                    Anagram anagram = new Anagram();
                    Console.WriteLine("Enter two strings :");
                    string str1 = Console.ReadLine();
                    string str2 = Console.ReadLine();

                    int result = anagram.CheckAnagram(str1.ToUpper(), str2.ToUpper());
                    if (result == 1)
                    {
                        Console.WriteLine("Two strings are in anagram");
                    }
                    else
                    {
                        Console.WriteLine("The strings are not anagram");
                    }
                    break;

                case "7":
                    PrimeNum primeNum = new PrimeNum();
                    primeNum.PrintPrime();
                    break;

                case "8":
                    PrimeNum primeNum1 = new PrimeNum();
                    primeNum1.PrintPrime();
                    primeNum1.PrintPalindrome();
                    primeNum1.CheckAnagram();
                    break;

                case "9":
                    break;

                default:
                    Console.WriteLine("enter the right option");
                    break;
                   
                     
            }
        }
    }
 }
