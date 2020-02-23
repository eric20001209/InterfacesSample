using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonRepository.Interface;
using System.Configuration;

namespace PersonRepository.Factory
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
    }
}
