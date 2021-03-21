using ApiPruebas.Domain.Contracts.Repositories;
using ApiPruebas.Domain.Models.Common;
using ApiPruebas.Domain.Models.Configurations;
using ApiPruebas.Domain.Models.Repositories;
using ApiPruebas.MongoRepo.Models.Common;
using ApiPruebas.MongoRepo.Services.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Services
{
	public class GenderRepository : BaseRepository<DataRefRepositoryModel, DataRefModel>,IGenderRepository
	{
		public GenderRepository(IOptions<ApplicationConfiguration> config) : base(config)
		{
		}

		public override string DatabaseName => "Pruebas";
		public override string CollectionName => "Genders";

		public Task<CrudOperationResult> Delete(string id) => BaseDelete(GetGuid(id));
		public Task<DataRefModel> Read(string id) => BaseReadOne(GetGuid(id));
		public Task<CrudOperationResult> Upsert(DataRefModel value) => BaseUpsertOne(new DataRefRepositoryModel().FromModel(value));
	}
}
