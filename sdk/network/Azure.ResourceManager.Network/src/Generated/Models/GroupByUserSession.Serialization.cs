// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class GroupByUserSession : IUtf8JsonSerializable, IJsonModel<GroupByUserSession>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GroupByUserSession>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GroupByUserSession>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupByUserSession>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GroupByUserSession)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("groupByVariables"u8);
            writer.WriteStartArray();
            foreach (var item in GroupByVariables)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        GroupByUserSession IJsonModel<GroupByUserSession>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupByUserSession>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GroupByUserSession)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGroupByUserSession(document.RootElement, options);
        }

        internal static GroupByUserSession DeserializeGroupByUserSession(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<GroupByVariable> groupByVariables = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("groupByVariables"u8))
                {
                    List<GroupByVariable> array = new List<GroupByVariable>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(GroupByVariable.DeserializeGroupByVariable(item, options));
                    }
                    groupByVariables = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GroupByUserSession(groupByVariables, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GroupByUserSession>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupByUserSession>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GroupByUserSession)} does not support '{options.Format}' format.");
            }
        }

        GroupByUserSession IPersistableModel<GroupByUserSession>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GroupByUserSession>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGroupByUserSession(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GroupByUserSession)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GroupByUserSession>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
