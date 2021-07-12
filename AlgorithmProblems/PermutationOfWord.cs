using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    class PermutationOfWord
    {
        public static void Permute(string str, int start , int end )
        {
            if (start == end)
                Console.WriteLine(str);
            else
            {
                for(int i = start; i<=end; i++)
                {
                    str = Swap(str, start, i);
                    Permute(str, start + 1, end);//Recusive method
                    str = Swap(str, start, i);
                }
            }
        }
        public static string Swap(string word, int start, int index)
        {
            char temp;
            char[] charArray = word.ToCharArray();
            temp = charArray[start];
            charArray[start] = charArray[index];
            charArray[index] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
