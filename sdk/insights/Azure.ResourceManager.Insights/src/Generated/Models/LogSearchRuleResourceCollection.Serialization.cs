// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    public partial class LogSearchRuleResourceCollection
    {
        internal static LogSearchRuleResourceCollection DeserializeLogSearchRuleResourceCollection(JsonElement element)
        {
            Optional<IReadOnlyList<LogSearchRuleResource>> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<LogSearchRuleResource> array = new List<LogSearchRuleResource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(LogSearchRuleResource.DeserializeLogSearchRuleResource(item));
                    }
                    value = array;
                    continue;
                }
            }
            return new LogSearchRuleResourceCollection(Optional.ToList(value));
        }
    }
}