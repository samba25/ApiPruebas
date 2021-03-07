using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Common.Models.MVC
{
	public static class ResultFactory
	{
		public static CustomResult<T> Ok<T>(T value)
			where T : class
		{
			var result = new CustomResult<T>(value);
			result.StatusCode = (int)HttpStatusCode.OK;
			return result;
		}
	}
}
