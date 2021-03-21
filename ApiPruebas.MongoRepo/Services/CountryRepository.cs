using ApiPruebas.Domain.Models;
using ApiPruebas.Domain.Models.Configurations;
using ApiPruebas.MongoRepo.Models;
using ApiPruebas.MongoRepo.Services.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Services
{
	public class CountryRepository : BaseRepository<CountryRepositoryModel, Country>
	{
		public CountryRepository(IOptions<ApplicationConfiguration> config) : base(config)
		{
		}

		public override string DatabaseName => "Pruebas";
		public override string CollectionName => "Countries";
	}
}
