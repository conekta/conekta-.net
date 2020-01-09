using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text.RegularExpressions;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{

    public class Resource : ConektaObject, ICloneable
    {
        Requestor requestor = new Requestor();
        public String type { get; set; }
        public String message { get; set; }
        public String message_to_purchaser { get; set; }
        public String code { get; set; }
        public String param { get; set; }

        public Resource() { }

        public string request(string method, string resource_uri, string data = "{}")
        {
            return requestor.request(method, resource_uri, data);
        }

        public string find(String resource_uri, String id)
        {
            return requestor.request("GET", resource_uri + "/" + id);
        }

        public string where(String resource_uri, String data)
        {
            Dictionary<string, string> obj = JsonConvert.DeserializeObject<Dictionary<string, string>>(data);

            string list_params = "?";

            foreach (KeyValuePair<string, string> item in obj)
            {
                list_params += item.Key + "=" + item.Value + "&";
            }

            return requestor.request("GET", resource_uri + list_params.Substring(0, list_params.Length - 1));
        }

        public string create(String resource_uri, String data)
        {
            return requestor.request("POST", resource_uri, data);
        }

        public string update(String resource_uri, String data)
        {
            return requestor.request("PUT", resource_uri, data);
        }

        public string delete(String resource_uri)
        {
            return requestor.request("DELETE", resource_uri);
        }

        public JObject toObject(string json)
        {
            JObject result = JObject.Parse(json);

            JObject obj = new JObject();

            foreach (KeyValuePair<string, JToken> item in result)
            {
                var key = item.Key;
                var properties = this.Clone().GetType().GetProperties();



                foreach (PropertyInfo property in properties)
                {
                    var property_name = property.Name;
                    var property_type = property.PropertyType.ToString();
                    var multi = false;

                    if (property.PropertyType.IsArray && property_name != "tags")
                    {
                        multi = true;
                    }

                    Regex pattern = new Regex("\\[\\]", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                    property_type = pattern.Replace(property_type, "");


                    if (property_name == key)
                    {
                        if (multi)
                        {
                            obj.Add(key, item.Value["data"]);
                        }
                        else if (item.Value.Type.ToString() != "Null")
                        {
                            obj.Add(key, item.Value);
                        }
                    }

                    if (property_name == "object")
                    {
                        obj.Add("_object", item.Value);
                        obj.Remove("object");
                    }
                }
            }

            return obj;
        }

    }

}
