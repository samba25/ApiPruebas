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
		[BsonId]
		[BsonGuidRepresentation(MongoDB.Bson.GuidRepresentation.Standard)]
		public Guid Id { get; set; } = Guid.NewGuid();
		public abstract TMe FromModel(TOut input);
		public abstract TOut ToModel();

		public void TrySetGuid(string id)
		{
			var guid = Guid.Empty;
			var result = Guid.TryParse(id, out guid);
			if (result == true)
			{
				Id = guid;
			}
		}
	}


}
