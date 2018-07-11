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
await dawa.Address.GetAddress("0a3f509f-4cd7-32b8-e044-0003ba298018");
```

### Search by parameters
```csharp
// Search address
await dawa.Address.SearchAddress()
                .AddParameter(AddressParam.Roadname, "Søndergade")
                .AddParameter(AddressParam.HouseNo, "1B")
                .AddParameter(AddressParam.Zipcode, "8670")
                .Execute()
```