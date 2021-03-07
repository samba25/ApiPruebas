using Common.Models.Data;
using Common.Models.MVC;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebas.Controllers
{
	[Route("[controller]")]
	public class GeographyController
	{

		[HttpGet("cities/get")]
		public CustomResult<List<DataRef>> GetCities(string query)
		{
			var result = new List<DataRef>()
			{
				new DataRef("123","cityTest")
			};
			return ResultFactory.Ok(result);
		}
	}
}
