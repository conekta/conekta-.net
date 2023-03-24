![NET api](https://github.com/conekta/conekta-.net/blob/master/readme_cover.png?raw=true)
# Conekta .NET API Library
[![nuget](https://img.shields.io/nuget/v/Conekta.net.svg)](https://www.nuget.org/packages/Conekta.net/) [![nuget](https://img.shields.io/nuget/dt/Conekta.net.svg)](https://www.nuget.org/packages/Conekta.net/)[![dotnet CI](https://github.com/conekta/conekta-.net/actions/workflows/dotnet.yml/badge.svg)](https://github.com/conekta/conekta-.net/actions/workflows/dotnet.yml) 

This is the officially supported .NET library for using Conekta's APIs.
## Supported API versions
The library supports all APIs under the following services:

| API                                                                                         | Description | Service Name | Supported version |
|---------------------------------------------------------------------------------------------| ----------- |-------|-------------------|
| [Payments API](https://developers.conekta.com/reference)                  | Our classic integration for online payments. Current supported version | Payments API | **v2.1.0**        |

For more information, refer to our [documentation](https://developers.conekta.com/docs).

## Prerequisites
- [Conekta account](https://panel.conekta.com/)
- [API key](https://developers.conekta.com/docs/como-obtener-tus-api-keys).  your API credential .
- Conekta dotnet API Library supports .net standard 2.0 and above

## Installation
Simply download and restore nuget packages https://www.nuget.org/packages/Conekta.net/
or install it from package manager
```
PM> Install-Package Conekta.net -Version x.x.x
```
## Using the library

In order to submit http request to Conekta API you need to initialize the client. The following example makes a order request:
```c#

// Create a OrderRequest
using System;
using System.Collections.Generic;
using Conekta.net.Client;
using Conekta.net.Api;
using Conekta.net.Model;

// create the http client


Configuration configuration = new()
{
    AccessToken = "Your merchant XAPI key"
};
var ordersApi = new OrdersApi(configuration);

// Create a OrderRequest
string acceptLanguage = "en";
var lineItems = new List<LineItems>{new (
        name: "toshiba",
        quantity: 1,
        unitPrice: 1555
    )};
var charges = new List<ChargeRequest>{new (
    amount: 1555,
    paymentMethod: new ChargeRequestPaymentMethod("cash")
)};
var customerInfo = new OrderRequestCustomerInfo(new CustomerInfoJustCustomerId("cus_2tKcHxhTz7xU5SymF"));
OrderRequest orderRequest = new OrderRequest(
    currency: "MXN",
    customerInfo: customerInfo,
    lineItems: lineItems,
    charges: charges
);
            
//Make the call to the service. This example code makes a call to /orders
OrderResponse response = ordersApi.CreateOrder(orderRequest, acceptLanguage);
```

## Running the tests
Navigate to conekta-.net folder and run the following commands.
```
dotnet build
dotnet test
```

## Contributing
We encourage you to contribute to this repository, so everyone can benefit from new features, bug fixes, and any other improvements.
Have a look at our [contributing guidelines](https://github.com/conekta/conekta-.net/blob/main/CONTRIBUTING.md) to find out how to raise a pull request.

## Support
If you have a feature request, or spotted a bug or a technical problem, [create an issue here](https://github.com/conekta/conekta-.net/issues/choose).

For other questions, [contact our Support Team](https://developers.conekta.com/discuss).

## Licence
This repository is available under the [MIT license](https://github.com/conekta/conekta-.net/blob/master/LICENSE).

## See also
* [Conekta docs](https://developers.conekta.com/docs)
