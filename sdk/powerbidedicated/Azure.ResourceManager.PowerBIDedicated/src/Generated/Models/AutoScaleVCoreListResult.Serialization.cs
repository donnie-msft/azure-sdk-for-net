// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.PowerBIDedicated;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    internal partial class AutoScaleVCoreListResult : IUtf8JsonSerializable, IJsonModel<AutoScaleVCoreListResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutoScaleVCoreListResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutoScaleVCoreListResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleVCoreListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoScaleVCoreListResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
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

        AutoScaleVCoreListResult IJsonModel<AutoScaleVCoreListResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleVCoreListResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutoScaleVCoreListResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutoScaleVCoreListResult(document.RootElement, options);
        }

        internal static AutoScaleVCoreListResult DeserializeAutoScaleVCoreListResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AutoScaleVCoreData> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<AutoScaleVCoreData> array = new List<AutoScaleVCoreData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AutoScaleVCoreData.DeserializeAutoScaleVCoreData(item, options));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AutoScaleVCoreListResult(value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutoScaleVCoreListResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleVCoreListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutoScaleVCoreListResult)} does not support '{options.Format}' format.");
            }
        }

        AutoScaleVCoreListResult IPersistableModel<AutoScaleVCoreListResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutoScaleVCoreListResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutoScaleVCoreListResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutoScaleVCoreListResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutoScaleVCoreListResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
