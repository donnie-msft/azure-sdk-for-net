// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    public partial class CloudInventoryItem : IUtf8JsonSerializable, IJsonModel<CloudInventoryItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CloudInventoryItem>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CloudInventoryItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudInventoryItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudInventoryItem)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("inventoryType"u8);
            writer.WriteStringValue(InventoryType.ToString());
            if (options.Format != "W" && ManagedResourceId != null)
            {
                writer.WritePropertyName("managedResourceId"u8);
                writer.WriteStringValue(ManagedResourceId);
            }
            if (options.Format != "W" && Uuid != null)
            {
                writer.WritePropertyName("uuid"u8);
                writer.WriteStringValue(Uuid);
            }
            if (options.Format != "W" && InventoryItemName != null)
            {
                writer.WritePropertyName("inventoryItemName"u8);
                writer.WriteStringValue(InventoryItemName);
            }
            if (options.Format != "W" && ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState);
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

        CloudInventoryItem IJsonModel<CloudInventoryItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudInventoryItem>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CloudInventoryItem)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCloudInventoryItem(document.RootElement, options);
        }

        internal static CloudInventoryItem DeserializeCloudInventoryItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InventoryType inventoryType = default;
            Optional<string> managedResourceId = default;
            Optional<string> uuid = default;
            Optional<string> inventoryItemName = default;
            Optional<string> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("inventoryType"u8))
                {
                    inventoryType = new InventoryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedResourceId"u8))
                {
                    managedResourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("uuid"u8))
                {
                    uuid = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inventoryItemName"u8))
                {
                    inventoryItemName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    provisioningState = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CloudInventoryItem(
                inventoryType,
                managedResourceId.Value,
                uuid.Value,
                inventoryItemName.Value,
                provisioningState.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CloudInventoryItem>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudInventoryItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CloudInventoryItem)} does not support '{options.Format}' format.");
            }
        }

        CloudInventoryItem IPersistableModel<CloudInventoryItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CloudInventoryItem>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCloudInventoryItem(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CloudInventoryItem)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CloudInventoryItem>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
