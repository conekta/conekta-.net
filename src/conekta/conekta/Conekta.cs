using System;


namespace conekta
{
	public abstract class Api
	{
        private readonly static Uri baseUri = new System.Uri("https://api.conekta.io");
        public static Uri BaseUri
        {
            get { return Api.baseUri; }
        } 

		public static string version { get; set; }
		public static string locale { get; set; }
		public static string apiKey { get; set; }

	}
}
