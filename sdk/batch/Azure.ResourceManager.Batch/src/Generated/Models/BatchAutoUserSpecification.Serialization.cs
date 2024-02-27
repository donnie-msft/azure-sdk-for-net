// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    public partial class BatchAutoUserSpecification : IUtf8JsonSerializable, IJsonModel<BatchAutoUserSpecification>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchAutoUserSpecification>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BatchAutoUserSpecification>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAutoUserSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAutoUserSpecification)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Scope.HasValue)
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope.Value.ToSerialString());
            }
            if (ElevationLevel.HasValue)
            {
                writer.WritePropertyName("elevationLevel"u8);
                writer.WriteStringValue(ElevationLevel.Value.ToSerialString());
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

        BatchAutoUserSpecification IJsonModel<BatchAutoUserSpecification>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAutoUserSpecification>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchAutoUserSpecification)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchAutoUserSpecification(document.RootElement, options);
        }

        internal static BatchAutoUserSpecification DeserializeBatchAutoUserSpecification(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<BatchAutoUserScope> scope = default;
            Optional<BatchUserAccountElevationLevel> elevationLevel = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scope = property.Value.GetString().ToBatchAutoUserScope();
                    continue;
                }
                if (property.NameEquals("elevationLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    elevationLevel = property.Value.GetString().ToBatchUserAccountElevationLevel();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BatchAutoUserSpecification(Optional.ToNullable(scope), Optional.ToNullable(elevationLevel), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchAutoUserSpecification>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAutoUserSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchAutoUserSpecification)} does not support '{options.Format}' format.");
            }
        }

        BatchAutoUserSpecification IPersistableModel<BatchAutoUserSpecification>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchAutoUserSpecification>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchAutoUserSpecification(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchAutoUserSpecification)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchAutoUserSpecification>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
