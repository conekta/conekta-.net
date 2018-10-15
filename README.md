![README Cover Image](readme_cover.png)

<div align="center">

# Conekta .NET 1.0.2

[![Made with .NET](https://img.shields.io/badge/made%20with-.net-red.svg?style=for-the-badge&colorA=ED4040&colorB=C12C2D)](https://www.microsoft.com/net) [![By Conekta](https://img.shields.io/badge/by-conekta-red.svg?style=for-the-badge&colorA=ee6130&colorB=00a4ac)](https://conekta.com)
</div>

This is a .net library that allows interaction with https://api.conekta.io API.

## Installation

Obtain the latest version of the Conekta .NET bindings with:

    git clone https://github.com/conekta/conekta-.net

The last version works with API 2.0, if you are using API 1.0, obtain the target release with:

https://github.com/conekta/conekta-.net/releases/tag/1.0.1

To get started, add the following to your .NET script:

```csharp
using conekta;
```


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
Conekta.Order.createCharge(string) : Conekta.Charge
Conekta.Order.createLineItem(string) : Conekta.Lineitem
Conekta.Lineitem.update(string) : Conekta.Lineitem
Conekta.Order.createTaxLine(string) : Conekta.TaxLine
Conekta.TaxLine.update(string) : Conekta.TaxLine
Conekta.Order.createShippingLine(string) : Conekta.ShippingLine
Conekta.ShippingLine.update(string) : Conekta.ShippingLine
Conekta.Order.createDiscountLine(string) : Conekta.DiscountLine
Conekta.DiscountLine.update(string) : Conekta.DiscountLine
Conekta.Customer.create(string) : Conekta.Customer
Conekta.Customer.update(string) : Conekta.Customer
Conekta.Customer.find(string) : Conekta.Customer
Conekta.Customer.where(string) : Conekta.Customer[]
Conekta.Customer.createSource(string) : Conekta.Source
Conekta.Source.update(string) : Conekta.Source
Conekta.Customer.createShippingContact(string) : Conekta.ShippingContact
Conekta.ShippingContact.update(string) : Conekta.ShippingContact
Conekta.Customer.createFiscalEntity(string) : Conekta.FiscalEntity
Conekta.FiscalEntity.update(string) : Conekta.FiscalEntity
```

## Documentation

Please see https://developers.conekta.com/api for up-to-date documentation.

## License

Developed in Mexico by [Conekta](https://www.conekta.com). Available with [MIT License](LICENSE).

***

## How to contribute to the project

1. Fork the repository
 
2. Clone the repository
```
    git clone git@github.com:yourUserName/conekta-.net.git
```
3. Create a branch
```
    git checkout develop
    git pull origin develop
    # You should choose the name of your branch
    git checkout -b <feature/my_branch>
```    
4. Make necessary changes and commit those changes
```
    git add .
    git commit -m "my changes"
```
5. Push changes to GitHub
```
    git push origin <feature/my_branch>
```
6. Submit your changes for review, create a pull request

   To create a pull request, you need to have made your code changes on a separate branch. This branch should be named like this: **feature/my_feature** or **fix/my_fix**.

   Make sure that, if you add new features to our library, be sure that corresponding **unit tests** are added.

   If you go to your repository on GitHub, you’ll see a Compare & pull request button. Click on that button.

***

## We are always hiring!

If you are a comfortable working with a range of backend languages (Java, Python, Ruby, PHP, etc) and frameworks, you have solid foundation in data structures, algorithms and software design with strong analytical and debugging skills, check our open positions: https://www.conekta.com/careers
