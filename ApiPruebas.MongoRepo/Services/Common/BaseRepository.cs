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

		protected async Task<TOutModel> BaseReadOne(Guid id)
		{
			if (id == Guid.Empty) return default;

			var filterDefinition = Builders<TModel>.Filter;
			var cursor = await Collection.FindAsync(filterDefinition.Eq(x => x.Id, id));
			var result = cursor.FirstOrDefault();
			return result == null ? default : result.ToModel();
		}

		//TODO no terminado
		protected async Task<CrudOperationResult> BaseUpsertOne(TModel value)
		{
			var filterBuilder = Builders<TModel>.Filter;
			var updateBuilder = Builders<TModel>.Update;

			var updateResult = await Collection.UpdateOneAsync(filterBuilder.Eq(x => x.Id, value.Id), updateBuilder.Set(x => x, value), new UpdateOptions() { IsUpsert = true });
			var result = new CrudOperationResult();
			if (updateResult.IsAcknowledged)
			{
				result.Exists = updateResult.MatchedCount > 0;
				result.Updated = updateResult.ModifiedCount > 0;
			}

			return result;
		}

		//TODO no terminado
		protected async Task<CrudOperationResult> BaseDelete(Guid id)
		{
			var result = new CrudOperationResult();
			if (id != Guid.Empty)
			{
				var filterBuilder = Builders<TModel>.Filter;
				var deleteResult = await Collection.DeleteOneAsync(filterBuilder.Eq(x => x.Id, id));
				result.Success = deleteResult.IsAcknowledged && deleteResult.DeletedCount > 0;
				result.Exists = deleteResult.DeletedCount > 0;
				result.Id = result.Success ? id.ToString() : "";
			}

			return result;
		}

		//Utils
		protected Guid GetGuid(string id)
		{
			var realId = Guid.Empty;
			var result = Guid.TryParse(id, out realId);
			return result ? realId : Guid.Empty;
		}
	}
}
