// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Nginx.Models
{
    public partial class NginxConfigurationPackage : IUtf8JsonSerializable, IJsonModel<NginxConfigurationPackage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NginxConfigurationPackage>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NginxConfigurationPackage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxConfigurationPackage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxConfigurationPackage)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Data != null)
            {
                writer.WritePropertyName("data"u8);
                writer.WriteStringValue(Data);
            }
            if (!(ProtectedFiles is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("protectedFiles"u8);
                writer.WriteStartArray();
                foreach (var item in ProtectedFiles)
                {
                    writer.WriteStringValue(item);
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

        NginxConfigurationPackage IJsonModel<NginxConfigurationPackage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxConfigurationPackage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NginxConfigurationPackage)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNginxConfigurationPackage(document.RootElement, options);
        }

        internal static NginxConfigurationPackage DeserializeNginxConfigurationPackage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> data = default;
            IList<string> protectedFiles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("data"u8))
                {
                    data = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectedFiles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    protectedFiles = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NginxConfigurationPackage(data.Value, protectedFiles ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NginxConfigurationPackage>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxConfigurationPackage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NginxConfigurationPackage)} does not support '{options.Format}' format.");
            }
        }

        NginxConfigurationPackage IPersistableModel<NginxConfigurationPackage>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NginxConfigurationPackage>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNginxConfigurationPackage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NginxConfigurationPackage)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NginxConfigurationPackage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
