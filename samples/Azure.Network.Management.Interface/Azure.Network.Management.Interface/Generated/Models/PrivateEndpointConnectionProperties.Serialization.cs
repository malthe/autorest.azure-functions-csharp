// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Network.Management.Interface.Models
{
    public partial class PrivateEndpointConnectionProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (PrivateEndpoint != null)
            {
                writer.WritePropertyName("privateEndpoint");
                writer.WriteObjectValue(PrivateEndpoint);
            }
            if (PrivateLinkServiceConnectionState != null)
            {
                writer.WritePropertyName("privateLinkServiceConnectionState");
                writer.WriteObjectValue(PrivateLinkServiceConnectionState);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (LinkIdentifier != null)
            {
                writer.WritePropertyName("linkIdentifier");
                writer.WriteStringValue(LinkIdentifier);
            }
            writer.WriteEndObject();
        }
        internal static PrivateEndpointConnectionProperties DeserializePrivateEndpointConnectionProperties(JsonElement element)
        {
            PrivateEndpointConnectionProperties result = new PrivateEndpointConnectionProperties();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateEndpoint"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrivateEndpoint = PrivateEndpoint.DeserializePrivateEndpoint(property.Value);
                    continue;
                }
                if (property.NameEquals("privateLinkServiceConnectionState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.PrivateLinkServiceConnectionState = PrivateLinkServiceConnectionState.DeserializePrivateLinkServiceConnectionState(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.ProvisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("linkIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.LinkIdentifier = property.Value.GetString();
                    continue;
                }
            }
            return result;
        }
    }
}