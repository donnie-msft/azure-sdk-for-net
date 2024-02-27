// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.LargeInstance.Models
{
    public partial class LargeInstanceHardwareProfile : IUtf8JsonSerializable, IJsonModel<LargeInstanceHardwareProfile>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LargeInstanceHardwareProfile>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LargeInstanceHardwareProfile>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceHardwareProfile)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && HardwareType.HasValue)
            {
                writer.WritePropertyName("hardwareType"u8);
                writer.WriteStringValue(HardwareType.Value.ToString());
            }
            if (options.Format != "W" && AzureLargeInstanceSize.HasValue)
            {
                writer.WritePropertyName("azureLargeInstanceSize"u8);
                writer.WriteStringValue(AzureLargeInstanceSize.Value.ToString());
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

        LargeInstanceHardwareProfile IJsonModel<LargeInstanceHardwareProfile>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LargeInstanceHardwareProfile)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLargeInstanceHardwareProfile(document.RootElement, options);
        }

        internal static LargeInstanceHardwareProfile DeserializeLargeInstanceHardwareProfile(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<LargeInstanceHardwareTypeName> hardwareType = default;
            Optional<LargeInstanceSizeName> azureLargeInstanceSize = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hardwareType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hardwareType = new LargeInstanceHardwareTypeName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("azureLargeInstanceSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureLargeInstanceSize = new LargeInstanceSizeName(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LargeInstanceHardwareProfile(Optional.ToNullable(hardwareType), Optional.ToNullable(azureLargeInstanceSize), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LargeInstanceHardwareProfile>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceHardwareProfile)} does not support '{options.Format}' format.");
            }
        }

        LargeInstanceHardwareProfile IPersistableModel<LargeInstanceHardwareProfile>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LargeInstanceHardwareProfile>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLargeInstanceHardwareProfile(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LargeInstanceHardwareProfile)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LargeInstanceHardwareProfile>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
