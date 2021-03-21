using ApiPruebas.Domain.Contracts.Repositories;
using ApiPruebas.Domain.Contracts.Services;
using Common.Models.Data;
using Common.Models.MVC;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiPruebas.Core.Services
{
	public class GeographyService : IGeographyService
	{
		public GeographyService(ICityRepository cityRepository)
		{
			CityRepository = cityRepository;
		}

		public ICityRepository CityRepository { get; }

		public async Task<DataRef> GetCities(string id)
		{
			var city = await CityRepository.Read(id);
			return new DataRef(city.Key, city.Value);
		}
	}
}
