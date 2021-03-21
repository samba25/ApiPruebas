using ApiPruebas.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.Domain.Models
{
	public class Country : DataRefModel
	{
		public string CountryCode { get; set; }
	}
}
