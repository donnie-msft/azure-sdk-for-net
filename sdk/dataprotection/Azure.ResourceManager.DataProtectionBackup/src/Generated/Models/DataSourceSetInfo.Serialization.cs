// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataSourceSetInfo : IUtf8JsonSerializable, IJsonModel<DataSourceSetInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataSourceSetInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataSourceSetInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourceSetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourceSetInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DataSourceType != null)
            {
                writer.WritePropertyName("datasourceType"u8);
                writer.WriteStringValue(DataSourceType);
            }
            if (ObjectType != null)
            {
                writer.WritePropertyName("objectType"u8);
                writer.WriteStringValue(ObjectType);
            }
            writer.WritePropertyName("resourceID"u8);
            writer.WriteStringValue(ResourceId);
            if (ResourceLocation.HasValue)
            {
                writer.WritePropertyName("resourceLocation"u8);
                writer.WriteStringValue(ResourceLocation.Value);
            }
            if (ResourceName != null)
            {
                writer.WritePropertyName("resourceName"u8);
                writer.WriteStringValue(ResourceName);
            }
            if (ResourceType.HasValue)
            {
                writer.WritePropertyName("resourceType"u8);
                writer.WriteStringValue(ResourceType.Value);
            }
            if (ResourceUriString != null)
            {
                writer.WritePropertyName("resourceUri"u8);
                writer.WriteStringValue(ResourceUriString);
            }
            if (ResourceProperties != null)
            {
                writer.WritePropertyName("resourceProperties"u8);
                writer.WriteObjectValue(ResourceProperties);
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

        DataSourceSetInfo IJsonModel<DataSourceSetInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourceSetInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataSourceSetInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataSourceSetInfo(document.RootElement, options);
        }

        internal static DataSourceSetInfo DeserializeDataSourceSetInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> datasourceType = default;
            Optional<string> objectType = default;
            ResourceIdentifier resourceId = default;
            Optional<AzureLocation> resourceLocation = default;
            Optional<string> resourceName = default;
            Optional<ResourceType> resourceType = default;
            Optional<string> resourceUri = default;
            Optional<BaseResourceProperties> resourceProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("datasourceType"u8))
                {
                    datasourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceID"u8))
                {
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceName"u8))
                {
                    resourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceType = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceUri"u8))
                {
                    resourceUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceProperties = BaseResourceProperties.DeserializeBaseResourceProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataSourceSetInfo(
                datasourceType.Value,
                objectType.Value,
                resourceId,
                Optional.ToNullable(resourceLocation),
                resourceName.Value,
                Optional.ToNullable(resourceType),
                resourceUri.Value,
                resourceProperties.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataSourceSetInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourceSetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataSourceSetInfo)} does not support '{options.Format}' format.");
            }
        }

        DataSourceSetInfo IPersistableModel<DataSourceSetInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataSourceSetInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataSourceSetInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataSourceSetInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataSourceSetInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
