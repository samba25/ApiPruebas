using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Models.Common
{
	public class SimpleValueRepositoryModel:IRepoModel
	{
		[DataMember]
		public string Description { get; set; }
	}
}
