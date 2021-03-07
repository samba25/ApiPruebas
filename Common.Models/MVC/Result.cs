using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.MVC
{
	public class Result<T>
	{
		public T Value { get; set; }
		public List<Error> Errors { get; } = new List<Error>();
		public List<Error> Warnings { get; } = new List<Error>();
	}
}
