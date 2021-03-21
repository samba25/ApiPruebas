using ApiPruebas.Domain.Models;
using ApiPruebas.MongoRepo.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.MongoRepo.Models
{
	public class CountryRepositoryModel : BaseRepositoryModel<CountryRepositoryModel, Country>
	{
		public string Description { get; set; }
		public string CountryCode { get; set; }

		public override CountryRepositoryModel FromModel(Country input)
		{
			TrySetGuid(input.Key);
			Description = input.Value;
			CountryCode = input.CountryCode;
			return this;
		}

		public override Country ToModel()
		{
			return new Country()
			{
				Key = Id.ToString(),
				Value = Description,
				CountryCode = CountryCode
			};
		}
	}
}
