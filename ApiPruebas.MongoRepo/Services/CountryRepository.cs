using ApiPruebas.Domain.Contracts.Repositories;
using ApiPruebas.Domain.Models;
using ApiPruebas.Domain.Models.Configurations;
using ApiPruebas.Domain.Models.Repositories;
using ApiPruebas.MongoRepo.Models;
using ApiPruebas.MongoRepo.Services.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Services
{
	public class CountryRepository : BaseRepository<CountryRepositoryModel, Country>,ICountryRepository
	{
		public CountryRepository(IOptions<ApplicationConfiguration> config) : base(config)
		{
		}

		public override string DatabaseName => "Pruebas";
		public override string CollectionName => "Countries";

		public Task<CrudOperationResult> Delete(string id) => BaseDelete(GetGuid(id));
		public Task<Country> Read(string id) => BaseReadOne(GetGuid(id));
		public Task<CrudOperationResult> Upsert(Country value) => BaseUpsertOne(new CountryRepositoryModel().FromModel(value));
	}
}
