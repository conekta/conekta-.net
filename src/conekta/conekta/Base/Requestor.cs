using System;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{

	public class Requestor
	{

		public Requestor ()
		{
		}

		public String request (String method, String resource_uri, String data = "{}")
		{
			try {
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
			} catch (WebException webExcp) {
				WebExceptionStatus status =  webExcp.Status;

				if (status == WebExceptionStatus.ProtocolError) {
					HttpWebResponse httpResponse = (HttpWebResponse)webExcp.Response;

					var encoding = ASCIIEncoding.ASCII;
					using (var reader = new System.IO.StreamReader(httpResponse.GetResponseStream(), encoding))
					{
						string responseText = reader.ReadToEnd();

						JObject obj = JsonConvert.DeserializeObject<JObject>(responseText, new JsonSerializerSettings
						{
							NullValueHandling = NullValueHandling.Ignore
						});


						ConektaException ex = new ConektaException(obj.GetValue("message_to_purchaser").ToString());
						ex.message_to_purchaser = obj.GetValue("message_to_purchaser").ToString();
						ex.message = obj.GetValue("message").ToString();
						ex._type = obj.GetValue("type").ToString();

						throw ex;
					}
				}
				return "";
			} catch	(Exception e) {
				System.Console.WriteLine (e.ToString ());
				return "";
			}
		}

	}

}
