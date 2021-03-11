using System.Text.RegularExpressions;
using conekta.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace conekta
{
    public class Order : Resource
    {
        public string id { get; set; }
        public int amount { get; set; }
        public string currency { get; set; }
        public string payment_status { get; set; }
        public ConektaList line_items { get; set; }
        public ConektaList shipping_lines { get; set; }
        public ConektaList tax_lines { get; set; }
        public ConektaList discount_lines { get; set; }
        public string customer_id { get; set; }
        public Customer customer_info { get; set; }
        public string shipping_contact_id { get; set; }
        public ShippingContact shipping_contact { get; set; }
        public FiscalEntity fiscal_entity { get; set; }
        public ConektaList charges { get; set; }
        public ConektaList returns { get; set; }
        public string _object { get; set; }
        public JObject metadata { get; set; }

        /// <summary>
        /// Gets or sets the checkout.
        /// </summary>
        public Checkout checkout { get; set; }

        public Order()
        {
            this.line_items = new ConektaList(typeof(conekta.LineItem));
            this.shipping_lines = new ConektaList(typeof(conekta.ShippingLine));
            this.tax_lines = new ConektaList(typeof(conekta.TaxLine));
            this.discount_lines = new ConektaList(typeof(conekta.DiscountLine));
            this.charges = new ConektaList(typeof(conekta.Charge));
            this.returns = new ConektaList(typeof(conekta.Return));
        }

        public Order create(string data)
        {
            string charge = this.create("/orders", data);
            return this.toClass(this.toObject(charge).ToString());
        }

        public Order find(string id)
        {
            string order = this.find("/orders", id);
            return this.toClass(this.toObject(order).ToString());
        }

        public Order[] where(JObject data)
        {
            string result = this.where("/orders", data.ToString());

            Regex pattern = new Regex("\"object\":", RegexOptions.Multiline | RegexOptions.IgnoreCase);
            result = pattern.Replace(result, "\"_object\":");

            JObject ords = JObject.Parse(result);

            JArray list = (JArray)ords["data"];

            Order[] orders = new Order[list.Count];

            int counter = 0;

            foreach (var item in ords.GetValue("data"))
            {
                orders[counter] = this.toClass(this.toObject(item.ToString()).ToString());
                counter++;
            }

            return orders;
        }

        public Order update(string data)
        {
            Order order = this.toClass(this.toObject(this.update("/orders/" + this.id, data)).ToString());
            this.id = order.id;
            return this;
        }

        public Order capture()
        {
            string charge = this.request("PUT", "/orders/" + this.id + "/capture", @"{}");
            return this.toClass(this.toObject(charge).ToString());
        }

        public Order createReturn(string data)
        {
            string charge = this.request("POST", "/orders/" + this.id + "/refunds", data);
            return this.toClass(this.toObject(charge).ToString());
        }

        public Charge createCharge(string data)
        {
            string charge = this.request("POST", "/orders/" + this.id + "/charges", data);
            Charge skeleton = new Charge();
            return skeleton.toClass(skeleton.toObject(charge).ToString());
        }

        public LineItem createLineItem(string data)
        {
            string line_item = this.request("POST", "/orders/" + this.id + "/line_items", data);
            LineItem skeleton = new LineItem();
            return skeleton.toClass(skeleton.toObject(line_item).ToString());
        }

        public TaxLine createTaxLine(string data)
        {
            string tax_line = this.request("POST", "/orders/" + this.id + "/tax_lines", data);
            TaxLine skeleton = new TaxLine();
            return skeleton.toClass(skeleton.toObject(tax_line).ToString());
        }

        public ShippingLine createShippingLine(string data)
        {
            string shipping_line = this.request("POST", "/orders/" + this.id + "/shipping_lines", data);
            ShippingLine skeleton = new ShippingLine();
            return skeleton.toClass(skeleton.toObject(shipping_line).ToString());
        }

        public DiscountLine createDiscountLine(string data)
        {
            string discount_line = this.request("POST", "/orders/" + this.id + "/discount_lines", data);
            DiscountLine skeleton = new DiscountLine();
            return skeleton.toClass(skeleton.toObject(discount_line).ToString());
        }

        public Order toClass(string json)
        {
            Order order = JsonConvert.DeserializeObject<Order>(json, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });
            return order;
        }
    }
}
