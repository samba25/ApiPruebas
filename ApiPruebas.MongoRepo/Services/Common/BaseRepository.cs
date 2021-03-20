using ApiPruebas.Domain.Models.Common;
using ApiPruebas.Domain.Models.Configurations;
using ApiPruebas.MongoRepo.Models.Common;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.MongoRepo.Services.Common
{
	public abstract class BaseRepository<TModel, TOutModel>
		where TModel : IRepoModel<TModel, TOutModel>
		where TOutModel : class, IModel
	{
		public abstract string DatabaseName { get; }
		public abstract string CollectionName { get; }

		public IMongoCollection<TModel> Collection { get; }

		public BaseRepository(IOptions<AppConfiguration> config)
		{
			if (config == null || config.Value == null)
			{
				throw new ArgumentNullException(nameof(config));
			}

			var conn = new MongoClient(config.Value.ConnectionString);
			var db = conn.GetDatabase(DatabaseName);
			Collection = db.GetCollection<TModel>(CollectionName);
		}
	}
}
