using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Interface;
using System.Data.Entity;

namespace Repository.SQL
{
	public class PeopleDb : DbContext
	{
		public DbSet<Person> People{ get; set; }
	}
}
