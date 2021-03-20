using ApiPruebas.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Models.Common
{
	public abstract class SimpleValueRepositoryModel<TMe, TOut> : IRepoModel<TMe, TOut>
		where TMe : IRepoModel<TMe, TOut>
		where TOut : class, IModel
	{
		[DataMember]
		public string Description { get; set; }

		public abstract TMe FromModel(TOut input);

		public abstract TOut ToModel(TMe input);
	}
}
