# DAWA .NET SDK

A .NET SDK for developing against the DAWA API

## Requirements
.NET Framework 4.5.2 or .NET Standard 2.0

## Supported data
| Resource          | Instance      | Name              | Impl. | Get | Search | Cleaning |
|-------------------|-------------- |-------------------|-------|-----|--------|----------|
| Adresser          | Address       | Address           | Yes   | x   | x      | x        |
| Adgangsadresser   | Address       | AccessAddress     | Yes   | x   | x      | x        |
| Postnumre         | Address       | Zipcode           | Yes   | x   | x      |          |
| Vejstykker        | Address       | Roadsegment       | Yes   | x   | x      |          |
| Kommuner          | DAGI          | Municipalities    |       | x   | x      |          |
| Politikredse      | DAGI          | PoliceAreas       |       | x   | x      |          |
| Regioner          | DAGI          | Regions           |       | x   | x      |          |
| Retskredse        | DAGI          | Jurisdictions     |       | x   | x      |          |
| Sogne             | DAGI          | Parish            |       | x   | x      |          |
| Ejerlav           | CadastralMap  | OwnerSssociations |       | x   | x      |          |
| Jordstykker       | CadastralMap  | Plots             |       | x   | x      |          |

**Please note: Not all resources are avaiable yet!**

## Getting started
```csharp
// Create instance of the DAWA SDK client
var dawa = new DAWAClient();
```

### Get
```csharp
// Get address by id
await dawa.Address.GetAddress("0a3f50c2-25c4-32b8-e044-0003ba298018");
```

### Search
```csharp
// Search address
await dawa.Address.SearchAddress()
                .AddParameter(AddressParam.Roadname, "Danmarksvej")
                .AddParameter(AddressParam.HouseNo, "26")
                .AddParameter(AddressParam.Zipcode, "8660")
                .Execute()
```

### Cleaning
```csharp
// Cleaning or validate address
await dawa.Address.DataCleaningAddress("Danmarksvej 26, 8660 Skanderbårg");
```

### Examples
[See examples here](examples/)
