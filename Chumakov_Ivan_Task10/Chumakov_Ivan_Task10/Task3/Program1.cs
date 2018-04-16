using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Task1;

namespace Task3
{
	class Program1
	{
		public static AutoResetEvent waitHandler = new AutoResetEvent(true);

		static void Main(string[] args)
		{

			string[] array = new string[]
			{
				"qwe","asd","zxcv","zs","as","xcvb"
			};
			MyClass myClass = new MyClass();
			Thread a = new Thread(new ParameterizedThreadStart(myClass.Method));
			

			a.Start(array);
			waitHandler.WaitOne();


			Console.ReadKey();
		}

	}
	class MyClass
	{

		public void Method(object x)
		{		
			string[] arr = (string[])x;
			Program.Sort1(arr, Program.CompareLengthAscending);
			foreach (var item in arr)
			{
				Console.WriteLine(item);
			}
			Program1.waitHandler.Set();		
		}
	}
}
