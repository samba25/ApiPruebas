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
			return new CityRepositoryModel()
			{
				Id = input.Key,
				Country = input.Country,
				Description = input.Value
			};
		}

		public override City ToModel(CityRepositoryModel input)
		{
			return new City()
			{
				Key = input.Id,
				Value = input.Description,
				Country = input.Country
			};
		}
	}
}
