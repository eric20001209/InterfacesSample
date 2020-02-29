using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interface;
using System.Configuration;
using Repository.Service;

namespace Repository.Factory
{
    public class ReposistoryFactory
    {
		public static IPersonRepository GetRepository()
		{
			string repositoryTypeName = ConfigurationManager.AppSettings["RepositoryType"];
			Type reposityType = Type.GetType(repositoryTypeName);
			object repository = Activator.CreateInstance(reposityType);

			IPersonRepository personRepository = repository as IPersonRepository;
			return personRepository;
		}

		public static IPersonRepository GetRepo()
		{
			IPersonRepository result = null;
			var service = new Service.Service();
			result = service;
			return result;
		}
    }
}
