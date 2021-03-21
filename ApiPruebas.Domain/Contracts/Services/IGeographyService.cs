using ApiPruebas.Domain.Models;
using Common.Models.Data;
using Common.Models.MVC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiPruebas.Domain.Contracts.Services
{
	public interface IGeographyService
	{
		public Task<DataRef> GetCities(string id);
	}
}
