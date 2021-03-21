using ApiPruebas.Domain.Models.Common;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.MongoRepo.Models.Common
{

	public interface IRepoModel<TMe, TOut>
		where TMe : IRepoModel<TMe, TOut>
		where TOut : class, IModel
	{
		public TMe FromModel(TOut input);
		public TOut ToModel(TMe input);
	}

	public abstract class BaseRepoModel<TMe, TOut> : IRepoModel<TMe, TOut>
		where TMe : BaseRepoModel<TMe, TOut>
		where TOut : class, IModel
	{
		[BsonElement("_id")]
		public string Id { get; set; } = Guid.NewGuid().ToString();
		public abstract TMe FromModel(TOut input);
		public abstract TOut ToModel(TMe input);
	}


}
