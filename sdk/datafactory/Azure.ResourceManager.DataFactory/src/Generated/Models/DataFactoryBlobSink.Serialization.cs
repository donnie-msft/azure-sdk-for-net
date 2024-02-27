// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryBlobSink : IUtf8JsonSerializable, IJsonModel<DataFactoryBlobSink>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataFactoryBlobSink>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataFactoryBlobSink>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryBlobSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryBlobSink)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (BlobWriterOverwriteFiles != null)
            {
                writer.WritePropertyName("blobWriterOverwriteFiles"u8);
                JsonSerializer.Serialize(writer, BlobWriterOverwriteFiles);
            }
            if (BlobWriterDateTimeFormat != null)
            {
                writer.WritePropertyName("blobWriterDateTimeFormat"u8);
                JsonSerializer.Serialize(writer, BlobWriterDateTimeFormat);
            }
            if (BlobWriterAddHeader != null)
            {
                writer.WritePropertyName("blobWriterAddHeader"u8);
                JsonSerializer.Serialize(writer, BlobWriterAddHeader);
            }
            if (CopyBehavior != null)
            {
                writer.WritePropertyName("copyBehavior"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CopyBehavior);
#else
                using (JsonDocument document = JsonDocument.Parse(CopyBehavior))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            if (!(Metadata is ChangeTrackingList<DataFactoryMetadataItemInfo> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CopySinkType);
            if (WriteBatchSize != null)
            {
                writer.WritePropertyName("writeBatchSize"u8);
                JsonSerializer.Serialize(writer, WriteBatchSize);
            }
            if (WriteBatchTimeout != null)
            {
                writer.WritePropertyName("writeBatchTimeout"u8);
                JsonSerializer.Serialize(writer, WriteBatchTimeout);
            }
            if (SinkRetryCount != null)
            {
                writer.WritePropertyName("sinkRetryCount"u8);
                JsonSerializer.Serialize(writer, SinkRetryCount);
            }
            if (SinkRetryWait != null)
            {
                writer.WritePropertyName("sinkRetryWait"u8);
                JsonSerializer.Serialize(writer, SinkRetryWait);
            }
            if (MaxConcurrentConnections != null)
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                JsonSerializer.Serialize(writer, MaxConcurrentConnections);
            }
            if (DisableMetricsCollection != null)
            {
                writer.WritePropertyName("disableMetricsCollection"u8);
                JsonSerializer.Serialize(writer, DisableMetricsCollection);
            }
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        DataFactoryBlobSink IJsonModel<DataFactoryBlobSink>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryBlobSink>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataFactoryBlobSink)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataFactoryBlobSink(document.RootElement, options);
        }

        internal static DataFactoryBlobSink DeserializeDataFactoryBlobSink(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataFactoryElement<bool>> blobWriterOverwriteFiles = default;
            Optional<DataFactoryElement<string>> blobWriterDateTimeFormat = default;
            Optional<DataFactoryElement<bool>> blobWriterAddHeader = default;
            Optional<BinaryData> copyBehavior = default;
            IList<DataFactoryMetadataItemInfo> metadata = default;
            string type = default;
            Optional<DataFactoryElement<int>> writeBatchSize = default;
            Optional<DataFactoryElement<string>> writeBatchTimeout = default;
            Optional<DataFactoryElement<int>> sinkRetryCount = default;
            Optional<DataFactoryElement<string>> sinkRetryWait = default;
            Optional<DataFactoryElement<int>> maxConcurrentConnections = default;
            Optional<DataFactoryElement<bool>> disableMetricsCollection = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blobWriterOverwriteFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobWriterOverwriteFiles = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("blobWriterDateTimeFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobWriterDateTimeFormat = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("blobWriterAddHeader"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blobWriterAddHeader = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("copyBehavior"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    copyBehavior = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataFactoryMetadataItemInfo> array = new List<DataFactoryMetadataItemInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataFactoryMetadataItemInfo.DeserializeDataFactoryMetadataItemInfo(item, options));
                    }
                    metadata = array;
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("writeBatchSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchSize = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("writeBatchTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    writeBatchTimeout = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryCount = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("sinkRetryWait"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sinkRetryWait = JsonSerializer.Deserialize<DataFactoryElement<string>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = JsonSerializer.Deserialize<DataFactoryElement<int>>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("disableMetricsCollection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableMetricsCollection = JsonSerializer.Deserialize<DataFactoryElement<bool>>(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryBlobSink(
                type,
                writeBatchSize.Value,
                writeBatchTimeout.Value,
                sinkRetryCount.Value,
                sinkRetryWait.Value,
                maxConcurrentConnections.Value,
                disableMetricsCollection.Value,
                additionalProperties,
                blobWriterOverwriteFiles.Value,
                blobWriterDateTimeFormat.Value,
                blobWriterAddHeader.Value,
                copyBehavior.Value,
                metadata ?? new ChangeTrackingList<DataFactoryMetadataItemInfo>());
        }

        BinaryData IPersistableModel<DataFactoryBlobSink>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryBlobSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataFactoryBlobSink)} does not support '{options.Format}' format.");
            }
        }

        DataFactoryBlobSink IPersistableModel<DataFactoryBlobSink>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataFactoryBlobSink>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataFactoryBlobSink(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataFactoryBlobSink)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataFactoryBlobSink>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
