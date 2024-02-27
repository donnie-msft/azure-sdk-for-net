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
    public partial class JobStepOutput : IUtf8JsonSerializable, IJsonModel<JobStepOutput>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobStepOutput>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JobStepOutput>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobStepOutput)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (OutputType.HasValue)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(OutputType.Value.ToString());
            }
            if (SubscriptionId.HasValue)
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId.Value);
            }
            if (ResourceGroupName != null)
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            writer.WritePropertyName("serverName"u8);
            writer.WriteStringValue(ServerName);
            writer.WritePropertyName("databaseName"u8);
            writer.WriteStringValue(DatabaseName);
            if (SchemaName != null)
            {
                writer.WritePropertyName("schemaName"u8);
                writer.WriteStringValue(SchemaName);
            }
            writer.WritePropertyName("tableName"u8);
            writer.WriteStringValue(TableName);
            writer.WritePropertyName("credential"u8);
            writer.WriteStringValue(Credential);
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

        JobStepOutput IJsonModel<JobStepOutput>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepOutput>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(JobStepOutput)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobStepOutput(document.RootElement, options);
        }

        internal static JobStepOutput DeserializeJobStepOutput(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JobStepOutputType> type = default;
            Optional<Guid> subscriptionId = default;
            Optional<string> resourceGroupName = default;
            string serverName = default;
            string databaseName = default;
            Optional<string> schemaName = default;
            string tableName = default;
            string credential = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new JobStepOutputType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subscriptionId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("schemaName"u8))
                {
                    schemaName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tableName"u8))
                {
                    tableName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("credential"u8))
                {
                    credential = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JobStepOutput(
                Optional.ToNullable(type),
                Optional.ToNullable(subscriptionId),
                resourceGroupName.Value,
                serverName,
                databaseName,
                schemaName.Value,
                tableName,
                credential,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JobStepOutput>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(JobStepOutput)} does not support '{options.Format}' format.");
            }
        }

        JobStepOutput IPersistableModel<JobStepOutput>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<JobStepOutput>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeJobStepOutput(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(JobStepOutput)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<JobStepOutput>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
