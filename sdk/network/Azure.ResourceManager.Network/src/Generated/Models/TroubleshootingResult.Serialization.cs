// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class TroubleshootingResult
    {
        internal static TroubleshootingResult DeserializeTroubleshootingResult(JsonElement element)
        {
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<string> code = default;
            Optional<IReadOnlyList<TroubleshootingDetails>> results = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("results"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<TroubleshootingDetails> array = new List<TroubleshootingDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TroubleshootingDetails.DeserializeTroubleshootingDetails(item));
                    }
                    results = array;
                    continue;
                }
            }
            return new TroubleshootingResult(Optional.ToNullable(startTime), Optional.ToNullable(endTime), code.Value, Optional.ToList(results));
        }
    }
}