using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	//public delegate string[] SortArray(string[] str);
	public class Program
	{
		static void Main(string[] args)
		{
			string[] arr = new string[]
			{
				"qwe",
				"asdf",
				"zxcvb",
				"nm",
				"as",
				"awe",
				"aqwert",
				"ghj"
			};
			//	SortArray sortArray = Sort;
			Sort1(arr, CompareLengthAscending);
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
			Sort1(arr, CompareLengthDesc);
			//	string[] sortArr = Sort(arr);
			//foreach (var item in sortArr)
			//{
			//	Console.WriteLine(item);
			//}
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}

		
		public static void Sort1(string[] array, Func<string, string, int> lengthComparison)
		{
			var lengthComparisonResult = lengthComparison;

			for (int i = 0; i < array.Length; i++)
			{
				for (int j = i + 1; j < array.Length; j++)
				{
					if (lengthComparison(array[i], array[j]) == 1)
					{
						string temp = array[i];
						array[i] = array[j];
						array[j] = temp;
					
					}
					//else if(lengthComparison(array[i], array[j]) == 0)
					//{					
					//	if (array[i].CompareTo(array[j]) == 1)
					//	{
					//		string temp = array[i];
					//		array[i] = array[j];
					//		array[j] = temp;
					//	}
					//}
				}
			}
		}

		public static int CompareLengthAscending(string a, string b)
		{
			if (a.Length > b.Length)
			{
				return 1;
			}
			else if (a.Length < b.Length)
			{
				return -1;
			}
			else return a.CompareTo(b);
		}

		public static int CompareLengthDesc(string a, string b)
		{
			if (a.Length < b.Length)
			{
				return 1;
			}
			else if (a.Length > b.Length)
			{
				return -1;
			}
			else return a.CompareTo(b);


			//return -a.Length.CompareTo(b.Length);
		}

		public static string[] Sort(string[] str)
		{
			//	Array.Sort(str, );

			return str;
		}
	}
}
