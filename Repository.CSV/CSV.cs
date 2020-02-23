using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Repository.Interface;
namespace Repository.CSV
{
	public class CSV : IPersonRepository
	{
		public void AddPerson(Person newPerson)
		{
			throw new NotImplementedException();
		}

		public void DeletePerson(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Person> GetPeople()
		{
			IEnumerable<Person> final = null;
			var people = File.ReadAllLines("people.csv")
						.Skip(1).Select(c => ConvertToPeople(c));
			final = people;
			return final;
		}

		private Person ConvertToPeople(string line)
		{
			var columns = line.Split(',');
			var person = new Person();
			person.Id = int.Parse(columns[0]);
			person.GivenName = columns[1];
			person.FamilyName = columns[2];
			person.startDate = DateTime.Now; // Parse(columns[3]);
			person.Rating = int.Parse(columns[4]);
			//		person = columns[5];
			return person;
		}

		public Person GetPerson(int id)
		{
			throw new NotImplementedException();
		}

		public void UpdatePerson(int id, Person updatedPerson)
		{
			throw new NotImplementedException();
		}
	}
}
