// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Maps.Models
{
    public partial class MapsAccountKeys : IUtf8JsonSerializable, IJsonModel<MapsAccountKeys>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MapsAccountKeys>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MapsAccountKeys>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsAccountKeys)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && PrimaryKeyLastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("primaryKeyLastUpdated"u8);
                writer.WriteStringValue(PrimaryKeyLastUpdatedOn.Value, "O");
            }
            if (options.Format != "W" && PrimaryKey != null)
            {
                writer.WritePropertyName("primaryKey"u8);
                writer.WriteStringValue(PrimaryKey);
            }
            if (options.Format != "W" && SecondaryKey != null)
            {
                writer.WritePropertyName("secondaryKey"u8);
                writer.WriteStringValue(SecondaryKey);
            }
            if (options.Format != "W" && SecondaryKeyLastUpdatedOn.HasValue)
            {
                writer.WritePropertyName("secondaryKeyLastUpdated"u8);
                writer.WriteStringValue(SecondaryKeyLastUpdatedOn.Value, "O");
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

        MapsAccountKeys IJsonModel<MapsAccountKeys>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountKeys>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MapsAccountKeys)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMapsAccountKeys(document.RootElement, options);
        }

        internal static MapsAccountKeys DeserializeMapsAccountKeys(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> primaryKeyLastUpdated = default;
            Optional<string> primaryKey = default;
            Optional<string> secondaryKey = default;
            Optional<DateTimeOffset> secondaryKeyLastUpdated = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primaryKeyLastUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryKeyLastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("primaryKey"u8))
                {
                    primaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKey"u8))
                {
                    secondaryKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondaryKeyLastUpdated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    secondaryKeyLastUpdated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MapsAccountKeys(Optional.ToNullable(primaryKeyLastUpdated), primaryKey.Value, secondaryKey.Value, Optional.ToNullable(secondaryKeyLastUpdated), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MapsAccountKeys>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MapsAccountKeys)} does not support '{options.Format}' format.");
            }
        }

        MapsAccountKeys IPersistableModel<MapsAccountKeys>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MapsAccountKeys>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMapsAccountKeys(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MapsAccountKeys)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MapsAccountKeys>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
