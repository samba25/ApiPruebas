using ApiPruebas.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebas.Domain.Models
{
	public class Person : IModel
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public DataRefModel Gender { get; set; }
		public DataRefModel Nationality { get; set; }
		public List<Document> Documents { get; set; }
		public List<DataRefModel> Interests { get; set; }
		public DataRefModel State { get; set; }
	}
}
