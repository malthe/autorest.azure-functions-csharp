# Azure.Management.Storage

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
azure-arm: true
require: $(this-folder)/../../readme.md
input-file:
  - https://github.com/Azure/azure-rest-api-specs/blob/e606243e5297312781dd7dbfd7ab76d2329cc088/specification/storage/resource-manager/Microsoft.Storage/stable/2019-06-01/blob.json
  - https://github.com/Azure/azure-rest-api-specs/blob/e606243e5297312781dd7dbfd7ab76d2329cc088/specification/storage/resource-manager/Microsoft.Storage/stable/2019-06-01/file.json
  - https://github.com/Azure/azure-rest-api-specs/blob/e606243e5297312781dd7dbfd7ab76d2329cc088/specification/storage/resource-manager/Microsoft.Storage/stable/2019-06-01/storage.json
namespace: Azure.Management.Storage
payload-flattening-threshold: 2

modelerfour:
  lenient-model-deduplication: true
```
