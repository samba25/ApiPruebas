using ApiPruebas.Domain.Models;
using ApiPruebas.Domain.Models.Common;
using ApiPruebas.MongoRepo.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Models
{
	public class CityRepositoryModel : BaseRepositoryModel<CityRepositoryModel, City>
	{

		public string Description { get; set; }
		public DataRefModel Country { get; set; }

		public override CityRepositoryModel FromModel(City input)
		{
			TrySetGuid(input.Key);
			Country = input.Country;
			Description = input.Value;
			return this;
		}

		public override City ToModel()
		{
			return new City()
			{
				Key = Id.ToString(),
				Value = Description,
				Country = Country
			};
		}
	}
}
