# DAWA .NET SDK

___Work in progress!___

A .NET SDK for developing against the DAWA API

## Requirements
.NET Framework 4.5.2 or .NET Standard 2.0

## Getting started
```csharp
var dawa = new DAWAClient();
```

### Search by id
```csharp
// Get address by id
await dawa.Address.GetAddress("0a3f50c2-25c4-32b8-e044-0003ba298018");
```

### Search by parameters
```csharp
// Search address
await dawa.Address.SearchAddress()
                .AddParameter(AddressParam.Roadname, "Danmarksvej")
                .AddParameter(AddressParam.HouseNo, "26")
                .AddParameter(AddressParam.Zipcode, "8660")
                .Execute()
```