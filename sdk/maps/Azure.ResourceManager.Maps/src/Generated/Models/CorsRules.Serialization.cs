// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    internal partial class CorsRules : IUtf8JsonSerializable, IJsonModel<CorsRules>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CorsRules>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CorsRules>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CorsRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CorsRules)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(CorsRulesValue is ChangeTrackingList<MapsCorsRule> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("corsRules"u8);
                writer.WriteStartArray();
                foreach (var item in CorsRulesValue)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        CorsRules IJsonModel<CorsRules>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CorsRules>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CorsRules)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCorsRules(document.RootElement, options);
        }

        internal static CorsRules DeserializeCorsRules(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<MapsCorsRule> corsRules = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("corsRules"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MapsCorsRule> array = new List<MapsCorsRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MapsCorsRule.DeserializeMapsCorsRule(item, options));
                    }
                    corsRules = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CorsRules(corsRules ?? new ChangeTrackingList<MapsCorsRule>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CorsRules>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CorsRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CorsRules)} does not support '{options.Format}' format.");
            }
        }

        CorsRules IPersistableModel<CorsRules>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CorsRules>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCorsRules(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CorsRules)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CorsRules>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
