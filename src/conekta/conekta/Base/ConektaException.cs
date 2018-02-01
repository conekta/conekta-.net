using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;


namespace conektaBase
{
    
	public class ConektaException : Exception
	{
        private JArray details;

        public JArray Details
        {
            get { return details; }
            set { details = value; }
        }
        private string message;

        public string CustomMessage
        {
            get { return message; }
            set { message = value; }
        }
        private String _type;

        public String Type
        {
            get { return _type; }
            set { _type = value; }
        }
        private String _object;

        public String CustomObject
        {
            get { return _object; }
            set { _object = value; }
        }

		public ConektaException()
		{
		}

		public ConektaException(string message) : base(message)
		{
			this.message = message;
		}
	}
}

