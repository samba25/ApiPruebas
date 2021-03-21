using ApiPruebas.Domain.Models.Common;
using ApiPruebas.Domain.Models.Configurations;
using ApiPruebas.MongoRepo.Models.Common;
using ApiPruebas.MongoRepo.Services.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.MongoRepo.Services
{
	public class DocumentTypeRepository : BaseRepository<DataRefRepositoryModel, DataRefModel>
	{
		public DocumentTypeRepository(IOptions<ApplicationConfiguration> config) : base(config)
		{
		}

		public override string DatabaseName => "Pruebas";
		public override string CollectionName => "DocumentTypes";
	}
}
