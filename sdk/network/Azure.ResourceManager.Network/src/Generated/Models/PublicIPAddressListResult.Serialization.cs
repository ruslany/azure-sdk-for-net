// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PublicIPAddressListResult
    {
        internal static PublicIPAddressListResult DeserializePublicIPAddressListResult(JsonElement element)
        {
            Optional<IReadOnlyList<PublicIPAddress>> value = default;
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
                    List<PublicIPAddress> array = new List<PublicIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PublicIPAddress.DeserializePublicIPAddress(item));
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
            return new PublicIPAddressListResult(Optional.ToList(value), nextLink.Value);
        }
    }
}