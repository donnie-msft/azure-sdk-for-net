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
    public partial class CosmosDBIncludedPath : IUtf8JsonSerializable, IJsonModel<CosmosDBIncludedPath>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CosmosDBIncludedPath>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CosmosDBIncludedPath>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIncludedPath>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBIncludedPath)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Path != null)
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (!(Indexes is ChangeTrackingList<CosmosDBPathIndexes> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("indexes"u8);
                writer.WriteStartArray();
                foreach (var item in Indexes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        CosmosDBIncludedPath IJsonModel<CosmosDBIncludedPath>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIncludedPath>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CosmosDBIncludedPath)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCosmosDBIncludedPath(document.RootElement, options);
        }

        internal static CosmosDBIncludedPath DeserializeCosmosDBIncludedPath(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> path = default;
            IList<CosmosDBPathIndexes> indexes = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"u8))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("indexes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CosmosDBPathIndexes> array = new List<CosmosDBPathIndexes>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CosmosDBPathIndexes.DeserializeCosmosDBPathIndexes(item, options));
                    }
                    indexes = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CosmosDBIncludedPath(path.Value, indexes ?? new ChangeTrackingList<CosmosDBPathIndexes>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<CosmosDBIncludedPath>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIncludedPath>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CosmosDBIncludedPath)} does not support '{options.Format}' format.");
            }
        }

        CosmosDBIncludedPath IPersistableModel<CosmosDBIncludedPath>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CosmosDBIncludedPath>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCosmosDBIncludedPath(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CosmosDBIncludedPath)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<CosmosDBIncludedPath>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
