using ApiPruebas.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.MongoRepo.Models.Common
{
	public class DataRefRepositoryModel : BaseRepositoryModel<DataRefRepositoryModel, DataRefModel>
	{
		public string Description { get; set; }

		public override DataRefRepositoryModel FromModel(DataRefModel input)
		{
			return new DataRefRepositoryModel()
			{
				Id = input.Key,
				Description = input.Value
			};
		}

		public override DataRefModel ToModel(DataRefRepositoryModel input)
		{
			return new DataRefModel()
			{
				Key = input.Id,
				Value = input.Description
			};
		}
	}
}
