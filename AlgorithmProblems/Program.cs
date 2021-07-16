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
            Console.WriteLine("8) Exit");
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
                    Console.WriteLine("enter size of array:");
                    int size = Convert.ToInt32(Console.ReadLine());
                    string[] array = new string[size];
                    Console.WriteLine("enter elements of array:");
                    for (int i =0; i<size; i++)
                    {
                        array[i] = Console.ReadLine();
                    }
                    Console.WriteLine("enter elements  to find ");
                    string searchElement = Console.ReadLine();
                    int index = BinarySearch.BinarySearchWord(array, searchElement);
                    if(index == 1)
                    {
                        Console.WriteLine("Element is not present");
                    }
                    else
                    {
                        Console.WriteLine("Element is  present ");
                    }
                   
                    break;
                case "3":
                    InsertionSort insertionSort = new InsertionSort();
                    insertionSort.Sort(textArray);
                    insertionSort.Display(textArray);
                    break;

                case "4":
                    int[] intarray = { 9, 5, 2, 4, 1, 6  };
                    Bubble bubble = new Bubble();
                    intarray = bubble.Sort(intarray);
                    bubble.Display(intarray);
                    break;

                case "5":
                    int start = 0;
                    int end = textArray.Length;
                    MergeSort mergeSort = new MergeSort();
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
                    break;

                default:
                    Console.WriteLine("enter the right option");
                    break;
                   
                     
            }
        }
    }
 }
