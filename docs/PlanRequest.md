# Conekta.net.Model.PlanRequest
a plan

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **int** | The amount in cents that will be charged on the interval specified. | 
**Currency** | **string** | ISO 4217 for currencies, for the Mexican peso it is MXN/USD | [optional] 
**ExpiryCount** | **int** | Number of repetitions of the frequency NUMBER OF CHARGES TO BE MADE, considering the interval and frequency, this evolves over time, but is subject to the expiration count. | [optional] 
**Frequency** | **int** | Frequency of the charge, which together with the interval, can be every 3 weeks, every 4 months, every 2 years, every 5 fortnights | 
**Id** | **string** | internal reference id | [optional] 
**Interval** | **string** | The interval of time between each charge. | 
**Name** | **string** | The name of the plan. | 
**TrialPeriodDays** | **int** | The number of days the customer will have a free trial. | [optional] 
**MaxRetries** | **int** | (optional) Specifies the maximum number of retry attempts for a subscription payment before it is canceled. | [optional] 
**RetryDelayHours** | **int** | (optional)  Defines the number of hours between subscription payment retry attempts. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

