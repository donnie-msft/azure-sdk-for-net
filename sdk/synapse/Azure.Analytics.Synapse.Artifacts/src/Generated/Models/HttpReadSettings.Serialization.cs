// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(HttpReadSettingsConverter))]
    public partial class HttpReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (RequestMethod != null)
            {
                writer.WritePropertyName("requestMethod"u8);
                writer.WriteObjectValue(RequestMethod);
            }
            if (RequestBody != null)
            {
                writer.WritePropertyName("requestBody"u8);
                writer.WriteObjectValue(RequestBody);
            }
            if (AdditionalHeaders != null)
            {
                writer.WritePropertyName("additionalHeaders"u8);
                writer.WriteObjectValue(AdditionalHeaders);
            }
            if (RequestTimeout != null)
            {
                writer.WritePropertyName("requestTimeout"u8);
                writer.WriteObjectValue(RequestTimeout);
            }
            if (EnablePartitionDiscovery != null)
            {
                writer.WritePropertyName("enablePartitionDiscovery"u8);
                writer.WriteObjectValue(EnablePartitionDiscovery);
            }
            if (PartitionRootPath != null)
            {
                writer.WritePropertyName("partitionRootPath"u8);
                writer.WriteObjectValue(PartitionRootPath);
            }
            if (AdditionalColumns != null)
            {
                writer.WritePropertyName("additionalColumns"u8);
                writer.WriteObjectValue(AdditionalColumns);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HttpReadSettings DeserializeHttpReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> requestMethod = default;
            Optional<object> requestBody = default;
            Optional<object> additionalHeaders = default;
            Optional<object> requestTimeout = default;
            Optional<object> enablePartitionDiscovery = default;
            Optional<object> partitionRootPath = default;
            Optional<object> additionalColumns = default;
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("requestMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestMethod = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("requestBody"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestBody = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalHeaders"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalHeaders = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("requestTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requestTimeout = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePartitionDiscovery = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionRootPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionRootPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("additionalColumns"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    additionalColumns = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new HttpReadSettings(
                type,
                maxConcurrentConnections.Value,
                additionalProperties,
                requestMethod.Value,
                requestBody.Value,
                additionalHeaders.Value,
                requestTimeout.Value,
                enablePartitionDiscovery.Value,
                partitionRootPath.Value,
                additionalColumns.Value);
        }

        internal partial class HttpReadSettingsConverter : JsonConverter<HttpReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, HttpReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override HttpReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeHttpReadSettings(document.RootElement);
            }
        }
    }
}
