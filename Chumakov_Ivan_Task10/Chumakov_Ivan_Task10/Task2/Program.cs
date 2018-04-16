using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	class Program
	{

		static void Main(string[] args)
		{

			List<Person> people = new List<Person>
			{
				new Person { Name = "John" },
				new Person { Name = "Bill" },
				new Person { Name = "Hugo" },
				new Person { Name = "Tral" }
			};


			var office = new Office();
			foreach (var p in people)
			{
				PersonCome(p);
				office.AddPerson(p);
			}

			foreach (var item in people)
			{
				PersonLeft(item);
				office.LeftPerson(item);
			}


			Console.ReadKey();
		}
		public static void PersonCome(Person person)
		{
			Console.WriteLine(person.Name + " came to work!");
		}
		public static void PersonLeft(Person person)
		{
			Console.WriteLine(person.Name + " left work!");
		}
	}

	public class Office
	{
		Person.EventHandlerCome GreetByAll;
		Person.EventHandlerLeft SayGoodBye;

		//private List<Person> _people;

		public void AddPerson(Person p)
		{
			if (GreetByAll != null)
			{
				GreetByAll(p, DateTime.Now);
			}
			SayGoodBye += p.TellGoodbye;
			GreetByAll += p.Greet;
		}

		public void LeftPerson(Person p)
		{
			SayGoodBye -= p.TellGoodbye;
			if (SayGoodBye != null)
			{
				SayGoodBye(p);
			}
		}
	}
}
