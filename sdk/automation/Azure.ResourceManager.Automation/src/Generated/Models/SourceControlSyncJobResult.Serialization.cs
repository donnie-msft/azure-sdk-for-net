// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class SourceControlSyncJobResult : IUtf8JsonSerializable, IJsonModel<SourceControlSyncJobResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceControlSyncJobResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SourceControlSyncJobResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlSyncJobResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlSyncJobResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (SourceControlSyncJobId != null)
            {
                writer.WritePropertyName("sourceControlSyncJobId"u8);
                writer.WriteStringValue(SourceControlSyncJobId);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && StartOn.HasValue)
            {
                if (StartOn != null)
                {
                    writer.WritePropertyName("startTime"u8);
                    writer.WriteStringValue(StartOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("startTime");
                }
            }
            if (options.Format != "W" && EndOn.HasValue)
            {
                if (EndOn != null)
                {
                    writer.WritePropertyName("endTime"u8);
                    writer.WriteStringValue(EndOn.Value, "O");
                }
                else
                {
                    writer.WriteNull("endTime");
                }
            }
            if (SyncType.HasValue)
            {
                writer.WritePropertyName("syncType"u8);
                writer.WriteStringValue(SyncType.Value.ToString());
            }
            if (Exception != null)
            {
                writer.WritePropertyName("exception"u8);
                writer.WriteStringValue(Exception);
            }
            writer.WriteEndObject();
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

        SourceControlSyncJobResult IJsonModel<SourceControlSyncJobResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlSyncJobResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlSyncJobResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceControlSyncJobResult(document.RootElement, options);
        }

        internal static SourceControlSyncJobResult DeserializeSourceControlSyncJobResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> sourceControlSyncJobId = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<SourceControlProvisioningState> provisioningState = default;
            Optional<DateTimeOffset?> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            Optional<SourceControlSyncType> syncType = default;
            Optional<string> exception = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("sourceControlSyncJobId"u8))
                        {
                            sourceControlSyncJobId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new SourceControlProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                startTime = null;
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                endTime = null;
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("syncType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            syncType = new SourceControlSyncType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("exception"u8))
                        {
                            exception = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SourceControlSyncJobResult(
                id.Value,
                sourceControlSyncJobId.Value,
                Optional.ToNullable(creationTime),
                Optional.ToNullable(provisioningState),
                Optional.ToNullable(startTime),
                Optional.ToNullable(endTime),
                Optional.ToNullable(syncType),
                exception.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SourceControlSyncJobResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlSyncJobResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SourceControlSyncJobResult)} does not support '{options.Format}' format.");
            }
        }

        SourceControlSyncJobResult IPersistableModel<SourceControlSyncJobResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlSyncJobResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceControlSyncJobResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceControlSyncJobResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceControlSyncJobResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
