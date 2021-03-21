using ApiPruebas.Domain.Models.Common;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.MongoRepo.Models.Common
{

	public abstract class BaseRepositoryModel<TMe, TOut>
		where TMe : BaseRepositoryModel<TMe, TOut>
		where TOut : class, IModel
	{
		[BsonElement("_id")]
		[BsonGuidRepresentation(MongoDB.Bson.GuidRepresentation.Standard)]
		public Guid Id { get; set; } = Guid.NewGuid();
		public abstract void FromModel(TOut input);
		public abstract TOut ToModel();
	}


}
