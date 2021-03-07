using Common.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebas.Models
{
	public class Person
	{
		public string Name { get; set; }
		public string LastName { get; set; }
		public DateTime BirthDate { get; set; }
		public DataRef Gender { get; set; }
		public DataRef Nationality { get; set; }
		public List<Document> Documents { get; set; }
		public List<DataRef> Interests { get; set; }
		public DataRef State { get; set; }
	}
}
