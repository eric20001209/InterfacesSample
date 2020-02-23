using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Repository.Interface;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Repository.Service
{
	public class Service : IPersonRepository
	{
		public object JsonConvert { get; private set; }

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
			string url = "https://localhost:44315/api/values";

			WebClient client = new WebClient();
			string retString = client.DownloadString(url);
			IEnumerable<Person> final =  //JsonConvert.DeserializeObject
						Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Person>>(retString);

			return final;
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
