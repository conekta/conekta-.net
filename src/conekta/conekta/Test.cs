using NUnit.Framework;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using conekta;
using conekta.Models;
using System.Linq;

namespace ConektaTest
{
    [TestFixture()]
    public class ListTest
    {
        public static void getApiKey()
        {
            conekta.Api.apiKey = "key_ZLy4aP2szht1HqzkCezDEA";
        }

        [Test()]
        public void getObject()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            conekta.Order order = new conekta.Order().create(@"{
                  ""currency"": ""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s a"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }, {
                  ""name"": ""Box of Cohiba S1s b"",
                  ""unit_price"": 36000,
                  ""quantity"": 1
                  }, {
                  ""name"": ""Box of Cohiba S1s c"",
                  ""unit_price"": 37000,
                  ""quantity"": 1
                  }, {
                  ""name"": ""Box of Cohiba S1s d"",
                  ""unit_price"": 38000,
                  ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s e"",
                    ""unit_price"": 39000,
                    ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s f"",
                      ""unit_price"": 40000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s g"",
                      ""unit_price"": 41000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s h"",
                      ""unit_price"": 42000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s i"",
                      ""unit_price"": 43000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s j"",
                      ""unit_price"": 44000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s k"",
                      ""unit_price"": 45000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s l"",
                      ""unit_price"": 46000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s m"",
                      ""unit_price"": 47000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s n"",
                      ""unit_price"": 48000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s ñ"",
                      ""unit_price"": 49000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s o"",
                      ""unit_price"": 50000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s p"",
                      ""unit_price"": 51000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s q"",
                      ""unit_price"": 52000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s r"",
                      ""unit_price"": 53000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s s"",
                      ""unit_price"": 54000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s t"",
                      ""unit_price"": 55000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s u"",
                      ""unit_price"": 56000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s v"",
                      ""unit_price"": 57000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s w"",
                      ""unit_price"": 58000,
                      ""quantity"": 1
                  }, {
                    ""name"": ""Box of Cohiba S1s x"",
                      ""unit_price"": 59000,
                      ""quantity"": 1
                  }]
            }");

            LineItem line_item = (LineItem)order.line_items.at(0);

            int size = order.line_items.data.Length;

            order.line_items.next_page();

            Assert.AreEqual(order.line_items.data.Length > size, true);
        }
    }

    [TestFixture()]
    public class OrderTest
    {
        #region :: Private Fields ::

        /// <summary>
        /// Api Key.
        /// </summary>
        private readonly string _apikey = "key_ZLy4aP2szht1HqzkCezDEA";

        /// <summary>
        /// Order data with checkout.
        /// </summary>
        private readonly string _orderDataWithCheckout;

        /// <summary>
        /// Order data with checkout and MSI.
        /// </summary>
        private readonly string _orderDataWithMSI;

        /// <summary>
        /// Order data with checkout and saved card.
        /// </summary>
        private readonly string _orderDataWithSavedCard;

        #endregion

        #region :: Constructor ::

        /// <summary>
        /// Creates an instance of OrderTest.
        /// </summary>
        public OrderTest()
        {
            var customerInfo = new
            {
                customer_id = "cus_2o8jK3TDtejmz1sYb"
            };

            var lineItems = new[]
            {
                new
                {
                    name = "Box of Cohiba S1s",
                    unit_price = 35000,
                    quantity = 1,
                }
            };

            var checkoutData = new
            {
                expired_at = (int)(DateTime.UtcNow
                    .AddSeconds(259200)
                    .Subtract(new DateTime(1970, 1, 1)))
                    .TotalSeconds,
                allowed_payment_methods = new string[] { "cash", "card", "bank_transfer" }
            };

            var checkoutDataMSI = new
            {
                expired_at = (int)(DateTime.UtcNow
                    .AddSeconds(259200)
                    .Subtract(new DateTime(1970, 1, 1)))
                    .TotalSeconds,
                allowed_payment_methods = new string[] { "cash", "card", "bank_transfer" },
                monthly_installments_enabled = true,
                monthly_installments_options = new int[] { 3, 6, 12 },
            };

            var checkoutDataSaveCard = new
            {
                expired_at = (int)(DateTime.UtcNow
                    .AddSeconds(259200)
                    .Subtract(new DateTime(1970, 1, 1)))
                    .TotalSeconds,
                allowed_payment_methods = new string[] { "cash", "card", "bank_transfer" },
                on_demand_enabled = true
            };

            var orderDataWithCheckout = new
            {
                currency = "MXN",
                line_items = lineItems,
                metadata = new
                {
                    test = true
                },
                checkout = checkoutData,
                customer_info = customerInfo
            };

            var orderDataWithMSI = new
            {
                currency = "MXN",
                line_items = lineItems,
                metadata = new
                {
                    test = true
                },
                checkout = checkoutDataMSI,
                customer_info = customerInfo
            };

            var orderDataWithSavedCard = new
            {
                currency = "MXN",
                line_items = lineItems,
                metadata = new
                {
                    test = true
                },
                checkout = checkoutDataSaveCard,
                customer_info = customerInfo
            };

            _orderDataWithCheckout = JsonConvert.SerializeObject(orderDataWithCheckout);
            _orderDataWithMSI = JsonConvert.SerializeObject(orderDataWithMSI);
            _orderDataWithSavedCard = JsonConvert.SerializeObject(orderDataWithSavedCard);
        }

        #endregion

        #region :: Checkout components ::

        /// <summary>
        /// Successful order create.
        /// </summary>
        [Test()]
        public void Successful_Order_Create_Test_OK()
        {
            Api.version = "2.0.0";
            Api.apiKey = _apikey;

            var order = new Order().create(_orderDataWithCheckout);

            Assert.AreEqual(typeof(Checkout), order.checkout.GetType());
            Assert.AreEqual(false, string.IsNullOrEmpty(order.checkout.id));
            Assert.AreEqual("Integration", order.checkout.type);
            Assert.AreEqual(false, order.checkout.monthly_installments_enabled);
        }

        /// <summary>
        /// With checkout components monthly installments create.
        /// </summary>
        [Test()]
        public void With_Checkout_Components_Monthly_Installments_Create_Test_OK()
        {
            Api.version = "2.0.0";
            Api.apiKey = _apikey;

            var order = new Order().create(_orderDataWithMSI);

            Assert.AreEqual(typeof(Checkout), order.checkout.GetType());
            Assert.AreEqual(false, string.IsNullOrEmpty(order.checkout.id));
            Assert.AreEqual("Integration", order.checkout.type);
            Assert.AreEqual(true, order.checkout.monthly_installments_enabled);
        }

        /// <summary>
        /// With checkout components save card create.
        /// </summary>
        [Test()]
        public void With_Checkout_Components_Save_Card_Create_Test_OK()
        {
            Api.version = "2.0.0";
            Api.apiKey = _apikey;

            var order = new Order().create(_orderDataWithSavedCard);

            Assert.AreEqual(typeof(Checkout), order.checkout.GetType());
            Assert.AreEqual(false, string.IsNullOrEmpty(order.checkout.id));
            Assert.AreEqual("Integration", order.checkout.type);
            Assert.AreEqual(true, order.checkout.on_demand_enabled);
        }

        #endregion

        public void getApiKey()
        {
            Api.apiKey = "key_ZLy4aP2szht1HqzkCezDEA";
        }
        private int RandomNumber(int min, int max, int seed = 0)
        {
            Random random = new Random((int)DateTime.Now.Ticks + seed);
            return random.Next(min, max);
        }

        [Test()]
        public void apiVersionUnsupported()
        {
            getApiKey();
            conekta.Api.version = "0.3.0";

            try
            {
                new conekta.Order().create(@"{
                    ""currency"":""MXN"",
                    ""customer_info"": {
                    ""name"": ""Jul Ceballos"",
                    ""phone"": ""+5215555555555"",
                    ""email"": ""jul@conekta.io""
                    }
                    }");
            }
            catch (ConektaException e)
            {
                Assert.AreEqual(e._object, "error");
                Assert.AreEqual(e._type, "api_version_unsupported");
            }
        }

        [Test()]
        public void createCard()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }],
                  ""charges"": [{
                  ""payment_method"": {
                  ""type"": ""card"",
                  ""token_id"": ""tok_test_visa_4242""
                  }
                  }],
                  ""metadata"": {
                  ""yes"": ""nou""
                  }
            }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            Assert.AreEqual(order.payment_status, "paid");
            Assert.AreEqual(order.amount, 35000);

            Charge charge = (Charge)order.charges.at(0);
            Assert.AreEqual(charge.payment_method.brand, "visa");

            order = new Order().find(order.id);

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            Assert.AreEqual(order.payment_status, "paid");
            Assert.AreEqual(order.amount, 35000);

            order = order.createReturn(@"{""amount"": 35000}");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            Assert.AreEqual(order.payment_status, "refunded");
            Assert.AreEqual(order.amount, 35000);

            Order[] orders = new Order().where(new JObject());
            Assert.AreEqual(orders[0].id.GetType().ToString(), "System.String");

        }

        [Test()]
        public void createCharge()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                      ""currency"":""MXN"",
                      ""customer_info"": {
                      ""name"": ""Jul Ceballos"",
                      ""phone"": ""+5215555555555"",
                      ""email"": ""jul@conekta.io""
                      },
                      ""line_items"": [{
                      ""name"": ""Box of Cohiba S1s"",
                      ""unit_price"": 35000,
                      ""quantity"": 1
                      }]
                      }");

            order.createCharge(@"{
                    ""payment_method"": {
                    ""type"": ""card"",
                    ""token_id"": ""tok_test_visa_4242""
                    },
                    ""amount"": 35000
                    }");

            order = new Order().find(order.id);

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            Assert.AreEqual(order.payment_status, "paid");
            Assert.AreEqual(order.amount, 35000);

            order = new Order().find(order.id);

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            Assert.AreEqual(order.payment_status, "paid");
            Assert.AreEqual(order.amount, 35000);

            order = order.createReturn(@"{""amount"": 35000}");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            Assert.AreEqual(order.payment_status, "refunded");
            Assert.AreEqual(order.amount, 35000);

            Order[] orders = new Order().where(new JObject());
            Assert.AreEqual(orders[0].id.GetType().ToString(), "System.String");
        }


        [Test()]
        public void captureCharge()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }],
                  ""pre_authorize"": true
                  }");

            order.createCharge(@"{
                ""payment_method"": {
                ""type"": ""card"",
                ""token_id"": ""tok_test_visa_4242""
                },
                ""amount"": 35000
                }");

            order = new Order().find(order.id);

            order = order.capture();

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            Assert.AreEqual(order.payment_status, "paid");
            Assert.AreEqual(order.amount, 35000);
        }

        [Test()]
        public void createCardError()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            try
            {
                new conekta.Order().create(@"{
                    ""currency"":""MXN"",
                    ""customer_info"": {
                    ""name"": ""Jul Ceballos"",
                    ""phone"": ""+5215555555555"",
                    ""email"": ""jul@conekta.io""
                    }
                    }");
            }
            catch (ConektaException e)
            {
                Assert.AreEqual(e._object, "error");
                Assert.AreEqual(e._type, "parameter_validation_error");
            }
        }

        [Test()]
        public void CreateOxxo()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";


            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }],
                  ""charges"": [{
                  ""payment_method"": {
                  ""type"": ""oxxo_cash"",
                  ""expires_at"": 1553273553
                  },
                  ""amount"": 35000
                  }]
                  }");
            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            System.Console.WriteLine(order.payment_status);
            Assert.AreEqual(order.payment_status, "pending_payment");
            Assert.AreEqual(order.amount, 35000);
        }

        [Test()]
        public void update()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }]
                  }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            Assert.AreEqual(order.amount, 35000);

            order = new Order().find(order.id);

            order = order.update(@"{""currency"": ""USD""}");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");
            Assert.AreEqual(order.amount, 35000);
        }

        [Test()]
        public void createLineItem()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }]
                  }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");

            order = new Order().find(order.id);

            LineItem line_item = order.createLineItem(@"{
                ""name"": ""Box of Cohiba S1s"",
                ""unit_price"": 35000,
                ""quantity"": 1
                }");

            Assert.AreEqual(line_item.name, "Box of Cohiba S1s");
        }

        [Test()]
        public void updateLineItem()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }]
                  }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");

            order = new Order().find(order.id);

            LineItem line_item = (LineItem)order.line_items.at(0);

            //line_item = line_item.update(@"{
            //  ""name"": ""Box S1s"",
            //  ""unit_price"": 45000
            //}");

            //Assert.AreEqual(line_item.name, "Box S1s");

        }

        [Test()]
        public void createTaxLine()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }]
                  }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");

            order = new Order().find(order.id);

            TaxLine tax_line = order.createTaxLine(@"{
                ""description"": ""IVA"",
                ""amount"": 600,
                ""metadata"": {
                ""random_key"": ""random_value""
                }
                }");

            Assert.AreEqual(tax_line.description, "IVA");
            Assert.AreEqual(tax_line.amount, 600);
        }

        [Test()]
        public void updateTaxLine()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1,
                  ""metadata"": {
                  ""random_key"": ""random value""
                  }
                  }]
                  }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");

            order = new Order().find(order.id);

            TaxLine tax_line = order.createTaxLine(@"{
                ""description"": ""IVA"",
                ""amount"": 600,
                ""contextual_data"": {
                ""random_key"": ""random_value""
                }
                }");

            order = new Order().find(order.id);

            //tax_line = order.tax_lines.at(0).update(@"{
            //   ""description"": ""IVA"",
            //   ""amount"": 1000,
            //   ""contextual_data"": {
            //      ""random_key"": ""random_value""
            //   }
            //}");

            //System.Console.WriteLine(tax_line.amount);

            //Assert.AreEqual(tax_line.description, "IVA");
            //Assert.AreEqual(tax_line.amount, 1000);
        }

        [Test()]
        public void createShippingLine()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }]
                  }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");

            order = new Order().find(order.id);

            ShippingLine shipping_line = order.createShippingLine(@"{
                ""amount"": 0,
                ""tracking_number"": ""TRACK123"",
                ""carrier"": ""USPS"",
                ""method"": ""Train"",
                ""metadata"": {
                ""random_key"": ""random_value""
                }
                }");

            Assert.AreEqual(shipping_line.tracking_number, "TRACK123");
        }

        [Test()]
        public void updateShippingLine()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }]
                  }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");

            order = new Order().find(order.id);

            ShippingLine shipping_line = order.createShippingLine(@"{
                ""amount"": 0,
                ""tracking_number"": ""TRACK123"",
                ""carrier"": ""Fedex"",
                ""method"": ""Train"",
                ""contextual_data"": {
                ""random_key"": ""random_value""
                }
                }");

            order = new Order().find(order.id);

            shipping_line = (ShippingLine)order.shipping_lines.at(0);
            shipping_line = shipping_line.update(@"{
                ""carrier"": ""UPS""
                }");

            Assert.AreEqual(shipping_line.carrier, "UPS");
        }

        [Test()]
        public void createDiscountLine()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""+5215555555555"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }]
                  }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");

            order = new Order().find(order.id);

            DiscountLine discount_line = order.createDiscountLine(@"{
                ""code"": ""123"",
                ""type"": ""loyalty"",
                ""amount"": 600
                }");

            Assert.AreEqual(discount_line.code, "123");
            Assert.AreEqual(discount_line.type, "loyalty");
        }

        [Test()]
        public void updateDiscountLine()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Order order = new conekta.Order().create(@"{
                  ""currency"":""MXN"",
                  ""customer_info"": {
                  ""name"": ""Jul Ceballos"",
                  ""phone"": ""5575553324"",
                  ""email"": ""jul@conekta.io""
                  },
                  ""line_items"": [{
                  ""name"": ""Box of Cohiba S1s"",
                  ""unit_price"": 35000,
                  ""quantity"": 1
                  }]
                  }");

            Assert.AreEqual(order.id.GetType().ToString(), "System.String");

            order = new Order().find(order.id);

            DiscountLine discount_line = order.createDiscountLine(@"{
                ""code"": ""234"",
                ""type"": ""loyalty"",
                ""amount"": 600
                }");

            order = new Order().find(order.id);

            discount_line = (DiscountLine)order.discount_lines.at(0);
            discount_line = discount_line.update(@"{
                ""amount"": 700,
                ""code"": ""567"",
                ""type"": ""coupon""
                }");

            Assert.AreEqual(discount_line.type, "coupon");
            Assert.AreEqual(discount_line.code, "567");
            Assert.AreEqual(discount_line.amount, 700);
        }
    }

    [TestFixture()]
    public class CustomerTest
    {

        public static void getApiKey()
        {
            conekta.Api.apiKey = "key_ZLy4aP2szht1HqzkCezDEA";
        }

        [Test()]
        public void createCustomer()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""plan_id"": ""gold-plan"",
                  ""corporate"": true,
                  ""payment_sources"": [{
                  ""token_id"": ""tok_test_visa_4242"",
                  ""type"": ""card""
                  }],
                  ""shipping_contacts"": [{
                  ""phone"": ""+5215555555555"",
                  ""receiver"": ""Marvin Fuller"",
                  ""between_streets"": ""Ackerman Crescent"",
                  ""address"": {
                  ""street1"": ""250 Alexis St"",
                  ""street2"": ""fake street"",
                  ""city"": ""Red Deer"",
                  ""state"": ""Alberta"",
                  ""country"": ""CA"",
                  ""postal_code"": ""T4N 0B8"",

                  ""residential"": true
                  }

                  }],
                  ""antifraud_info"": {
                    ""account_age"": 300,
                    ""paid_transactions"": 5
                  }
            }");

            Assert.AreEqual(customer.corporate, true);

            customer = new Customer().find(customer.id);

            Assert.AreEqual(customer.corporate, true);
            Assert.IsNotNull(customer.created_at);
        }

        [Test()]
        public void updateCustomer()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""5575553322"",
                  ""email"": ""user@example.com"",
                  ""corporate"": true
                  }");

            Assert.AreEqual(customer.corporate, true);
            Assert.AreEqual(customer.name, "Emiliano Cabrera");

            customer = new Customer().find(customer.id);

            Assert.AreEqual(customer.corporate, true);
            Assert.AreEqual(customer.name, "Emiliano Cabrera");

            customer = customer.update(@"{
                ""corporate"": false,
                ""name"": ""Juan Perez""
                }");

            Assert.AreEqual(customer.name, "Juan Perez");
            Assert.AreEqual(customer.corporate, false);
        }

        [Test()]
        public void deleteCustomer()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""plan_id"": ""gold-plan"",
                  ""corporate"": true,
                  ""payment_sources"": [{
                  ""token_id"": ""tok_test_visa_4242"",
                  ""type"": ""card""
                  }]
                  }");

            Assert.AreEqual(customer.corporate, true);

            customer = new Customer().find(customer.id);

            Assert.AreEqual(customer.corporate, true);

            customer = customer.destroy();

            Assert.AreEqual(customer.corporate, true);
        }

        [Test()]
        public void createCustomerWithOfflineRecurrentReference()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""corporate"": true,
                  ""payment_sources"": [{
                    ""expires_at"": 1553273553,
                    ""type"": ""oxxo_recurrent""
                  }]
                  }");

            PaymentSource paymentSource = customer.payment_sources[0];
            OfflineRecurrentReference reference = paymentSource as OfflineRecurrentReference;

            Assert.IsNotNull(reference.reference);
            Assert.IsNotNull(reference.barcode);
            Assert.IsNotNull(reference.barcode_url);
            Assert.IsNotNull(reference.provider);
            Assert.AreEqual(reference.expires_at, "1553273553");
        }

        [Test()]
        public void createCustomerWithCard()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""plan_id"": ""gold-plan"",
                  ""corporate"": true,
                  ""payment_sources"": [{
                      ""token_id"": ""tok_test_visa_4242"",
                      ""type"": ""card""
                  }]
                  }");

            PaymentSource paymentSource = customer.payment_sources[0];

            Card card = paymentSource as Card;
            Assert.AreEqual(customer.corporate, true);

        }

        [Test()]
        public void createSubscription()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""corporate"": true,
                  ""payment_sources"": [{
                  ""token_id"": ""tok_test_visa_4242"",
                  ""type"": ""card""
                  }]
                  }");

            Subscription subscription = customer.createSubscription(@"{
                ""plan"": ""gold-plan""
                }");

            Assert.AreEqual(subscription.plan_id, "gold-plan");
        }

        [Test()]
        public void updateSubscription()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""corporate"": true,
                  ""payment_sources"": [{
                  ""token_id"": ""tok_test_visa_4242"",
                  ""type"": ""card""
                  }]
                  }");

            Subscription subscription = customer.createSubscription(@"{
                ""plan"": ""gold-plan""
                }");

            Assert.AreEqual(subscription.plan_id, "gold-plan");

            subscription = subscription.update(@"{
                ""plan"": ""opal-plan""
                }");

            Assert.AreEqual(subscription.plan_id, "opal-plan");
        }

        [Test()]
        public void statesSubscription()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""corporate"": true,
                  ""payment_sources"": [{
                  ""token_id"": ""tok_test_visa_4242"",
                  ""type"": ""card""
                  }]
                  }");

            Subscription subscription = customer.createSubscription(@"{
                ""plan"": ""gold-plan""
                }");

            Assert.AreEqual(subscription.status, "in_trial");

            subscription = subscription.pause();

            Assert.AreEqual(subscription.status, "paused");

            subscription = subscription.resume();

            Assert.AreEqual(subscription.status, "in_trial");

            subscription = subscription.cancel();

            Assert.AreEqual(subscription.status, "canceled");
        }

        [Test()]
        public void createCard()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""corporate"": true,
                  ""payment_sources"": []
                  }");

            Card card = (Card)customer.CreateCard(@"{
                ""token_id"": ""tok_test_visa_4242"",
                ""type"": ""card""
                }");

            Assert.AreEqual(card.type, "card");
            Assert.AreEqual(card.name, "Jorge Lopez");
        }

        [Test()]
        public void createOfflineRecurrentReference()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                      ""name"": ""Emiliano Cabrera"",
                      ""phone"": ""+5215544443333"",
                      ""email"": ""user@example.com"",
                      ""corporate"": true,
                      ""payment_sources"": []
                      }");

            OfflineRecurrentReference reference = (OfflineRecurrentReference)customer.CreateOfflineRecurrentReference(@"{
                    ""expires_at"": 1553273553,
                    ""type"": ""oxxo_recurrent""
                    }");

            Assert.IsNotNull(reference.reference);
            Assert.IsNotNull(reference.barcode);
            Assert.IsNotNull(reference.barcode_url);
            Assert.IsNotNull(reference.provider);
            Assert.AreEqual(reference.expires_at, "1553273553");
        }

        [Test()]
        public void updatePaymentSource()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""corporate"": true
                  }");

            Card payment_source = (Card)customer.CreateCard(@"{
                ""token_id"": ""tok_test_visa_4242"",
                ""type"": ""card""
                }");

            Card updatedPaymentSource = payment_source.Update(@"{
                ""name"": ""Emiliano Suarez""
                }");

            Assert.AreEqual(updatedPaymentSource.name, "Emiliano Suarez");
        }

        [Test()]
        public void deletePaymentSource()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com""
                  }");

            PaymentSource payment_source = customer.CreateCard(@"{
                ""token_id"": ""tok_test_visa_4242"",
                ""type"": ""card""
                }");

            payment_source.destroy();

            Customer customerReloaded = new Customer().find(customer.id);



            Assert.AreEqual(customerReloaded.payment_sources, null);
        }

        [Test()]
        public void createShippingContact()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""plan_id"": ""gold-plan"",
                  ""corporate"": true,
                  ""payment_sources"": [{
                  ""token_id"": ""tok_test_visa_4242"",
                  ""type"": ""card""
                  }],
                  ""shipping_contacts"": [{
                  ""email"": ""thomas.logan@xmen.org"",
                  ""phone"": ""+5215555555555"",
                  ""receiver"": ""Marvin Fuller"",
                  ""between_streets"": ""Ackerman Crescent"",
                  ""address"": {
                  ""street1"": ""250 Alexis St"",
                  ""street2"": ""fake street"",
                  ""city"": ""Red Deer"",
                  ""state"": ""Alberta"",
                  ""country"": ""CA"",
                  ""postal_code"": ""T4N 0B8"",
                  ""residential"": true
                  }
                  }],
                  ""account_age"": 300,
                  ""paid_transactions"": 5
            }");

            ShippingContact shipping_contact = customer.createShippingContact(@"{
                ""phone"": ""+5215555555555"",
                ""receiver"": ""Marvin Fuller"",
                ""between_streets"": ""Ackerman Crescent"",
                ""address"": {
                ""street1"": ""250 Alexis St"",
                ""street2"": ""fake street"",
                ""city"": ""Red Deer"",
                ""state"": ""Alberta"",
                ""country"": ""CA"",
                ""postal_code"": ""T4N 0B8"",
                ""residential"": true
                }
                }");

            Assert.AreEqual(shipping_contact.phone, "+5215555555555");
        }

        [Test()]
        public void updateShippingContact()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""5575553322"",
                  ""email"": ""user@example.com"",
                  ""corporate"": true
                  }");

            ShippingContact shipping_contact = customer.createShippingContact(@"{
                ""phone"": ""5575553322"",
                ""receiver"": ""Marvin Fuller"",
                ""between_streets"": ""Ackerman Crescent"",
                ""address"": {
                ""street1"": ""250 Alexis St"",
                ""street2"": ""fake street"",
                ""city"": ""Red Deer"",
                ""state"": ""Alberta"",
                ""country"": ""CA"",
                ""postal_code"": ""T4N 0B8"",
                ""residential"": true
                }
                }");

            shipping_contact = shipping_contact.update(@"{
                ""phone"": ""5575553324""
                }");

            Assert.AreEqual(shipping_contact.phone, "5575553324");
        }

        [Test()]
        public void deleteShippingContact()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";

            Customer customer = new conekta.Customer().create(@"{
                  ""name"": ""Emiliano Cabrera"",
                  ""phone"": ""+5215544443333"",
                  ""email"": ""user@example.com"",
                  ""corporate"": true
                  }");

            ShippingContact shipping_contact = customer.createShippingContact(@"{
                ""phone"": ""+5215555555555"",
                ""receiver"": ""Marvin Fuller"",
                ""between_streets"": ""Ackerman Crescent"",
                ""address"": {
                ""street1"": ""250 Alexis St"",
                ""street2"": ""fake street"",
                ""city"": ""Red Deer"",
                ""state"": ""Alberta"",
                ""country"": ""CA"",
                ""postal_code"": ""T4N 0B8"",
                ""residential"": true
                }
                }");

            Assert.AreEqual(shipping_contact.phone, "+5215555555555");

            shipping_contact = shipping_contact.update(@"{
                ""phone"": ""+5215555555555""
                }");

            Assert.AreEqual(shipping_contact.phone, "+5215555555555");

            shipping_contact = shipping_contact.destroy();

            Assert.AreEqual(shipping_contact.phone, "+5215555555555");
        }
    }

    [TestFixture()]
    public class EventTest
    {
        private TestContext testContextInstance;

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        public static void getApiKey()
        {
            conekta.Api.apiKey = "key_ZLy4aP2szht1HqzkCezDEA";
        }
        [Test()]
        public void EventList()
        {
            getApiKey();
            conekta.Api.version = "2.0.0";
            Event[] events = new Event().where(new JObject());


            Assert.AreEqual(events[0].webhook_status.GetType().ToString(), "System.String");
            Assert.AreEqual(events[0].created_at.GetType().ToString(), "System.String");
            Assert.AreEqual(events[0].livemode.GetType().ToString(), "System.String");
            Assert.AreEqual(events[0].id.GetType().ToString(), "System.String");
        }
    }

    [TestFixture()]
    public class ChargeTest
    {

        private int RandomNumber(int min, int max, int seed = 0)
        {
            Random random = new Random((int)DateTime.Now.Ticks + seed);
            return random.Next(min, max);
        }

        [Test()]
        public void Card()
        {
            conekta.Api.locale = "es";
            conekta.Api.apiKey = "key_eYvWV7gSDkNYXsmr";
            conekta.Api.version = "1.0.0";

            conekta.Charge charge = new conekta.Charge().create(@"{
                    ""description"":""Stogies"",
                    ""amount"": 20000,
                    ""currency"":""MXN"",
                    ""reference_id"":""9839-wolf_pack"",
                    ""card"": ""tok_test_visa_4242"",
                    ""details"": {
                      ""name"": ""Arnulfo Quimare"",
                      ""phone"": ""403-342-0642"",
                      ""email"": ""logan@x-men.org"",
                      ""customer"": {
                        ""logged_in"": true,
                        ""successful_purchases"": 14,
                        ""created_at"": 1379784950,
                        ""updated_at"": 1379784950,
                        ""offline_payments"": 4,
                        ""score"": 9
                      },
                      ""line_items"": [{
                        ""name"": ""Box of Cohiba S1s"",
                        ""description"": ""Imported From Mex."",
                        ""unit_price"": 20000,
                        ""quantity"": 1,
                        ""sku"": ""cohb_s1"",
                        ""category"": ""food""
                      }],
                      ""billing_address"": {
                        ""street1"":""77 Mystery Lane"",
                        ""street2"": ""Suite 124"",
                        ""street3"": null,
                        ""city"": ""Darlington"",
                        ""state"":""NJ"",
                        ""zip"": ""10192"",
                        ""country"": ""Mexico"",
                        ""tax_id"": ""xmn671212drx"",
                        ""company_name"":""X-Men Inc."",
                        ""phone"": ""77-777-7777"",
                        ""email"": ""purshasing@x-men.org""
                      }
                    },
              ""capture"": false
                  }");

            Assert.AreEqual(charge.payment_method.type, "credit");
            Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
            Assert.AreEqual(charge.amount, 20000);

            charge = new Charge().find(charge.id);

            Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
            Assert.AreEqual(charge.amount, 20000);

            charge = charge.capture();

            Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
            Assert.AreEqual(charge.amount, 20000);

            charge = charge.refund();

            Assert.AreEqual(charge.id.GetType().ToString(), "System.String");
            Assert.AreEqual(charge.amount, 20000);
        }


    }

    /// <summary>
    /// Checkout test.
    /// </summary>
    [TestFixture()]
    public class CheckoutTest
    {
        #region :: Private Fields ::

        /// <summary>
        /// Api Key.
        /// </summary>
        private readonly string _apiKey = "key_ZLy4aP2szht1HqzkCezDEA";

        /// <summary>
        /// Checkout data.
        /// </summary>
        private readonly string _checkoutData;

        /// <summary>
        /// Checkout invalid expired at.
        /// </summary>
        private readonly string _checkoutInvalidExpiredAt;

        /// <summary>
        /// Checkout with MSI.
        /// </summary>
        private readonly string _checkoutDataWithMSI;

        /// <summary>
        /// Checkout with recurrent.
        /// </summary>
        private readonly string _checkoutDataRecurrent;

        #endregion

        #region :: Constructor ::

        /// <summary>
        /// Creates an instance of CheckoutTest.
        /// </summary>
        public CheckoutTest()
        {
            Api.version = "2.0.0";
            Api.apiKey = _apiKey;

            var customerInfo = new
            {
                name = "John Constantine",
                phone = "4493424352",
                email = "hola@hola.com"
            };

            var lineItems = new[]
            {
                new
                {
                    name = "Box of Cohiba S1s",
                    unit_price = 35000,
                    quantity = 1,
                }
            };

            var orderTemplate = new
            {
                currency = "MXN",
                line_items = lineItems,
                customer_info = customerInfo,
                metadata = new
                {
                    mycustomkey = "12345",
                    othercustomkey = "abcde",
                }
            };

            var orderTemplateNoCustomer = new
            {
                currency = "MXN",
                line_items = lineItems,
                metadata = new
                {
                    mycustomkey = "12345",
                    othercustomkey = "abcde",
                }
            };

            var checkoutData = new
            {
                name = "Payment Link Name",
                type = "PaymentLink",
                recurrent = false,
                expired_at = (int)(DateTime.UtcNow
                    .AddSeconds(259200)
                    .Subtract(new DateTime(1970, 1, 1)))
                    .TotalSeconds,
                allowed_payment_methods = new string[] { "cash", "card", "bank_transfer" },
                needs_shipping_contact = false,
                order_template = orderTemplate
            };

            var checkoutInvalidExpiredAt = new
            {
                name = "Payment Link Name",
                type = "PaymentLink",
                recurrent = false,
                expired_at = (int)(DateTime.UtcNow
                    .AddSeconds(3600)
                    .Subtract(new DateTime(1970, 1, 1)))
                    .TotalSeconds,
                allowed_payment_methods = new string[] { "cash", "card", "bank_transfer" },
                needs_shipping_contact = false,
                order_template = orderTemplate
            };

            var checkoutDataWithMSI = new
            {
                name = "Payment Link Name",
                type = "PaymentLink",
                recurrent = false,
                expired_at = (int)(DateTime.UtcNow
                    .AddSeconds(259200)
                    .Subtract(new DateTime(1970, 1, 1)))
                    .TotalSeconds,
                allowed_payment_methods = new string[] { "cash", "card", "bank_transfer" },
                needs_shipping_contact = false,
                monthly_installments_enabled = true,
                monthly_installments_options = new int[] { 3, 6, 12 },
                order_template = orderTemplate
            };

            var checkoutDataRecurrent = new
            {
                name = "Payment Link Name",
                type = "PaymentLink",
                recurrent = true,
                payments_limit_count = 10,
                expired_at = (int)(DateTime.UtcNow
                    .AddSeconds(259200)
                    .Subtract(new DateTime(1970, 1, 1)))
                    .TotalSeconds,
                allowed_payment_methods = new string[] { "cash", "card", "bank_transfer" },
                needs_shipping_contact = false,
                order_template = orderTemplateNoCustomer
            };

            _checkoutData = JsonConvert.SerializeObject(checkoutData);
            _checkoutInvalidExpiredAt = JsonConvert.SerializeObject(checkoutInvalidExpiredAt);
            _checkoutDataWithMSI = JsonConvert.SerializeObject(checkoutDataWithMSI);
            _checkoutDataRecurrent = JsonConvert.SerializeObject(checkoutDataRecurrent);
        }

        #endregion

        #region :: Methods ::

        #region :: Creating payment link ::

        /// <summary>
        /// Creating payment link.
        /// </summary>
        [Test()]
        public void Creating_Payment_Link_Test_OK()
        {
            var checkout = new Checkout().create(_checkoutData);

            Assert.AreEqual(false, string.IsNullOrEmpty(checkout.id));
            Assert.AreEqual("checkout", checkout._object);
            Assert.AreEqual(36, checkout.id.ToString().Length);
            Assert.AreEqual("PaymentLink", checkout.type);
            Assert.AreEqual(false, checkout.livemode);
            Assert.AreEqual(false, checkout.needs_shipping_contact);
            Assert.AreEqual(false, checkout.monthly_installments_enabled);
            Assert.AreEqual(false, string.IsNullOrEmpty(checkout.slug));
            Assert.AreEqual(false, string.IsNullOrEmpty(checkout.url));
        }

        /// <summary>
        /// Unsuccessful checkout create.
        /// </summary>
        [Test()]
        public void Unsuccessful_Checkout_Create_Test_OK()
        {
            Assert.Throws<ConektaException>(() =>
            {
                var checkout = new Checkout().create(string.Empty);
            });
        }

        /// <summary>
        /// Unsuccessful checkout expired at create.
        /// </summary>
        [Test()]
        public void Unsuccessful_Checkout_Expired_At_Create_Test_OK()
        {
            Assert.Throws<ConektaException>(() =>
            {
                var checkout = new Checkout().create(_checkoutInvalidExpiredAt);
            });
        }

        /// <summary>
        /// Successful with monthly installments enabled.
        /// </summary>
        [Test()]
        public void Successful_With_Monthly_Installments_Enabled_Test_OK()
        {
            var checkout = new Checkout().create(_checkoutDataWithMSI);

            Assert.AreEqual(false, string.IsNullOrEmpty(checkout.id));
            Assert.AreEqual("checkout", checkout._object);
            Assert.AreEqual(36, checkout.id.ToString().Length);
            Assert.AreEqual("PaymentLink", checkout.type);
            Assert.AreEqual(false, checkout.livemode);
            Assert.AreEqual(false, checkout.needs_shipping_contact);
            Assert.AreEqual(true, checkout.monthly_installments_enabled);
            Assert.AreEqual(3, checkout.monthly_installments_options.Length);
            Assert.AreEqual(false, string.IsNullOrEmpty(checkout.slug));
            Assert.AreEqual(false, string.IsNullOrEmpty(checkout.url));

        }

        /// <summary>
        /// Successful with recurrent.
        /// </summary>
        [Test()]
        public void Successful_With_Recurrent_Test_OK()
        {
            var checkout = new Checkout().create(_checkoutDataRecurrent);

            Assert.AreEqual(false, string.IsNullOrEmpty(checkout.id));
            Assert.AreEqual("checkout", checkout._object);
            Assert.AreEqual(36, checkout.id.ToString().Length);
            Assert.AreEqual("PaymentLink", checkout.type);
            Assert.AreEqual(false, checkout.livemode);
            Assert.AreEqual(false, checkout.needs_shipping_contact);
            Assert.AreEqual(true, checkout.recurrent);
            Assert.AreEqual(10, checkout.payments_limit_count);
            Assert.AreEqual(false, string.IsNullOrEmpty(checkout.slug));
            Assert.AreEqual(false, string.IsNullOrEmpty(checkout.url));
        }

        #endregion

        #region :: Get ::

        /// <summary>
        /// Successfully gets checkout.
        /// </summary>
        [Test()]
        public void Successfully_Gets_Checkout_Test_OK()
        {
            var id = new Checkout().create(_checkoutData).id;

            var checkout = new Checkout().find(id);

            Assert.AreEqual("checkout", checkout._object);
            Assert.AreEqual("PaymentLink", checkout.type);
        }

        /// <summary>
        /// Successful checkout where.
        /// </summary>
        [Test()]
        public void Successful_Checkout_Where_Test_OK()
        {
            Checkout[] checkouts = new Checkout().where(new JObject());

            Assert.AreEqual(typeof(Checkout[]), checkouts.GetType());
            Assert.AreEqual("checkout", checkouts.FirstOrDefault()._object);
            Assert.AreEqual("PaymentLink", checkouts.FirstOrDefault().type);
        }

        #endregion

        #region :: Notifications with payment link ::

        /// <summary>
        /// Unsuccessful send a checkout sms.
        /// </summary>
        [Test()]
        public void Unsuccessful_Send_A_Checkout_Sms_Test_OK()
        {
            Assert.Throws<ConektaException>(() =>
            {
                var checkout = new Checkout().create(_checkoutData);

                var parameters = new
                {
                    phone = "5555555555"
                };

                Assert.AreEqual(0, checkout.sms_sent);

                checkout.send_sms(JsonConvert.SerializeObject(parameters));
            });
        }

        /// <summary>
        /// Successfully send a checkout email.
        /// </summary>
        [Test()]
        public void Successfully_Send_A_Checkout_Email_Test_OK()
        {
            var checkout = new Checkout().create(_checkoutData);

            var parameters = new
            {
                email = "test@mail.com"
            };

            Assert.AreEqual(0, checkout.emails_sent);

            checkout.send_email(JsonConvert.SerializeObject(parameters));

            var checkoutFound = new Checkout().find(checkout.id);

            Assert.AreEqual(1, checkoutFound.emails_sent);
        }

        #endregion

        #region :: Cancel checkout request ::

        /// <summary>
        /// Successful cancel a checkout.
        /// </summary>
        [Test()]
        public void Successful_Cancel_A_Checkout_Test_OK()
        {
            var checkout = new Checkout().create(_checkoutData);

            Assert.AreEqual("Issued", checkout.status);

            var parameters = new
            {
                checkout.id
            };

            checkout.cancel(JsonConvert.SerializeObject(parameters));

            var checkoutFound = new Checkout().find(checkout.id);

            Assert.AreEqual("Cancelled", checkoutFound.status);
        }

        #endregion

        #endregion
    }
}
