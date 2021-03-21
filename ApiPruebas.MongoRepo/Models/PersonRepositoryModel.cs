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

		public override void FromModel(Person input)
		{
			Name = input.Name;
			LastName = input.LastName;
			BirthDate = input.BirthDate;
			Gender = input.Gender;
			Nationality = input.Nationality;
			Documents = input.Documents.Select(x => new DocumentRepositoryModel(x));
			Interests = input.Interests;
			State = input.State;
		}

		public override Person ToModel()
		{
			return new Person()
			{
				Name = Name,
				LastName = LastName,
				BirthDate = BirthDate,
				Gender = Gender,
				Nationality = Nationality,
				Documents = Documents.Select(x => x.ToModel()).ToList(),
				Interests = Interests,
				State = State
			};
		}
	}
}
