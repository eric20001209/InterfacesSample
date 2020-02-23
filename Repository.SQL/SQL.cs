using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interface;
using System.IO;


namespace Repository.SQL
{
	public class SQL : IPersonRepository
	{
		PeopleDb _db = new PeopleDb();
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
//			throw new NotImplementedException();
			Database.SetInitializer(new DropCreateDatabaseIfModelChanges<PeopleDb>());
			InsertData();
			IEnumerable<Person> result = null;
			var list = _db.People.ToList();
			result = list;
			return result;
		}

		private void InsertData()
		{
			var people = File.ReadAllLines("people.csv")
			.Skip(1)
			.Select(c=>
			{
				var line = c;
				var columns = line.Split(',');
				var person = new Person();
				person.Id = int.Parse(columns[0]);
				person.GivenName = columns[1];
				person.FamilyName = columns[2];
				person.startDate = DateTime.Now; // Parse(columns[3]);
				person.Rating = int.Parse(columns[4]);
				return person;
			}).ToList();

			var db = new PeopleDb();
			if (!db.People.Any())
			{
				foreach (var person in people)
				{
					db.People.Add(person);
				}
				db.SaveChanges();
			}
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
