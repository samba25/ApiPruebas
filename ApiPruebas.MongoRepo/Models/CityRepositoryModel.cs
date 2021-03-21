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

		public override void FromModel(City input)
		{

			Id = input.Key;
			Country = input.Country;
			Description = input.Value;
		}

		public override City ToModel()
		{
			return new City()
			{
				Key = Id,
				Value = Description,
				Country = Country
			};
		}
	}
}
