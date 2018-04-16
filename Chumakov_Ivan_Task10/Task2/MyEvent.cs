using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
	delegate void EventHandler(Person person, DateTime data);
	delegate void EventHandlerBay(Person person);
	class MyEvent
	{
		public event EventHandler Come;
		public event EventHandlerBay Leave;
		public void OnCome(Person pers, DateTime data)
		{
			if (Come != null)
			{
				Come(pers, data);
			}
		}
		public void OnLeave(Person pers)
		{
			if(Leave != null)
			{
				Leave(pers);
			}
		}
	}
}
