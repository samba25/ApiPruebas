using ApiPruebas.Domain.Models.Common;
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


}
