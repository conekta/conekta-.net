
![alt tag](https://raw.github.com/conekta/conekta-.net/master/readme_files/cover.png)

# Conekta .NET v.1

This is a .net library that allows interaction with https://api.conekta.io API.

## Installation

Obtain the latest version of the Conekta .NET bindings with:

    git clone https://github.com/conekta/conekta-.net

To get started, add the following to your .NET script:

    using conekta;


## Usage

    conekta.Order order = new conekta.Order ().create(@"{
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
    
    try {
        new conekta.Order().create(@"{
            ""currency"":""MXN"",
            ""customer_info"": {
                ""name"": ""Jul Ceballos"",
                ""phone"": ""+5215555555555"",
                ""email"": ""jul@conekta.io""
            }
        }");
    } catch (ConektaException e) {
        System.Console.WriteLine(e);
        /* ConektaException has attributes:
         * Message
         * details
         * _object
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
