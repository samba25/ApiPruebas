using ApiPruebas.Domain.Models.Common;
using ApiPruebas.Domain.Models.Configurations;
using ApiPruebas.MongoRepo.Models.Common;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Services.Common
{
	public abstract class SimpleValueRepository<TModel, TOutModel> : BaseRepository<TModel, TOutModel>
		where TModel : IRepoModel<TModel, TOutModel>
		where TOutModel : class, IModel
	{

		public SimpleValueRepository(IOptions<AppConfiguration> config) : base(config)
		{
		}


	}
}
