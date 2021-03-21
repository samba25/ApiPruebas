using ApiPruebas.Domain.Models;
using ApiPruebas.Domain.Models.Common;
using ApiPruebas.MongoRepo.Models.Common;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace ApiPruebas.MongoRepo.Models
{
	public class PersonRepositoryModel : BaseRepositoryModel<PersonRepositoryModel, Person>
	{
		public string Name { get; set; }
		public string LastName { get; set; }
		[BsonDateTimeOptions(Kind = DateTimeKind.Unspecified)]
		public DateTime BirthDate { get; set; }
		public DataRefModel Gender { get; set; }
		public DataRefModel Nationality { get; set; }
		public IEnumerable<DocumentRepositoryModel> Documents { get; set; }
		public List<DataRefModel> Interests { get; set; }
		public DataRefModel State { get; set; }

		public override PersonRepositoryModel FromModel(Person input)
		{
			return new PersonRepositoryModel()
			{
				Name = input.Name,
				LastName = input.LastName,
				BirthDate = input.BirthDate,
				Gender = input.Gender,
				Nationality = input.Nationality,
				Documents = input.Documents.Select(x => DocumentRepositoryModel.FromModel(x)),
				Interests = input.Interests,
				State = input.State
			};
		}

		public override Person ToModel(PersonRepositoryModel value)
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
