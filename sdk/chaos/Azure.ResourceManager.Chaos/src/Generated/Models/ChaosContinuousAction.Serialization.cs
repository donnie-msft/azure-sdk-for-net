// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Chaos.Models
{
    public partial class ChaosContinuousAction : IUtf8JsonSerializable, IJsonModel<ChaosContinuousAction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChaosContinuousAction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ChaosContinuousAction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosContinuousAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosContinuousAction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("duration"u8);
            writer.WriteStringValue(Duration, "P");
            writer.WritePropertyName("parameters"u8);
            writer.WriteStartArray();
            foreach (var item in Parameters)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("selectorId"u8);
            writer.WriteStringValue(SelectorId);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(ActionType);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
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

        ChaosContinuousAction IJsonModel<ChaosContinuousAction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosContinuousAction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ChaosContinuousAction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChaosContinuousAction(document.RootElement, options);
        }

        internal static ChaosContinuousAction DeserializeChaosContinuousAction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TimeSpan duration = default;
            IList<ChaosKeyValuePair> parameters = default;
            string selectorId = default;
            string type = default;
            string name = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("duration"u8))
                {
                    duration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    List<ChaosKeyValuePair> array = new List<ChaosKeyValuePair>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ChaosKeyValuePair.DeserializeChaosKeyValuePair(item, options));
                    }
                    parameters = array;
                    continue;
                }
                if (property.NameEquals("selectorId"u8))
                {
                    selectorId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ChaosContinuousAction(
                type,
                name,
                serializedAdditionalRawData,
                duration,
                parameters,
                selectorId);
        }

        BinaryData IPersistableModel<ChaosContinuousAction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosContinuousAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ChaosContinuousAction)} does not support '{options.Format}' format.");
            }
        }

        ChaosContinuousAction IPersistableModel<ChaosContinuousAction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ChaosContinuousAction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeChaosContinuousAction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ChaosContinuousAction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ChaosContinuousAction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
