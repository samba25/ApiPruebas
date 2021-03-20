using ApiPruebas.Domain.Models;
using Common.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Models
{
	public class DocumentRepositoryModel
	{
		[DataMember]
		public DataRef Type { get; set; }
		[DataMember]
		public string Value { get; set; }

		public static DocumentRepositoryModel FromModel(Document value)
		{
			return new DocumentRepositoryModel()
			{
				Type = value.Type,
				Value = value.Value
			};
		}

		public static Document ToModel(DocumentRepositoryModel value)
		{
			return new Document()
			{
				Type = value.Type,
				Value = value.Value
			};
		}
	}
}
