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
			MyEvent _event = new MyEvent();
			DateTime data = DateTime.Now;

			Person pers1 = new Person { Name = "John" };
			Person pers2 = new Person { Name = "Bill" };
			Person pers3 = new Person { Name = "Hugo" };
			_event.Come += pers1.Greet;
			_event.Come += pers2.Greet;
			_event.Come += pers3.Greet;
			_event.OnCome(pers2, data);
			Console.ReadKey();
		}
	}
}
