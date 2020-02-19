using System;
using Common;

namespace People.Library
{
	public class PersonRepository
	{
		public Person[] GetPeople() 
		{
			Person[] plist = new Person[9];
			return plist;
		}

		public Person GetPerson(int id) 
		{
			return new Person();
		}
	}
}
