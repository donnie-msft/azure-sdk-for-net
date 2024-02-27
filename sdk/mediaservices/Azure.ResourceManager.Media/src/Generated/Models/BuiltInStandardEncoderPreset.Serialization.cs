// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class BuiltInStandardEncoderPreset : IUtf8JsonSerializable, IJsonModel<BuiltInStandardEncoderPreset>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BuiltInStandardEncoderPreset>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BuiltInStandardEncoderPreset>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuiltInStandardEncoderPreset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BuiltInStandardEncoderPreset)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Configurations != null)
            {
                writer.WritePropertyName("configurations"u8);
                writer.WriteObjectValue(Configurations);
            }
            writer.WritePropertyName("presetName"u8);
            writer.WriteStringValue(PresetName.ToString());
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        BuiltInStandardEncoderPreset IJsonModel<BuiltInStandardEncoderPreset>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuiltInStandardEncoderPreset>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BuiltInStandardEncoderPreset)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBuiltInStandardEncoderPreset(document.RootElement, options);
        }

        internal static BuiltInStandardEncoderPreset DeserializeBuiltInStandardEncoderPreset(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<EncoderPresetConfigurations> configurations = default;
            EncoderNamedPreset presetName = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    configurations = EncoderPresetConfigurations.DeserializeEncoderPresetConfigurations(property.Value, options);
                    continue;
                }
                if (property.NameEquals("presetName"u8))
                {
                    presetName = new EncoderNamedPreset(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BuiltInStandardEncoderPreset(odataType, serializedAdditionalRawData, configurations.Value, presetName);
        }

        BinaryData IPersistableModel<BuiltInStandardEncoderPreset>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuiltInStandardEncoderPreset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BuiltInStandardEncoderPreset)} does not support '{options.Format}' format.");
            }
        }

        BuiltInStandardEncoderPreset IPersistableModel<BuiltInStandardEncoderPreset>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BuiltInStandardEncoderPreset>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBuiltInStandardEncoderPreset(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BuiltInStandardEncoderPreset)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BuiltInStandardEncoderPreset>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
