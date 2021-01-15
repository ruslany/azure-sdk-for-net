// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorListResult
    {
        internal static ConnectionMonitorListResult DeserializeConnectionMonitorListResult(JsonElement element)
        {
            Optional<IReadOnlyList<ConnectionMonitorResult>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ConnectionMonitorResult> array = new List<ConnectionMonitorResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConnectionMonitorResult.DeserializeConnectionMonitorResult(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new ConnectionMonitorListResult(Optional.ToList(value));
        }
    }
}