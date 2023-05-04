# Changelog

## 6.0.0 - 2023-05-04
* [#55](https://github.com/conekta/conekta-.net/pull/55) Generate sdk based on Openapi.
  * Add support for *AntifraudApi* | [**create_rule_blacklist**](docs/AntifraudApi.md#create_rule_blacklist) | **POST** /antifraud/blacklists | Create blacklisted rule
  * Add support for *AntifraudApi* | [**create_rule_whitelist**](docs/AntifraudApi.md#create_rule_whitelist) | **POST** /antifraud/whitelists | Create whitelisted rule
  * Add support for *AntifraudApi* | [**delete_rule_blacklist**](docs/AntifraudApi.md#delete_rule_blacklist) | **DELETE** /antifraud/blacklists/{id} | Delete blacklisted rule
  * Add support for *AntifraudApi* | [**delete_rule_whitelist**](docs/AntifraudApi.md#delete_rule_whitelist) | **DELETE** /antifraud/whitelists/{id} | Delete whitelisted rule
  * Add support for *AntifraudApi* | [**get_rule_blacklist**](docs/AntifraudApi.md#get_rule_blacklist)       | **GET** /antifraud/blacklists | Get list of blacklisted rules
  * Add support for *AntifraudApi* | [**get_rule_whitelist**](docs/AntifraudApi.md#get_rule_whitelist)       | **GET** /antifraud/whitelists | Get a list of whitelisted rules
  * Add support for *ChargesApi*   | [**orders_create_charge**](docs/ChargesApi.md#orders_create_charge)     | **POST** /orders/{id}/charges | Create charge
  * Add support for *CompaniesApi* | [**get_companies**](docs/CompaniesApi.md#get_companies) | **GET** /companies | Get List of Companies
  * Add support for *CompaniesApi* | [**get_company**](docs/CompaniesApi.md#get_company) | **GET** /companies/{id} | Get Company
  * Add support for *CustomersApi* | [**create_customer**](docs/CustomersApi.md#create_customer) | **POST** /customers | Create customer
  * Add support for *CustomersApi* | [**create_customer_fiscal_entities**](docs/CustomersApi.md#create_customer_fiscal_entities) | **POST** /customers/{id}/fiscal_entities | Create Fiscal Entity
  * Add support for *CustomersApi* | [**delete_customer_by_id**](docs/CustomersApi.md#delete_customer_by_id) | **DELETE** /customers/{id} | Delete Customer
  * Add support for *CustomersApi* | [**get_customer_by_id**](docs/CustomersApi.md#get_customer_by_id) | **GET** /customers/{id} | Get Customer
  * Add support for *CustomersApi* | [**get_customers**](docs/CustomersApi.md#get_customers) | **GET** /customers | Get a list of customers
  * Add support for *CustomersApi* | [**update_customer**](docs/CustomersApi.md#update_customer) | **PUT** /customers/{id} | Update customer
  * Add support for *CustomersApi* | [**update_customer_fiscal_entities**](docs/CustomersApi.md#update_customer_fiscal_entities) | **PUT** /customers/{id}/fiscal_entities/{fiscal_entities_id} | Update  Fiscal Entity
  * Add support for *DiscountsApi* | [**orders_create_discount_line**](docs/DiscountsApi.md#orders_create_discount_line) | **POST** /orders/{id}/discount_lines | Create Discount
  * Add support for *DiscountsApi* | [**orders_delete_discount_lines**](docs/DiscountsApi.md#orders_delete_discount_lines) | **DELETE** /orders/{id}/discount_lines/{discount_lines_id} | Delete Discount
  * Add support for *DiscountsApi* | [**orders_update_discount_lines**](docs/DiscountsApi.md#orders_update_discount_lines) | **PUT** /orders/{id}/discount_lines/{discount_lines_id} | Update Discount
  * Add support for *EventsApi*    | [**get_event**](docs/EventsApi.md#get_event) | **GET** /events/{id} | Get Event
  * Add support for *EventsApi*    | [**get_events**](docs/EventsApi.md#get_events) | **GET** /events | Get list of Events
  * Add support for *LogsApi* | [**get_log_by_id**](docs/LogsApi.md#get_log_by_id) | **GET** /logs/{id} | Get Log
  * Add support for *LogsApi* | [**get_logs**](docs/LogsApi.md#get_logs) | **GET** /logs | Get List Of Logs
  * Add support for *OrdersApi* | [**create_order**](docs/OrdersApi.md#create_order) | **POST** /orders | Create order
  * Add support for *OrdersApi* | [**get_order_by_id**](docs/OrdersApi.md#get_order_by_id) | **GET** /orders/{id} | Get Order
  * Add support for *OrdersApi* | [**get_orders**](docs/OrdersApi.md#get_orders) | **GET** /orders | Get a list of Orders
  * Add support for *OrdersApi* | [**order_refund**](docs/OrdersApi.md#order_refund) | **POST** /orders/{id}/refunds | Refund Order
  * Add support for *OrdersApi* | [**orders_create_capture**](docs/OrdersApi.md#orders_create_capture) | **POST** /orders/{id}/capture | Capture Order
  * Add support for *OrdersApi* | [**update_order**](docs/OrdersApi.md#update_order) | **PUT** /orders/{id} | Update Order
  * Add support for *PaymentLinkApi* | [**cancel_checkout**](docs/PaymentLinkApi.md#cancel_checkout) | **PUT** /checkouts/{id}/cancel | Cancel Payment Link
  * Add support for *PaymentLinkApi* | [**create_checkout**](docs/PaymentLinkApi.md#create_checkout) | **POST** /checkouts | Create Unique Payment Link
  * Add support for *PaymentLinkApi* | [**email_checkout**](docs/PaymentLinkApi.md#email_checkout) | **POST** /checkouts/{id}/email | Send an email
  * Add support for *PaymentLinkApi* | [**get_checkout**](docs/PaymentLinkApi.md#get_checkout) | **GET** /checkouts/{id} | Get a payment link by ID
  * Add support for *PaymentLinkApi* | [**get_checkouts**](docs/PaymentLinkApi.md#get_checkouts) | **GET** /checkouts | Get a list of payment links
  * Add support for *PaymentLinkApi* | [**sms_checkout**](docs/PaymentLinkApi.md#sms_checkout) | **POST** /checkouts/{id}/sms | Send an sms
  * Add support for *PaymentMethodsApi* | [**create_customer_payment_methods**](docs/PaymentMethodsApi.md#create_customer_payment_methods) | **POST** /customers/{id}/payment_sources | Create Payment Method
  * Add support for *PaymentMethodsApi* | [**delete_customer_payment_methods**](docs/PaymentMethodsApi.md#delete_customer_payment_methods) | **DELETE** /customers/{id}/payment_sources/{payment_method_id} | Delete Payment Method
  * Add support for *PaymentMethodsApi* | [**get_customer_payment_methods**](docs/PaymentMethodsApi.md#get_customer_payment_methods) | **GET** /customers/{id}/payment_sources | Get Payment Methods
  * Add support for *PaymentMethodsApi* | [**update_customer_payment_methods**](docs/PaymentMethodsApi.md#update_customer_payment_methods) | **PUT** /customers/{id}/payment_sources/{payment_method_id} | Update Payment Method
  * Add support for *PlansApi* | [**create_plan**](docs/PlansApi.md#create_plan) | **POST** /plans | Create Plan
  * Add support for *PlansApi* | [**delete_plan**](docs/PlansApi.md#delete_plan) | **DELETE** /plans/{id} | Delete Plan
  * Add support for *PlansApi* | [**get_plan**](docs/PlansApi.md#get_plan) | **GET** /plans/{id} | Get Plan
  * Add support for *PlansApi* | [**get_plans**](docs/PlansApi.md#get_plans) | **GET** /plans | Get A List of Plans
  * Add support for *PlansApi* | [**update_plan**](docs/PlansApi.md#update_plan) | **PUT** /plans/{id} | Update Plan
  * Add support for *ProductsApi* | [**orders_create_product**](docs/ProductsApi.md#orders_create_product) | **POST** /orders/{id}/line_items | Create Product
  * Add support for *ProductsApi* | [**orders_delete_product**](docs/ProductsApi.md#orders_delete_product) | **DELETE** /orders/{id}/line_items/{line_item_id} | Delete Product
  * Add support for *ProductsApi* | [**orders_update_product**](docs/ProductsApi.md#orders_update_product) | **PUT** /orders/{id}/line_items/{line_item_id} | Update Product
  * Add support for *ShippingContactsApi* | [**create_customer_shipping_contacts**](docs/ShippingContactsApi.md#create_customer_shipping_contacts) | **POST** /customers/{id}/shipping_contacts | Create a shipping contacts
  * Add support for *ShippingContactsApi* | [**delete_customer_shipping_contacts**](docs/ShippingContactsApi.md#delete_customer_shipping_contacts) | **DELETE** /customers/{id}/shipping_contacts/{shipping_contacts_id} | Delete shipping contacts
  * Add support for *ShippingContactsApi* | [**update_customer_shipping_contacts**](docs/ShippingContactsApi.md#update_customer_shipping_contacts) | **PUT** /customers/{id}/shipping_contacts/{shipping_contacts_id} | Update shipping contacts
  * Add support for *ShippingsApi* | [**orders_create_shipping**](docs/ShippingsApi.md#orders_create_shipping) | **POST** /orders/{id}/shipping_lines | Create Shipping
  * Add support for *ShippingsApi* | [**orders_delete_shipping**](docs/ShippingsApi.md#orders_delete_shipping) | **DELETE** /orders/{id}/shipping_lines/{shipping_id} | Delete Shipping
  * Add support for *ShippingsApi* | [**orders_update_shipping**](docs/ShippingsApi.md#orders_update_shipping) | **PUT** /orders/{id}/shipping_lines/{shipping_id} | Update Shipping
  * Add support for *SubscriptionsApi* | [**cancel_subscription**](docs/SubscriptionsApi.md#cancel_subscription) | **POST** /customers/{id}/subscription/cancel | Cancel Subscription
  * Add support for *SubscriptionsApi* | [**create_subscription**](docs/SubscriptionsApi.md#create_subscription) | **POST** /customers/{id}/subscription | Create Subscription
  * Add support for *SubscriptionsApi* | [**get_all_events_from_subscription**](docs/SubscriptionsApi.md#get_all_events_from_subscription) | **GET** /customers/{id}/subscription/events | Get Events By Subscription
  * Add support for *SubscriptionsApi* | [**get_subscription**](docs/SubscriptionsApi.md#get_subscription) | **GET** /customers/{id}/subscription | Get Subscription
  * Add support for *SubscriptionsApi* | [**pause_subscription**](docs/SubscriptionsApi.md#pause_subscription) | **POST** /customers/{id}/subscription/pause | Pause Subscription
  * Add support for *SubscriptionsApi* | [**resume_subscription**](docs/SubscriptionsApi.md#resume_subscription) | **POST** /customers/{id}/subscription/resume | Resume Subscription
  * Add support for *SubscriptionsApi* | [**update_subscription**](docs/SubscriptionsApi.md#update_subscription) | **PUT** /customers/{id}/subscription | Update Subscription
  * Add support for *TaxesApi* | [**orders_create_taxes**](docs/TaxesApi.md#orders_create_taxes) | **POST** /orders/{id}/tax_lines | Create Tax
  * Add support for *TaxesApi* | [**orders_delete_taxes**](docs/TaxesApi.md#orders_delete_taxes) | **DELETE** /orders/{id}/tax_lines/{tax_id} | Delete Tax
  * Add support for *TaxesApi* | [**orders_update_taxes**](docs/TaxesApi.md#orders_update_taxes) | **PUT** /orders/{id}/tax_lines/{tax_id} | Update Tax
  * Add support for *TokensApi* | [**create_token**](docs/TokensApi.md#create_token) | **POST** /tokens | Create Token
  * Add support for *WebhooksApi* | [**create_webhook**](docs/WebhooksApi.md#create_webhook) | **POST** /webhooks | Create Webhook
  * Add support for *WebhooksApi* | [**delete_webhook**](docs/WebhooksApi.md#delete_webhook) | **DELETE** /webhooks/{id} | Delete Webhook
  * Add support for *WebhooksApi* | [**get_webhook**](docs/WebhooksApi.md#get_webhook) | **GET** /webhooks/{id} | Get Webhook
  * Add support for *WebhooksApi* | [**get_webhooks**](docs/WebhooksApi.md#get_webhooks) | **GET** /webhooks | Get List of Webhooks
  * Add support for *WebhooksApi* | [**update_webhook**](docs/WebhooksApi.md#update_webhook) | **PUT** /webhooks/{id} | Update Webhook

