using ApiPruebas.Domain.Models;
using ApiPruebas.MongoRepo.Models.Common;
using Common.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Models
{
	public class CityRepositoryModel : SimpleValueRepositoryModel<CityRepositoryModel,City>
	{
		[DataMember]
		public DataRef Country { get; set; }

		public override CityRepositoryModel FromModel(City input)
		{
			throw new NotImplementedException();
		}

		public override City ToModel(CityRepositoryModel input)
		{
			throw new NotImplementedException();
		}
	}
}
