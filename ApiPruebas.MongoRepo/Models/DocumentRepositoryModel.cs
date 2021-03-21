using ApiPruebas.Domain.Models;
using ApiPruebas.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Models
{
	public class DocumentRepositoryModel
	{
		public DocumentRepositoryModel(Document x)
		{
			FromModel(x);
		}

		[DataMember]
		public DataRefModel Type { get; set; }
		[DataMember]
		public string Value { get; set; }

		public void FromModel(Document value)
		{
			Type = value.Type;
			Value = value.Value;
		}

		public Document ToModel()
		{
			return new Document()
			{
				Type = Type,
				Value = Value
			};
		}
	}
}
