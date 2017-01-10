
![alt tag](https://raw.github.com/conekta/conekta-.net/master/readme_files/cover.png)

# Conekta .NET v.1

This is a .net library that allows interaction with https://api.conekta.io API.

## Installation

Obtain the latest version of the Conekta .NET bindings with:

    git clone https://github.com/conekta/conekta-.net

The last version works with API 1.1, if you are using API 1.0, obtain the target release with:

    https://github.com/conekta/conekta-.net/archive/3.0-stable.zip

To get started, add the following to your .NET script:

    using conekta;


## Usage

```csharp
    Order order = new conekta.Order().create(@"{
      ""currency"":""MXN"",
      ""customer_info"": {
        ""name"": ""Jul Ceballos"",
        ""phone"": ""+5215555555555"",
        ""email"": ""jul@conekta.io""
      },
            ""line_items"": [{
              ""name"": ""Box of Cohiba S1s"",
              ""description"": ""Imported From Mex."",
              ""unit_price"": 35000,
              ""quantity"": 1,
              ""tags"": [""food"", ""mexican food""],
              ""type"": ""physical""
            }],
      ""charges"": [{
        ""source"": {
          ""type"": ""card"",
          ""token_id"": ""tok_test_visa_4242""
        }
      }]
    }");
    
    // Handling Errors
    
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
```

## Endpoints

```
Conekta.Order.create(string) : Conekta.Order
Conekta.Order.update(string) : Conekta.Order
Conekta.Order.find(string) : Conekta.Order
Conekta.Order.where(string) : Conekta.Order[]
Conekta.Order.createLineItem(string) : Conekta.Lineitem
Conekta.Lineitem.update : Conekta.Lineitem
Conekta.Order.createTaxLine(string) : Conekta.TaxLine
Conekta.TaxLine.update : Conekta.TaxLine
Conekta.Order.createShippingLine(hash) : Conekta.ShippingLine
Conekta.ShippingLine.update : Conekta.ShippingLine
Conekta.Order.createDiscountLine(hash) : Conekta.DiscountLine
Conekta.DiscountLine.update : Conekta.DiscountLine
Conekta.Customer.create(hash) : Conekta.Customer
Conekta.Customer.update(hash) : Conekta.Customer
Conekta.Customer.find(hash) : Conekta.Customer
Conekta.Customer.where(hash) : Conekta.Customer[]
Conekta.Customer.destroy(hash) : Conekta.Customer
Conekta.Customer.createSource(hash) : Conekta.Source
Conekta.Source.update : Conekta.Source
Conekta.Customer.createShippingContact(hash) : Conekta.ShippingContact
Conekta.ShippingContact.update : Conekta.ShippingContact
Conekta.Customer.createFiscalEntity(hash) : Conekta.FiscalEntity
Conekta.FiscalEntity.update : Conekta.FiscalEntity
```

## Documentation

Please see https://www.conekta.io/docs/api-v1_1 for up-to-date documentation.


License
-------
Developed by [Conekta](https://www.conekta.io). Available with [MIT License](LICENSE).

We are hiring
-------------

If you are a comfortable working with a range of backend languages (Java, Python, Ruby, PHP, ASP.NET, etc) and frameworks, you have solid foundation in data structures, algorithms and software design with strong analytical and debugging skills. 
Send your CV, github to quieroser@conekta.io
