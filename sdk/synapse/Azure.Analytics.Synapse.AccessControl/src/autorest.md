# Microsoft.Azure.Synapse

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

```yaml
repo: https://github.com/Azure/azure-rest-api-specs/blob/8a09ea0b84aa36cb0e56bab4f4c8efd83a6fdcf6
```

``` yaml
public-clients: true
input-file:
    - $(repo)/specification/synapse/data-plane/Microsoft.Synapse/preview/2020-02-01-preview/roleAssignments.json
    - $(repo)/specification/synapse/data-plane/Microsoft.Synapse/preview/2020-02-01-preview/roles.json
```