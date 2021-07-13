using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
    public class BinarySearch
    {
        public static int BinarySearchWord(string[] arr,  string x)
        {
            int start = 0, end = arr.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                int res = x.CompareTo(arr[mid]);
                //check if x is present at mid
                if (res == 0)
                    return mid;
                // if x greater, ignore left half
                if (res > 0)
                    start = mid + 1;
                // if x is smaller , igore right half
                else
                    end = mid - 1;
            }
            return -1;
        }

       
    }
}

