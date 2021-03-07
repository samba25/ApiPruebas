using System;
using System.Collections.Generic;
using System.Text;

namespace Common.Models.Data
{
	public class DataRef : DataRef<string>
	{
		public DataRef() : base()
		{
		}

		public DataRef(string key, string value) : base(key, value)
		{
		}
	}

	public class DataRef<T> : DataRef<T, T>
		where T : class
	{
		public DataRef() : base()
		{
		}

		public DataRef(T key, T value) : base(key, value)
		{
		}
	}

	public class DataRef<K, V>
		where K : class
		where V : class
	{
		public K Key { get; set; }
		public V Value { get; set; }

		public DataRef()
		{

		}

		public DataRef(K key, V value)
		{
			Key = key;
			Value = value;
		}
	}
}
