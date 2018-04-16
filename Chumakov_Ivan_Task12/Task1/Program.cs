using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
	class Program
	{
		static void Main(string[] args)
		{
			string path = @"C:\temp\disposable_task_file.txt";
			if (File.Exists(path))
			{
				string[] file = File.ReadAllLines(path);
				int[] temp = new int[file.Length];
				for (int i = 0; i < file.Length; i++)
				{
					temp[i] = Convert.ToInt32(file[i]);
					temp[i] *= temp[i];
					file[i] = temp[i].ToString();
				}
				File.WriteAllLines(path, file);
			}
			Console.ReadKey();
		}
	}
}
