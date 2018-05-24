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
			String apiVersion = conekta.Api.version.Replace(".", "");
			if (int.Parse(apiVersion) < 100)
			{
				ConektaException ex = new ConektaException("This package just support api version 1.0 or higher");
				ex.details = new JArray(0);
				ex._object = "error";
				ex._type = "api_version_unsupported";

				throw ex;
			}

			try {
				ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
				var uname = Environment.OSVersion;
				HttpWebRequest http = (HttpWebRequest)WebRequest.Create(conekta.Api.baseUri + resource_uri);
				http.Accept = "application/vnd.conekta-v" + conekta.Api.version + "+json";
				http.UserAgent = "Conekta/v1 DotNetBindings10/Conekta::" + conekta.Api.version;
				http.Method = method;

				var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(conekta.Api.apiKey);
				var userAgent = (@"{
				  ""bindings_version"":""" + conekta.Api.version + @""",
				  ""lang"":"".net"",
				  ""lang_version"":""" + typeof(string).Assembly.ImageRuntimeVersion + @""",
				  ""publisher"":""conekta"",
				  ""uname"":""" + uname + @"""
				}");

				http.Headers.Add("Authorization", "Basic " + System.Convert.ToBase64String(plainTextBytes) + ":");
				http.Headers.Add ("Accept-Language", conekta.Api.locale);
				http.Headers.Add ("X-Conekta-Client-User-Agent", userAgent );

				if (method == "POST" || method == "PUT") {
					var dataBytes = Encoding.UTF8.GetBytes(data);

					http.ContentLength = dataBytes.Length;
					http.ContentType = "application/json";

					Stream dataStream = http.GetRequestStream ();
					dataStream.Write (dataBytes, 0, dataBytes.Length);
				}

				WebResponse response = http.GetResponse();

				var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

				//System.Console.WriteLine(responseString);

				return responseString;
			} catch (WebException webExcp) {
				WebExceptionStatus status = webExcp.Status;

				HttpWebResponse httpResponse = (HttpWebResponse)webExcp.Response;

				var encoding = ASCIIEncoding.UTF8;
				using (var reader = new System.IO.StreamReader(httpResponse.GetResponseStream(), encoding))
				{
					string responseText = reader.ReadToEnd();

					//System.Console.WriteLine(responseText);

					JObject obj = JsonConvert.DeserializeObject<JObject>(responseText, new JsonSerializerSettings
					{
						NullValueHandling = NullValueHandling.Ignore
					});

					ConektaException ex = new ConektaException(obj.GetValue("type").ToString());
					ex.details = (JArray)obj["details"];
					ex._object = obj.GetValue("object").ToString();
					ex._type = obj.GetValue("type").ToString();

					throw ex;
				}
			} catch	(Exception e) {
				System.Console.WriteLine(e.ToString());
				return "";
			}
		}

	}

}
