// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Consumption.Models
{
    public partial class ConsumptionResourceProperties : IUtf8JsonSerializable, IJsonModel<ConsumptionResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConsumptionResourceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ConsumptionResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionResourceProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && !(AppliedScopes is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("appliedScopes"u8);
                writer.WriteStartArray();
                foreach (var item in AppliedScopes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && OnDemandRate.HasValue)
            {
                writer.WritePropertyName("onDemandRate"u8);
                writer.WriteNumberValue(OnDemandRate.Value);
            }
            if (options.Format != "W" && Product != null)
            {
                writer.WritePropertyName("product"u8);
                writer.WriteStringValue(Product);
            }
            if (options.Format != "W" && Region != null)
            {
                writer.WritePropertyName("region"u8);
                writer.WriteStringValue(Region);
            }
            if (options.Format != "W" && ReservationRate.HasValue)
            {
                writer.WritePropertyName("reservationRate"u8);
                writer.WriteNumberValue(ReservationRate.Value);
            }
            if (options.Format != "W" && ResourceType != null)
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType);
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

        ConsumptionResourceProperties IJsonModel<ConsumptionResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionResourceProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConsumptionResourceProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConsumptionResourceProperties(document.RootElement, options);
        }

        internal static ConsumptionResourceProperties DeserializeConsumptionResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<string> appliedScopes = default;
            Optional<float> onDemandRate = default;
            Optional<string> product = default;
            Optional<string> region = default;
            Optional<float> reservationRate = default;
            Optional<string> resourceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appliedScopes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    appliedScopes = array;
                    continue;
                }
                if (property.NameEquals("onDemandRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onDemandRate = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("product"u8))
                {
                    product = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("region"u8))
                {
                    region = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reservationRate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reservationRate = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ConsumptionResourceProperties(
                appliedScopes ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(onDemandRate),
                product.Value,
                region.Value,
                Optional.ToNullable(reservationRate),
                resourceType.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ConsumptionResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConsumptionResourceProperties)} does not support '{options.Format}' format.");
            }
        }

        ConsumptionResourceProperties IPersistableModel<ConsumptionResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConsumptionResourceProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConsumptionResourceProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConsumptionResourceProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConsumptionResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
