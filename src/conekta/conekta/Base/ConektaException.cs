using System;

namespace conekta
{
	public class ConektaException : Exception
	{
		public String message_to_purchaser;
		public String message;
		public String _type;

		public ConektaException()
		{
		}

		public ConektaException(string message) : base(message)
		{
			this.message = message;
		}
	}
}

