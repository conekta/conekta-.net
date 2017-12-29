using System.Text.RegularExpressions;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;


namespace conekta
{
  public class Event : Resource
  {
    public string id { get; set; }
    public string event_data { get; set; }
    public string livemode { get; set; }
    public string webhook_status { get; set; }
    public string created_at { get; set; }
    public string type { get; set; }


     public Event[] where(JObject data)
     {
      string result = this.where("/events", data.ToString());

      Regex pattern = new Regex("\"object\":", RegexOptions.Multiline | RegexOptions.IgnoreCase);
      result = pattern.Replace(result, "\"_object\":");

      JObject event_result = JObject.Parse(result);

      JArray list = (JArray)event_result["data"];

      Event[] events = new Event[list.Count];

      int counter = 0;

      foreach (var item in event_result.GetValue("data"))
      {
        events[counter] = this.toClass(this.toObject(item.ToString()).ToString());
        events[counter].event_data = item.First.First.ToString();
        counter++;
      }

      return events;
     }
    
    public Event toClass(string json)
    {
      Event event_name = JsonConvert.DeserializeObject<Event>(json, new JsonSerializerSettings
      {
        NullValueHandling = NullValueHandling.Ignore
      });
      return event_name;
    }
  }
}
