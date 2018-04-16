using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	public delegate string[] SortArray(string[] str);
	class Program
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
				"aqwert"
			};
			SortArray sortArray = Sort;

			string[] sortArr = sortArray(arr);
			foreach (var item in sortArr)
			{
				Console.WriteLine(item);
			}
			Console.ReadKey();
		}
		public static string[] Sort(string[] str)
		{
			Array.Sort(str, new RegulationsSort());
			
			return str;
		}
	}
}
