using ApiPruebas.MongoRepo.Models.Common;
using Common.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Models
{
	public class CityRepositoryModel : SimpleValueRepositoryModel
	{
		[DataMember]
		public DataRef Country { get; set; }
	}
}
