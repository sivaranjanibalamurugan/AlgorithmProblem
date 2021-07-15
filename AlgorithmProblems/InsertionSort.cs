using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
   class InsertionSort
   {
      public void Sort(string[] array)
      {
            string maxValue;
            for (int i = 1; i < array.Length; i++)
            {
                //make 1st element as maxValue
                maxValue  = array[i];
                int j = i - 1;
                //checking for the minimum and move to sorted and unsorted array
                while (j >= 0 && array[j].CompareTo(maxValue) > 0)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = maxValue;
            }
      }
        public void Display(string[] array)
        {
            for (int i =0; i< array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

     }
}
    

