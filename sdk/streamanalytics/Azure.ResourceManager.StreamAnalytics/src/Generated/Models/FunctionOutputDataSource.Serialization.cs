// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class FunctionOutputDataSource : IUtf8JsonSerializable, IJsonModel<FunctionOutputDataSource>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionOutputDataSource>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FunctionOutputDataSource>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionOutputDataSource)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(OutputDataSourceType);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (FunctionAppName != null)
            {
                writer.WritePropertyName("functionAppName"u8);
                writer.WriteStringValue(FunctionAppName);
            }
            if (FunctionName != null)
            {
                writer.WritePropertyName("functionName"u8);
                writer.WriteStringValue(FunctionName);
            }
            if (ApiKey != null)
            {
                writer.WritePropertyName("apiKey"u8);
                writer.WriteStringValue(ApiKey);
            }
            if (MaxBatchSize.HasValue)
            {
                writer.WritePropertyName("maxBatchSize"u8);
                writer.WriteNumberValue(MaxBatchSize.Value);
            }
            if (MaxBatchCount.HasValue)
            {
                writer.WritePropertyName("maxBatchCount"u8);
                writer.WriteNumberValue(MaxBatchCount.Value);
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

        FunctionOutputDataSource IJsonModel<FunctionOutputDataSource>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FunctionOutputDataSource)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionOutputDataSource(document.RootElement, options);
        }

        internal static FunctionOutputDataSource DeserializeFunctionOutputDataSource(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            Optional<string> functionAppName = default;
            Optional<string> functionName = default;
            Optional<string> apiKey = default;
            Optional<int> maxBatchSize = default;
            Optional<int> maxBatchCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
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
                        if (property0.NameEquals("functionAppName"u8))
                        {
                            functionAppName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("functionName"u8))
                        {
                            functionName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("apiKey"u8))
                        {
                            apiKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maxBatchSize"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxBatchSize = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("maxBatchCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxBatchCount = property0.Value.GetInt32();
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
            return new FunctionOutputDataSource(
                type,
                serializedAdditionalRawData,
                functionAppName.Value,
                functionName.Value,
                apiKey.Value,
                Optional.ToNullable(maxBatchSize),
                Optional.ToNullable(maxBatchCount));
        }

        BinaryData IPersistableModel<FunctionOutputDataSource>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FunctionOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        FunctionOutputDataSource IPersistableModel<FunctionOutputDataSource>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FunctionOutputDataSource>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFunctionOutputDataSource(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FunctionOutputDataSource)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FunctionOutputDataSource>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
