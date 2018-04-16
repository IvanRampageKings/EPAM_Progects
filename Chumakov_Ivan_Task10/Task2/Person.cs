using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Person
	{
		public string Name { get; set; }
		public void Greet(Person person, DateTime dateTime)
		{
			if (dateTime.Hour >= 6 && dateTime.Hour < 12)
			{
				Console.WriteLine("Good morning " + person.Name + " say " + Name);
			}
			else if (dateTime.Hour >= 12 && dateTime.Hour < 17)
			{
				Console.WriteLine("Good afternoon " + person.Name + " say " + Name);
			}
			else if (dateTime.Hour >= 17 && dateTime.Hour < 24)
			{
				Console.WriteLine("Good evening " + person.Name + " say " + Name);
			}
			else
			{
				Console.WriteLine("Good night " + person.Name + " say " + Name);
			}
		}
		public void TellGoodbye(Person person)
		{
			Console.WriteLine("Goodbye " + person.Name + " say " + Name);
		}
	}
}
