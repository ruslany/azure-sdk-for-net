// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.AI.TextAnalytics.Models;
using Azure.Core;

namespace Azure.AI.TextAnalytics
{
    public partial class EntityRecognitionTasksItem
    {
        internal static EntityRecognitionTasksItem DeserializeEntityRecognitionTasksItem(JsonElement element)
        {
            EntitiesResult results = default;
            DateTimeOffset lastUpdateDateTime = default;
            Optional<string> name = default;
            JobStatus status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("results"))
                {
                    results = EntitiesResult.DeserializeEntitiesResult(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdateDateTime"))
                {
                    lastUpdateDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    status = new JobStatus(property.Value.GetString());
                    continue;
                }
            }
            return new EntityRecognitionTasksItem(lastUpdateDateTime, name.Value, status, results);
        }
    }
}