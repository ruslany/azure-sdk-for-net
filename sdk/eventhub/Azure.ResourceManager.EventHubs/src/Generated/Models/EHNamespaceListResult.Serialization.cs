// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class EHNamespaceListResult
    {
        internal static EHNamespaceListResult DeserializeEHNamespaceListResult(JsonElement element)
        {
            Optional<IReadOnlyList<EHNamespace>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<EHNamespace> array = new List<EHNamespace>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(EHNamespace.DeserializeEHNamespace(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new EHNamespaceListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}