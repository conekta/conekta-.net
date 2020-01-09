using System;

namespace conekta
{
	public abstract class Api
	{
		public const string baseUri = "https://api.conekta.io";
		public static string version { get; set; }
		public static string locale { get; set; }
		public static string apiKey { get; set; }

	}
}
