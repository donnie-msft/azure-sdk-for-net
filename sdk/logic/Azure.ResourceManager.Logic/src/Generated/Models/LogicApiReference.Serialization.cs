// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Logic.Models
{
    public partial class LogicApiReference : IUtf8JsonSerializable, IJsonModel<LogicApiReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LogicApiReference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LogicApiReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiReference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (DisplayName != null)
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (IconUri != null)
            {
                writer.WritePropertyName("iconUri"u8);
                writer.WriteStringValue(IconUri.AbsoluteUri);
            }
            if (Swagger != null)
            {
                writer.WritePropertyName("swagger"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(Swagger);
#else
                using (JsonDocument document = JsonDocument.Parse(Swagger))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (BrandColor != null)
            {
                writer.WritePropertyName("brandColor"u8);
                writer.WriteStringValue(BrandColor);
            }
            if (Category.HasValue)
            {
                writer.WritePropertyName("category"u8);
                writer.WriteStringValue(Category.Value.ToString());
            }
            if (IntegrationServiceEnvironment != null)
            {
                writer.WritePropertyName("integrationServiceEnvironment"u8);
                writer.WriteObjectValue(IntegrationServiceEnvironment);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W" && ResourceType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType.Value);
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

        LogicApiReference IJsonModel<LogicApiReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LogicApiReference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLogicApiReference(document.RootElement, options);
        }

        internal static LogicApiReference DeserializeLogicApiReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> displayName = default;
            Optional<string> description = default;
            Optional<Uri> iconUri = default;
            Optional<BinaryData> swagger = default;
            Optional<string> brandColor = default;
            Optional<LogicApiTier> category = default;
            Optional<LogicResourceReference> integrationServiceEnvironment = default;
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<ResourceType> type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("iconUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    iconUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("swagger"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    swagger = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("brandColor"u8))
                {
                    brandColor = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("category"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    category = new LogicApiTier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("integrationServiceEnvironment"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    integrationServiceEnvironment = DeserializeLogicResourceReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LogicApiReference(
                id.Value,
                name.Value,
                Optional.ToNullable(type),
                serializedAdditionalRawData,
                displayName.Value,
                description.Value,
                iconUri.Value,
                swagger.Value,
                brandColor.Value,
                Optional.ToNullable(category),
                integrationServiceEnvironment.Value);
        }

        BinaryData IPersistableModel<LogicApiReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LogicApiReference)} does not support '{options.Format}' format.");
            }
        }

        LogicApiReference IPersistableModel<LogicApiReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LogicApiReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLogicApiReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LogicApiReference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LogicApiReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
