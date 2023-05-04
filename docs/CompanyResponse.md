# Conekta.net.Model.CompanyResponse
Company model

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The child company&#39;s unique identifier | [optional] 
**CreatedAt** | **long** | The resource&#39;s creation date (unix timestamp) | [optional] 
**Name** | **string** | The child company&#39;s name | [optional] 
**Object** | **string** | The resource&#39;s type | [optional] 
**ParentCompanyId** | **string** | Id of the parent company | [optional] 
**UseParentFiscalData** | **bool** | Whether the parent company&#39;s fiscal data is to be used for liquidation and tax purposes | [optional] 
**PayoutDestination** | [**CompanyPayoutDestinationResponse**](CompanyPayoutDestinationResponse.md) |  | [optional] 
**FiscalInfo** | [**CompanyFiscalInfoResponse**](CompanyFiscalInfoResponse.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

