using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiPruebas.Dtos.Common
{
	public abstract class BaseDto<TMe, TModel>
	{
		public abstract TMe FromModel(TModel value);
		public abstract TModel ToModel();
	}
}
