using ApiPruebas.Domain.Models;
using Common.Models.Data;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Models
{
	public class PersonRepositoryModel
	{
		[DataMember]
		public string Name { get; set; }
		[DataMember]
		public string LastName { get; set; }
		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		[DataMember]
		public DateTime BirthDate { get; set; }
		[DataMember]
		public DataRef Gender { get; set; }
		[DataMember]
		public DataRef Nationality { get; set; }
		[DataMember]
		public IEnumerable<DocumentRepositoryModel> Documents { get; set; }
		[DataMember]
		public List<DataRef> Interests { get; set; }
		[DataMember]
		public DataRef State { get; set; }

		public static PersonRepositoryModel FromModel(Person value)
		{
			return new PersonRepositoryModel()
			{
				Name = value.Name,
				LastName = value.LastName,
				BirthDate = value.BirthDate,
				Gender = value.Gender,
				Nationality = value.Nationality,
				Documents = value.Documents.Select(x => DocumentRepositoryModel.FromModel(x)),
				Interests = value.Interests,
				State = value.State
			};
		}

		public static Person ToModel(PersonRepositoryModel value)
		{
			return new Person()
			{
				Name = value.Name,
				LastName = value.LastName,
				BirthDate = value.BirthDate,
				Gender = value.Gender,
				Nationality = value.Nationality,
				Documents = value.Documents.Select(x => DocumentRepositoryModel.ToModel(x)).ToList(),
				Interests = value.Interests,
				State = value.State
			};
		}

	}
}
