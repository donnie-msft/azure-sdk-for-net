// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class ClusterServiceConfigResult : IUtf8JsonSerializable, IJsonModel<ClusterServiceConfigResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterServiceConfigResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterServiceConfigResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServiceConfigResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterServiceConfigResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (ServiceName != null)
            {
                writer.WritePropertyName("serviceName"u8);
                writer.WriteStringValue(ServiceName);
            }
            if (FileName != null)
            {
                writer.WritePropertyName("fileName"u8);
                writer.WriteStringValue(FileName);
            }
            if (Content != null)
            {
                writer.WritePropertyName("content"u8);
                writer.WriteStringValue(Content);
            }
            if (ComponentName != null)
            {
                writer.WritePropertyName("componentName"u8);
                writer.WriteStringValue(ComponentName);
            }
            if (ServiceConfigListResultPropertiesType != null)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ServiceConfigListResultPropertiesType);
            }
            if (Path != null)
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (!(CustomKeys is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("customKeys"u8);
                writer.WriteStartObject();
                foreach (var item in CustomKeys)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(DefaultKeys is ChangeTrackingDictionary<string, ClusterServiceConfigValueEntity> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("defaultKeys"u8);
                writer.WriteStartObject();
                foreach (var item in DefaultKeys)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
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

        ClusterServiceConfigResult IJsonModel<ClusterServiceConfigResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServiceConfigResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterServiceConfigResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterServiceConfigResult(document.RootElement, options);
        }

        internal static ClusterServiceConfigResult DeserializeClusterServiceConfigResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> serviceName = default;
            Optional<string> fileName = default;
            Optional<string> content = default;
            Optional<string> componentName = default;
            Optional<string> type = default;
            Optional<string> path = default;
            IReadOnlyDictionary<string, string> customKeys = default;
            IReadOnlyDictionary<string, ClusterServiceConfigValueEntity> defaultKeys = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("serviceName"u8))
                        {
                            serviceName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fileName"u8))
                        {
                            fileName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("content"u8))
                        {
                            content = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("componentName"u8))
                        {
                            componentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("type"u8))
                        {
                            type = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("path"u8))
                        {
                            path = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("customKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            customKeys = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("defaultKeys"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, ClusterServiceConfigValueEntity> dictionary = new Dictionary<string, ClusterServiceConfigValueEntity>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ClusterServiceConfigValueEntity.DeserializeClusterServiceConfigValueEntity(property1.Value, options));
                            }
                            defaultKeys = dictionary;
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
            return new ClusterServiceConfigResult(
                serviceName.Value,
                fileName.Value,
                content.Value,
                componentName.Value,
                type.Value,
                path.Value,
                customKeys ?? new ChangeTrackingDictionary<string, string>(),
                defaultKeys ?? new ChangeTrackingDictionary<string, ClusterServiceConfigValueEntity>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterServiceConfigResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServiceConfigResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterServiceConfigResult)} does not support '{options.Format}' format.");
            }
        }

        ClusterServiceConfigResult IPersistableModel<ClusterServiceConfigResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterServiceConfigResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterServiceConfigResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterServiceConfigResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterServiceConfigResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
