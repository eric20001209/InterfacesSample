using Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Service;
using Repository.CSV;
using Repository.SQL;

namespace Repository.Factory
{
	public class Factory 
	{
		public static IPersonRepository GetRepositoryByType(string DataSourceType)
		{
			IPersonRepository result = null;
		
			switch (DataSourceType)
			{
				case "Service":
					var service = new Service.Service();
					result = service;
					break;
				case "CSV":
					var csv = new CSV.CSV();
					result = csv;
					break;
				case "SQL":
					var sql = new SQL.SQL();
					result = sql;
					break;
				default:
					throw new ArgumentException();
			}
			return result;
		}

	}
}
