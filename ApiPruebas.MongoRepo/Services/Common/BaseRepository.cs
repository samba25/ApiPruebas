using ApiPruebas.Domain.Models.Common;
using ApiPruebas.Domain.Models.Configurations;
using ApiPruebas.Domain.Models.Repositories;
using ApiPruebas.MongoRepo.Models.Common;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Services.Common
{
	public abstract class BaseRepository<TModel, TOutModel>
		where TModel : BaseRepositoryModel<TModel, TOutModel>
		where TOutModel : class, IModel
	{
		public abstract string DatabaseName { get; }
		public abstract string CollectionName { get; }

		public IMongoCollection<TModel> Collection { get; }

		public BaseRepository(IOptions<ApplicationConfiguration> config)
		{
			if (config == null || config.Value == null)
			{
				throw new ArgumentNullException(nameof(config));
			}

			var conn = new MongoClient(config.Value.ConnectionString);
			var db = conn.GetDatabase(DatabaseName);
			Collection = db.GetCollection<TModel>(CollectionName);
		}

		public async Task<TOutModel> GetById(string id)
		{
			var filterDefinition = Builders<TModel>.Filter;
			var cursor = await Collection.FindAsync(filterDefinition.Eq(x => x.Id, id));
			var result = cursor.FirstOrDefault();
			return result == null ? default : result.ToModel();
		}

		public async Task<CrudOperationResult> BaseUpsert(TModel value)
		{
			Collection.UpdateOneAsync(,, new UpdateOptions() { IsUpsert = true });
		}
	}
}
