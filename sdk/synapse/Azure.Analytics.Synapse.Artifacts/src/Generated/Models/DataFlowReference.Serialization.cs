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
    [JsonConverter(typeof(DataFlowReferenceConverter))]
    public partial class DataFlowReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            writer.WritePropertyName("referenceName"u8);
            writer.WriteStringValue(ReferenceName);
            if (DatasetParameters != null)
            {
                writer.WritePropertyName("datasetParameters"u8);
                writer.WriteObjectValue(DatasetParameters);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, object> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DataFlowReference DeserializeDataFlowReference(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DataFlowReferenceType type = default;
            string referenceName = default;
            Optional<object> datasetParameters = default;
            IDictionary<string, object> parameters = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new DataFlowReferenceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("referenceName"u8))
                {
                    referenceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("datasetParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    datasetParameters = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    parameters = dictionary;
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFlowReference(type, referenceName, datasetParameters.Value, parameters ?? new ChangeTrackingDictionary<string, object>(), additionalProperties);
        }

        internal partial class DataFlowReferenceConverter : JsonConverter<DataFlowReference>
        {
            public override void Write(Utf8JsonWriter writer, DataFlowReference model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override DataFlowReference Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeDataFlowReference(document.RootElement);
            }
        }
    }
}
