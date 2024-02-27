// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class UpsertManagedServerOperationStep : IUtf8JsonSerializable, IJsonModel<UpsertManagedServerOperationStep>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpsertManagedServerOperationStep>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<UpsertManagedServerOperationStep>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpsertManagedServerOperationStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpsertManagedServerOperationStep)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Order.HasValue)
            {
                writer.WritePropertyName("order"u8);
                writer.WriteNumberValue(Order.Value);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Status.HasValue)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
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

        UpsertManagedServerOperationStep IJsonModel<UpsertManagedServerOperationStep>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpsertManagedServerOperationStep>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpsertManagedServerOperationStep)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpsertManagedServerOperationStep(document.RootElement, options);
        }

        internal static UpsertManagedServerOperationStep DeserializeUpsertManagedServerOperationStep(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> order = default;
            Optional<string> name = default;
            Optional<UpsertManagedServerOperationStepStatus> status = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("order"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    order = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new UpsertManagedServerOperationStepStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UpsertManagedServerOperationStep(Optional.ToNullable(order), name.Value, Optional.ToNullable(status), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpsertManagedServerOperationStep>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpsertManagedServerOperationStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UpsertManagedServerOperationStep)} does not support '{options.Format}' format.");
            }
        }

        UpsertManagedServerOperationStep IPersistableModel<UpsertManagedServerOperationStep>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpsertManagedServerOperationStep>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUpsertManagedServerOperationStep(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpsertManagedServerOperationStep)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpsertManagedServerOperationStep>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
