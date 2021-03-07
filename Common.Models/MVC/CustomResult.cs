using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Common.Models.MVC
{
	public class CustomResult : CustomResult<Object>
	{
		public CustomResult() : base() { }
	}

	public class CustomResult<T> : ObjectResult
		where T : class
	{
		public CustomResult(T value = null, List<Error> errors = null, List<Error> warnings = null) : base(null)
		{
			var result = new Result<T>();
			result.Value = value;
			result.Errors.AddRange(errors ?? new List<Error>());
			result.Warnings.AddRange(warnings ?? new List<Error>());

			base.Value = result;
		}
	}
}
