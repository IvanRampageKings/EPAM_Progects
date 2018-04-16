using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Person
    {
        public delegate void EventHandlerCome(Person person, DateTime data);
		public delegate void EventHandlerLeft(Person person);

        public event EventHandlerCome Come;
		public event EventHandlerLeft Left;

		public void OnCome()
        {
			if(Come != null)
			{
				Come(this, DateTime.Now);			
			}         
        }
		public void OnLeft()
		{
			if(Left != null)
			{
				Left(this);
			}
		}

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
