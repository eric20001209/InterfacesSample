using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interface
{
	public interface IPersonRepository
	{
		void AddPerson(Person newPerson);  //Create
		IEnumerable<Person> GetPeople();  //Read
		Person GetPerson(int id);  //read
		void UpdatePerson(int id, Person updatedPerson);
		void DeletePerson(int id);
	}
}
