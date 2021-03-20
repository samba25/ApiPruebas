using Common.Models.Data;
using Common.Models.MVC;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.Domain.Contracts.Services
{
	public interface IGeographyService
	{
		public List<DataRef> GetCities(string query);
	}
}
