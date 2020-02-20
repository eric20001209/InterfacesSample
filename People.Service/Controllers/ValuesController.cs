using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Mvc;

namespace People.Service.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		// GET api/values
		[HttpGet]
		public IActionResult Get()
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

			return Ok(plist);
			
		}

		// GET api/values/5
		[HttpGet("{id}")]
		public ActionResult<string> Get(int id)
		{
			return "value";
		}

		// POST api/values
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/values/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/values/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
