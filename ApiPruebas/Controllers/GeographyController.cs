using ApiPruebas.Domain.Contracts.Services;
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

		public GeographyController(IGeographyService geographyService)
		{
			GeographyService = geographyService;
		}

		public IGeographyService GeographyService { get; }

		[HttpGet("cities/get")]
		public CustomResult<List<DataRef>> GetCities(string query)
		{
			var result = GeographyService.GetCities(query);
			return ResultFactory.Ok(result);
		}
	}
}
