// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class NetworkInterfaceIPConfiguration : IUtf8JsonSerializable
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
            if (Optional.IsCollectionDefined(VirtualNetworkTaps))
            {
                writer.WritePropertyName("virtualNetworkTaps");
                writer.WriteStartArray();
                foreach (var item in VirtualNetworkTaps)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ApplicationGatewayBackendAddressPools))
            {
                writer.WritePropertyName("applicationGatewayBackendAddressPools");
                writer.WriteStartArray();
                foreach (var item in ApplicationGatewayBackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancerBackendAddressPools))
            {
                writer.WritePropertyName("loadBalancerBackendAddressPools");
                writer.WriteStartArray();
                foreach (var item in LoadBalancerBackendAddressPools)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(LoadBalancerInboundNatRules))
            {
                writer.WritePropertyName("loadBalancerInboundNatRules");
                writer.WriteStartArray();
                foreach (var item in LoadBalancerInboundNatRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIPAddress");
                writer.WriteStringValue(PrivateIPAddress);
            }
            if (Optional.IsDefined(PrivateIPAllocationMethod))
            {
                writer.WritePropertyName("privateIPAllocationMethod");
                writer.WriteStringValue(PrivateIPAllocationMethod.Value.ToString());
            }
            if (Optional.IsDefined(PrivateIPAddressVersion))
            {
                writer.WritePropertyName("privateIPAddressVersion");
                writer.WriteStringValue(PrivateIPAddressVersion.Value.ToString());
            }
            if (Optional.IsDefined(Subnet))
            {
                writer.WritePropertyName("subnet");
                writer.WriteObjectValue(Subnet);
            }
            if (Optional.IsDefined(Primary))
            {
                writer.WritePropertyName("primary");
                writer.WriteBooleanValue(Primary.Value);
            }
            if (Optional.IsDefined(PublicIPAddress))
            {
                writer.WritePropertyName("publicIPAddress");
                writer.WriteObjectValue(PublicIPAddress);
            }
            if (Optional.IsCollectionDefined(ApplicationSecurityGroups))
            {
                writer.WritePropertyName("applicationSecurityGroups");
                writer.WriteStartArray();
                foreach (var item in ApplicationSecurityGroups)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static NetworkInterfaceIPConfiguration DeserializeNetworkInterfaceIPConfiguration(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> etag = default;
            Optional<string> id = default;
            Optional<IList<VirtualNetworkTap>> virtualNetworkTaps = default;
            Optional<IList<ApplicationGatewayBackendAddressPool>> applicationGatewayBackendAddressPools = default;
            Optional<IList<BackendAddressPool>> loadBalancerBackendAddressPools = default;
            Optional<IList<InboundNatRule>> loadBalancerInboundNatRules = default;
            Optional<string> privateIPAddress = default;
            Optional<IPAllocationMethod> privateIPAllocationMethod = default;
            Optional<IPVersion> privateIPAddressVersion = default;
            Optional<Subnet> subnet = default;
            Optional<bool> primary = default;
            Optional<PublicIPAddress> publicIPAddress = default;
            Optional<IList<ApplicationSecurityGroup>> applicationSecurityGroups = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties> privateLinkConnectionProperties = default;
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
                        if (property0.NameEquals("virtualNetworkTaps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<VirtualNetworkTap> array = new List<VirtualNetworkTap>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(VirtualNetworkTap.DeserializeVirtualNetworkTap(item));
                            }
                            virtualNetworkTaps = array;
                            continue;
                        }
                        if (property0.NameEquals("applicationGatewayBackendAddressPools"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationGatewayBackendAddressPool> array = new List<ApplicationGatewayBackendAddressPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationGatewayBackendAddressPool.DeserializeApplicationGatewayBackendAddressPool(item));
                            }
                            applicationGatewayBackendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerBackendAddressPools"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<BackendAddressPool> array = new List<BackendAddressPool>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(BackendAddressPool.DeserializeBackendAddressPool(item));
                            }
                            loadBalancerBackendAddressPools = array;
                            continue;
                        }
                        if (property0.NameEquals("loadBalancerInboundNatRules"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<InboundNatRule> array = new List<InboundNatRule>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(InboundNatRule.DeserializeInboundNatRule(item));
                            }
                            loadBalancerInboundNatRules = array;
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddress"))
                        {
                            privateIPAddress = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateIPAllocationMethod"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateIPAllocationMethod = new IPAllocationMethod(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("privateIPAddressVersion"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateIPAddressVersion = new IPVersion(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("subnet"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            subnet = Subnet.DeserializeSubnet(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("primary"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            primary = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("publicIPAddress"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            publicIPAddress = PublicIPAddress.DeserializePublicIPAddress(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("applicationSecurityGroups"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<ApplicationSecurityGroup> array = new List<ApplicationSecurityGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ApplicationSecurityGroup.DeserializeApplicationSecurityGroup(item));
                            }
                            applicationSecurityGroups = array;
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
                        if (property0.NameEquals("privateLinkConnectionProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            privateLinkConnectionProperties = NetworkInterfaceIPConfigurationPrivateLinkConnectionProperties.DeserializeNetworkInterfaceIPConfigurationPrivateLinkConnectionProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new NetworkInterfaceIPConfiguration(id.Value, name.Value, etag.Value, Optional.ToList(virtualNetworkTaps), Optional.ToList(applicationGatewayBackendAddressPools), Optional.ToList(loadBalancerBackendAddressPools), Optional.ToList(loadBalancerInboundNatRules), privateIPAddress.Value, Optional.ToNullable(privateIPAllocationMethod), Optional.ToNullable(privateIPAddressVersion), subnet.Value, Optional.ToNullable(primary), publicIPAddress.Value, Optional.ToList(applicationSecurityGroups), Optional.ToNullable(provisioningState), privateLinkConnectionProperties.Value);
        }
    }
}