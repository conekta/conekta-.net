using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;

namespace conekta
{

	public class Requestor
	{

		public Requestor ()
		{
		}

		public String request (String method, String resource_uri, String data = "{}")
		{
			HttpWebRequest http = (HttpWebRequest)WebRequest.Create(conekta.Api.baseUri + resource_uri);
			http.Accept = "application/vnd.conekta-v" + conekta.Api.version + "+json";
			http.UserAgent = "Conekta/v1 DotNetBindings/Conekta::" + conekta.Api.version;
			http.Method = method;

			var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(conekta.Api.apiKey);
			http.Headers.Add("Authorization", "Basic " + System.Convert.ToBase64String(plainTextBytes) + ":");
			http.Headers.Add ("Accept-Language", conekta.Api.locale);

			if (method == "POST" || method == "PUT") {
				var dataBytes = Encoding.ASCII.GetBytes(data);

				http.ContentLength = dataBytes.Length;
				http.ContentType = "application/json";

				Stream dataStream = http.GetRequestStream ();
				dataStream.Write (dataBytes, 0, dataBytes.Length);
			}

			WebResponse response = http.GetResponse ();
			var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
			return responseString;
		}

	}

}
