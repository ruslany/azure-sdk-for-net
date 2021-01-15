// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class OperationAutoGenerated
    {
        internal static OperationAutoGenerated DeserializeOperationAutoGenerated(JsonElement element)
        {
            Optional<string> name = default;
            Optional<OperationDisplayAutoGenerated> display = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("display"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    display = OperationDisplayAutoGenerated.DeserializeOperationDisplayAutoGenerated(property.Value);
                    continue;
                }
            }
            return new OperationAutoGenerated(name.Value, display.Value);
        }
    }
}