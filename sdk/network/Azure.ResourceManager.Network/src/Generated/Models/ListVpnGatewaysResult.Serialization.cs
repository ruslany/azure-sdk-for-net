// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ListVpnGatewaysResult
    {
        internal static ListVpnGatewaysResult DeserializeListVpnGatewaysResult(JsonElement element)
        {
            Optional<IReadOnlyList<VpnGateway>> value = default;
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
                    List<VpnGateway> array = new List<VpnGateway>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VpnGateway.DeserializeVpnGateway(item));
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
            return new ListVpnGatewaysResult(Optional.ToList(value), nextLink.Value);
        }
    }
}