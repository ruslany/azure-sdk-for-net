// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class BastionActiveSession
    {
        internal static BastionActiveSession DeserializeBastionActiveSession(JsonElement element)
        {
            Optional<string> sessionId = default;
            Optional<object> startTime = default;
            Optional<string> targetSubscriptionId = default;
            Optional<string> resourceType = default;
            Optional<string> targetHostName = default;
            Optional<string> targetResourceGroup = default;
            Optional<string> userName = default;
            Optional<string> targetIpAddress = default;
            Optional<BastionConnectProtocol> protocol = default;
            Optional<string> targetResourceId = default;
            Optional<float> sessionDurationInMins = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sessionId"))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("targetSubscriptionId"))
                {
                    targetSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetHostName"))
                {
                    targetHostName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"))
                {
                    targetResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("userName"))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetIpAddress"))
                {
                    targetIpAddress = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protocol"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    protocol = new BastionConnectProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResourceId"))
                {
                    targetResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionDurationInMins"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sessionDurationInMins = property.Value.GetSingle();
                    continue;
                }
            }
            return new BastionActiveSession(sessionId.Value, startTime.Value, targetSubscriptionId.Value, resourceType.Value, targetHostName.Value, targetResourceGroup.Value, userName.Value, targetIpAddress.Value, Optional.ToNullable(protocol), targetResourceId.Value, Optional.ToNullable(sessionDurationInMins));
        }
    }
}