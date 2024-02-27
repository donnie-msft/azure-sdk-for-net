// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightAutoScaleTimeAndCapacity : IUtf8JsonSerializable, IJsonModel<HDInsightAutoScaleTimeAndCapacity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<HDInsightAutoScaleTimeAndCapacity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<HDInsightAutoScaleTimeAndCapacity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleTimeAndCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleTimeAndCapacity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Time != null)
            {
                writer.WritePropertyName("time"u8);
                writer.WriteStringValue(Time);
            }
            if (MinInstanceCount.HasValue)
            {
                writer.WritePropertyName("minInstanceCount"u8);
                writer.WriteNumberValue(MinInstanceCount.Value);
            }
            if (MaxInstanceCount.HasValue)
            {
                writer.WritePropertyName("maxInstanceCount"u8);
                writer.WriteNumberValue(MaxInstanceCount.Value);
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

        HDInsightAutoScaleTimeAndCapacity IJsonModel<HDInsightAutoScaleTimeAndCapacity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleTimeAndCapacity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(HDInsightAutoScaleTimeAndCapacity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightAutoScaleTimeAndCapacity(document.RootElement, options);
        }

        internal static HDInsightAutoScaleTimeAndCapacity DeserializeHDInsightAutoScaleTimeAndCapacity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> time = default;
            Optional<int> minInstanceCount = default;
            Optional<int> maxInstanceCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("time"u8))
                {
                    time = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxInstanceCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new HDInsightAutoScaleTimeAndCapacity(time.Value, Optional.ToNullable(minInstanceCount), Optional.ToNullable(maxInstanceCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<HDInsightAutoScaleTimeAndCapacity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleTimeAndCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleTimeAndCapacity)} does not support '{options.Format}' format.");
            }
        }

        HDInsightAutoScaleTimeAndCapacity IPersistableModel<HDInsightAutoScaleTimeAndCapacity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<HDInsightAutoScaleTimeAndCapacity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeHDInsightAutoScaleTimeAndCapacity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(HDInsightAutoScaleTimeAndCapacity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<HDInsightAutoScaleTimeAndCapacity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
