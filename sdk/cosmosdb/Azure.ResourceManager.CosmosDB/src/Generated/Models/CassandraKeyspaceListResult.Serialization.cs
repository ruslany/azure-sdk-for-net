// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CassandraKeyspaceListResult
    {
        internal static CassandraKeyspaceListResult DeserializeCassandraKeyspaceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<CassandraKeyspaceGetResults>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<CassandraKeyspaceGetResults> array = new List<CassandraKeyspaceGetResults>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CassandraKeyspaceGetResults.DeserializeCassandraKeyspaceGetResults(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new CassandraKeyspaceListResult(Optional.ToList(value));
        }
    }
}