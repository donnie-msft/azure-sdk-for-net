// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class BlobInventoryPolicyRule : IUtf8JsonSerializable, IJsonModel<BlobInventoryPolicyRule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlobInventoryPolicyRule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BlobInventoryPolicyRule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobInventoryPolicyRule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("enabled"u8);
            writer.WriteBooleanValue(IsEnabled);
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("destination"u8);
            writer.WriteStringValue(Destination);
            writer.WritePropertyName("definition"u8);
            writer.WriteObjectValue(Definition);
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

        BlobInventoryPolicyRule IJsonModel<BlobInventoryPolicyRule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicyRule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BlobInventoryPolicyRule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlobInventoryPolicyRule(document.RootElement, options);
        }

        internal static BlobInventoryPolicyRule DeserializeBlobInventoryPolicyRule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool enabled = default;
            string name = default;
            string destination = default;
            BlobInventoryPolicyDefinition definition = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("definition"u8))
                {
                    definition = BlobInventoryPolicyDefinition.DeserializeBlobInventoryPolicyDefinition(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BlobInventoryPolicyRule(enabled, name, destination, definition, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BlobInventoryPolicyRule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BlobInventoryPolicyRule)} does not support '{options.Format}' format.");
            }
        }

        BlobInventoryPolicyRule IPersistableModel<BlobInventoryPolicyRule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BlobInventoryPolicyRule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBlobInventoryPolicyRule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BlobInventoryPolicyRule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BlobInventoryPolicyRule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
