using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
	public class ConektaException : Exception
	{
		public JArray details;
		public string message;
		public String _type;
		public String _object;

		public ConektaException()
		{
		}

		public ConektaException(string message) : base(message)
		{
			this.message = message;
		}
	}
}

