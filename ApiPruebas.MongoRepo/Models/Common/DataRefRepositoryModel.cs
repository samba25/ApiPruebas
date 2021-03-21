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
			TrySetGuid(input.Key);
			Description = input.Value;
			return this;
		}

		public override DataRefModel ToModel()
		{
			return new DataRefModel()
			{
				Key = Id.ToString(),
				Value = Description
			};
		}
	}
}
