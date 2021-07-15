using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmProblems
{
	class Bubble
	{
		public int[] Sort(int[]array) 
		{
			
			for (int i = 0; i < array.Length; i++)
			{

				for (int j = i+1; j <array.Length; j++)
				{

					if (array[i].CompareTo(array[j]) > 0)
					{
						// swap temp and arr[i]
						int temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					}
				}
			}
			return array;
			
		}

		/* Prints the array */
		public  void Display(int[] array)
		{
			
			for (int i = 0; i < array.Length; ++i)
				Console.Write(array[i]);
			
		}

	}
}

