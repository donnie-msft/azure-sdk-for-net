// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class NaptConfiguration : IUtf8JsonSerializable, IJsonModel<NaptConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NaptConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NaptConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NaptConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NaptConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Enabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteStringValue(Enabled.Value.ToString());
            }
            if (PortRange != null)
            {
                writer.WritePropertyName("portRange"u8);
                writer.WriteObjectValue(PortRange);
            }
            if (PortReuseHoldTime != null)
            {
                writer.WritePropertyName("portReuseHoldTime"u8);
                writer.WriteObjectValue(PortReuseHoldTime);
            }
            if (PinholeLimits.HasValue)
            {
                writer.WritePropertyName("pinholeLimits"u8);
                writer.WriteNumberValue(PinholeLimits.Value);
            }
            if (PinholeTimeouts != null)
            {
                writer.WritePropertyName("pinholeTimeouts"u8);
                writer.WriteObjectValue(PinholeTimeouts);
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

        NaptConfiguration IJsonModel<NaptConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NaptConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NaptConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNaptConfiguration(document.RootElement, options);
        }

        internal static NaptConfiguration DeserializeNaptConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<NaptState> enabled = default;
            Optional<MobileNetworkPortRange> portRange = default;
            Optional<MobileNetworkPortReuseHoldTimes> portReuseHoldTime = default;
            Optional<int> pinholeLimits = default;
            Optional<PinholeTimeouts> pinholeTimeouts = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = new NaptState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("portRange"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portRange = MobileNetworkPortRange.DeserializeMobileNetworkPortRange(property.Value, options);
                    continue;
                }
                if (property.NameEquals("portReuseHoldTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    portReuseHoldTime = MobileNetworkPortReuseHoldTimes.DeserializeMobileNetworkPortReuseHoldTimes(property.Value, options);
                    continue;
                }
                if (property.NameEquals("pinholeLimits"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pinholeLimits = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("pinholeTimeouts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pinholeTimeouts = PinholeTimeouts.DeserializePinholeTimeouts(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NaptConfiguration(
                Optional.ToNullable(enabled),
                portRange.Value,
                portReuseHoldTime.Value,
                Optional.ToNullable(pinholeLimits),
                pinholeTimeouts.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NaptConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NaptConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NaptConfiguration)} does not support '{options.Format}' format.");
            }
        }

        NaptConfiguration IPersistableModel<NaptConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NaptConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNaptConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NaptConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NaptConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
