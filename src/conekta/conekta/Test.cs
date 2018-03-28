    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    using conekta;

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
            public static void getApiKey()
            {
                conekta.Api.apiKey = "key_ZLy4aP2szht1HqzkCezDEA";
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
                conekta.Api.version = "1.0.0";

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

                OfflineRecurrentReference reference = (OfflineRecurrentReference) customer.CreateOfflineRecurrentReference(@"{
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
    }
