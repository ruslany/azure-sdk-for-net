// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.AI.TextAnalytics.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    internal partial class DocumentHealthcareEntitiesInternal
    {
        internal static DocumentHealthcareEntitiesInternal DeserializeDocumentHealthcareEntitiesInternal(JsonElement element)
        {
            string id = default;
            IReadOnlyList<HealthcareEntity> entities = default;
            IReadOnlyList<HealthcareRelationInternal> relations = default;
            IReadOnlyList<TextAnalyticsWarningInternal> warnings = default;
            Optional<TextDocumentStatistics> statistics = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("entities"))
                {
                    List<HealthcareEntity> array = new List<HealthcareEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareEntity.DeserializeHealthcareEntity(item));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("relations"))
                {
                    List<HealthcareRelationInternal> array = new List<HealthcareRelationInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HealthcareRelationInternal.DeserializeHealthcareRelationInternal(item));
                    }
                    relations = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<TextAnalyticsWarningInternal> array = new List<TextAnalyticsWarningInternal>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TextAnalyticsWarningInternal.DeserializeTextAnalyticsWarningInternal(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("statistics"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statistics = TextDocumentStatistics.DeserializeTextDocumentStatistics(property.Value);
                    continue;
                }
            }
            return new DocumentHealthcareEntitiesInternal(id, entities, relations, warnings, Optional.ToNullable(statistics));
        }
    }
}