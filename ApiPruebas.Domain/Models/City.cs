using ApiPruebas.Domain.Models.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApiPruebas.Domain.Models
{
	public class City : DataRefModel
	{
		public DataRefModel Country { get; set; }
	}
}
