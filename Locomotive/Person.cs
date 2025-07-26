using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locomotive
{
    public class Person
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}
        public Person(string name, string lastName)
        {
            this.name = name;
            this.lastName = lastName;
        }
        public override string ToString()
        {
            return $"Jméno: {name}, Příjmení: {lastName}";
        }
    }
}
