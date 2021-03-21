using ApiPruebas.Domain.Models;
using ApiPruebas.MongoRepo.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.MongoRepo.Models
{
	public class CountryRepositoryModel : BaseRepoModel<CountryRepositoryModel, Country>
	{
		public string Description { get; set; }
		public string CountryCode { get; set; }

		public override CountryRepositoryModel FromModel(Country input)
		{
			return new CountryRepositoryModel()
			{
				Id = input.Key,
				Description = input.Value,
				CountryCode = input.CountryCode
			};
		}

		public override Country ToModel(CountryRepositoryModel input)
		{
			return new Country()
			{
				Key = input.Id,
				Value = input.Description,
				CountryCode = input.CountryCode
			};
		}
	}
}
