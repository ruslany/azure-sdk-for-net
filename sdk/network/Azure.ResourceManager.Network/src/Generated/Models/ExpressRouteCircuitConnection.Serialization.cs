// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ExpressRouteCircuitConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(ExpressRouteCircuitPeering))
            {
                writer.WritePropertyName("expressRouteCircuitPeering");
                writer.WriteObjectValue(ExpressRouteCircuitPeering);
            }
            if (Optional.IsDefined(PeerExpressRouteCircuitPeering))
            {
                writer.WritePropertyName("peerExpressRouteCircuitPeering");
                writer.WriteObjectValue(PeerExpressRouteCircuitPeering);
            }
            if (Optional.IsDefined(AddressPrefix))
            {
                writer.WritePropertyName("addressPrefix");
                writer.WriteStringValue(AddressPrefix);
            }
            if (Optional.IsDefined(AuthorizationKey))
            {
                writer.WritePropertyName("authorizationKey");
                writer.WriteStringValue(AuthorizationKey);
            }
            if (Optional.IsDefined(Ipv6CircuitConnectionConfig))
            {
                writer.WritePropertyName("ipv6CircuitConnectionConfig");
                writer.WriteObjectValue(Ipv6CircuitConnectionConfig);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteCircuitConnection DeserializeExpressRouteCircuitConnection(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> id = default;
            Optional<SubResource> expressRouteCircuitPeering = default;
            Optional<SubResource> peerExpressRouteCircuitPeering = default;
            Optional<string> addressPrefix = default;
            Optional<string> authorizationKey = default;
            Optional<Ipv6CircuitConnectionConfig> ipv6CircuitConnectionConfig = default;
            Optional<CircuitConnectionStatus> circuitConnectionStatus = default;
            Optional<ProvisioningState> provisioningState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("expressRouteCircuitPeering"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            expressRouteCircuitPeering = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("peerExpressRouteCircuitPeering"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            peerExpressRouteCircuitPeering = DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("addressPrefix"))
                        {
                            addressPrefix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("authorizationKey"))
                        {
                            authorizationKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ipv6CircuitConnectionConfig"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            ipv6CircuitConnectionConfig = Ipv6CircuitConnectionConfig.DeserializeIpv6CircuitConnectionConfig(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("circuitConnectionStatus"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            circuitConnectionStatus = new CircuitConnectionStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteCircuitConnection(id.Value, name.Value, etag.Value, type.Value, expressRouteCircuitPeering.Value, peerExpressRouteCircuitPeering.Value, addressPrefix.Value, authorizationKey.Value, ipv6CircuitConnectionConfig.Value, Optional.ToNullable(circuitConnectionStatus), Optional.ToNullable(provisioningState));
        }
    }
}