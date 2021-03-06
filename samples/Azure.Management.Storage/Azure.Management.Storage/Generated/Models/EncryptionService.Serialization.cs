// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class EncryptionService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(KeyType))
            {
                writer.WritePropertyName("keyType");
                writer.WriteStringValue(KeyType.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static EncryptionService DeserializeEncryptionService(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<DateTimeOffset> lastEnabledTime = default;
            Optional<KeyType> keyType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("lastEnabledTime"))
                {
                    lastEnabledTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("keyType"))
                {
                    keyType = new KeyType(property.Value.GetString());
                    continue;
                }
            }
            return new EncryptionService(Optional.ToNullable(enabled), Optional.ToNullable(lastEnabledTime), Optional.ToNullable(keyType));
        }
    }
}
