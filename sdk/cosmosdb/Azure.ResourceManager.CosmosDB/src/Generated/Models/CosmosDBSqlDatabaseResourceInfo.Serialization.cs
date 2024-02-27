// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    public partial class CosmosDBSqlDatabaseResourceInfo : IUtf8JsonSerializable, IJsonModel<CosmosDBSqlDatabaseResourceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBSqlDatabaseResourceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBSqlDatabaseResourceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlDatabaseResourceInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(DatabaseName);
            if (RestoreParameters != null)
            {
                writer.WritePropertyName("restoreParameters"u8);
                writer.WriteObjectValue(RestoreParameters);
            }
            if (CreateMode.HasValue)
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
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

        CosmosDBSqlDatabaseResourceInfo IJsonModel<CosmosDBSqlDatabaseResourceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBSqlDatabaseResourceInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBSqlDatabaseResourceInfo(document.RootElement, options);
        }

        internal static CosmosDBSqlDatabaseResourceInfo DeserializeCosmosDBSqlDatabaseResourceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            Optional<ResourceRestoreParameters> restoreParameters = default;
            Optional<CosmosDBAccountCreateMode> createMode = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = ResourceRestoreParameters.DeserializeResourceRestoreParameters(property.Value, options);
                    continue;
                }
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new CosmosDBAccountCreateMode(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBSqlDatabaseResourceInfo(id, restoreParameters.Value, Optional.ToNullable(createMode), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBSqlDatabaseResourceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlDatabaseResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBSqlDatabaseResourceInfo IPersistableModel<CosmosDBSqlDatabaseResourceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBSqlDatabaseResourceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBSqlDatabaseResourceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBSqlDatabaseResourceInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBSqlDatabaseResourceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
