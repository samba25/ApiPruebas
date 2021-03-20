﻿using ApiPruebas.Domain.Models.Common;
using Common.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebas.Domain.Models
{
	public class Document : IModel
	{
		public DataRef Type { get; set; }
		public string Value { get; set; }
	}
}
