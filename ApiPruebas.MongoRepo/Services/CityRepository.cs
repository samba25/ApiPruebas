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
	public class CityRepository : BaseRepository<CityRepositoryModel, City>, ICityRepository
	{

		public CityRepository(IOptions<ApplicationConfiguration> config) : base(config)
		{
		}

		public override string DatabaseName => "Pruebas";
		public override string CollectionName => "Cities";

		public async Task<CrudOperationResult> Delete(string id) => await BaseDelete(GetGuid(id));

		public async Task<City> Read(string id) => await BaseReadOne(GetGuid(id));

		public async Task<CrudOperationResult> Upsert(City value) => await BaseUpsertOne(new CityRepositoryModel().FromModel(value));
	}
}
