
![alt tag](https://raw.github.com/conekta/conekta-.net/master/readme_files/cover.png)

# Conekta .NET v.1

This is a .net library that allows interaction with https://api.conekta.io API.

## Installation

Obtain the latest version of the Conekta .NET bindings with:

    git clone https://github.com/conekta/conekta-.net

To get started, add the following to your .NET script:

    using conekta;


## Usage

    conekta.Charge charge = new conekta.Charge ().create(@"{
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
      }
    }");
    
    // Handling Errors
    
    try {
        conekta.Charge charge = new conekta.Charge ().create(@"{
          ""description"":""Stogies"",
          ""amount"": 20000,
          ""currency"":""MXN"",
          ""reference_id"":""9839-wolf_pack"",
          ""card"": ""tok_test_visa_4242"",
        }");
    } catch (ConektaException e) {
        System.Console.WriteLine(e);
        /* ConektaException has attributes:
         * Message
         * message_to_purchaser
         * _type
         * message
         */
    }

## Documentation

Please see https://www.conekta.io/docs/api for up-to-date documentation.


License
-------
Developed by [Conekta](https://www.conekta.io). Available with [MIT License](LICENSE).

We are hiring
-------------

If you are a comfortable working with a range of backend languages (Java, Python, Ruby, PHP, ASP.NET, etc) and frameworks, you have solid foundation in data structures, algorithms and software design with strong analytical and debugging skills. 
Send your CV, github to quieroser@conekta.io
