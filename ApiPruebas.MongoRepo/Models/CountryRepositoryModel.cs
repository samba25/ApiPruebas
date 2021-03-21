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

		public override void FromModel(Country input)
		{
			Id = input.Key;
			Description = input.Value;
			CountryCode = input.CountryCode;
		}

		public override Country ToModel()
		{
			return new Country()
			{
				Key = Id,
				Value = Description,
				CountryCode = CountryCode
			};
		}
	}
}
