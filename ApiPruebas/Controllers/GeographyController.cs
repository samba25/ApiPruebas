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
		public async Task<CustomResult<DataRef>> GetCities(string id)
		{
			var result = await GeographyService.GetCities(id);
			return ResultFactory.Ok(result);
		}
	}
}
