using System;
using Common;

namespace People.Library
{
	public class PersonRepository
	{
		public Person[] GetPeople()
		{
			Person[] plist = new Person[]
			{
				new Person { FamilyName = "Han", GivenName = "Shou", Id = 1, Rating = 4, startDate = DateTime.Now },
				new Person { FamilyName = "Tom", GivenName = "Chandler", Id = 2, Rating = 5, startDate = DateTime.Now },
				new Person { FamilyName = "Duncan", GivenName = "Tim", Id = 3, Rating = 7, startDate = DateTime.Now },
				new Person { FamilyName = "Rose", GivenName = "Dirk", Id = 4, Rating = 4, startDate = DateTime.Now },
				new Person { FamilyName = "Marry", GivenName = "Lee", Id = 5, Rating = 5, startDate = DateTime.Now },
				new Person { FamilyName = "Fedder", GivenName = "Jay", Id = 6, Rating = 6, startDate = DateTime.Now } 

			};
			
			return plist;
		}

		public Person GetPerson(int id) 
		{
			return new Person();
		}
	}
}
