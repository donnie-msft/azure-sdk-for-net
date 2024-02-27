// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Kusto.Models
{
    public partial class KustoLanguageExtension : IUtf8JsonSerializable, IJsonModel<KustoLanguageExtension>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<KustoLanguageExtension>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<KustoLanguageExtension>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoLanguageExtension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoLanguageExtension)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (LanguageExtensionName.HasValue)
            {
                writer.WritePropertyName("languageExtensionName"u8);
                writer.WriteStringValue(LanguageExtensionName.Value.ToString());
            }
            if (LanguageExtensionImageName.HasValue)
            {
                writer.WritePropertyName("languageExtensionImageName"u8);
                writer.WriteStringValue(LanguageExtensionImageName.Value.ToString());
            }
            if (LanguageExtensionCustomImageName != null)
            {
                writer.WritePropertyName("languageExtensionCustomImageName"u8);
                writer.WriteStringValue(LanguageExtensionCustomImageName);
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

        KustoLanguageExtension IJsonModel<KustoLanguageExtension>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoLanguageExtension>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(KustoLanguageExtension)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeKustoLanguageExtension(document.RootElement, options);
        }

        internal static KustoLanguageExtension DeserializeKustoLanguageExtension(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<KustoLanguageExtensionName> languageExtensionName = default;
            Optional<KustoLanguageExtensionImageName> languageExtensionImageName = default;
            Optional<string> languageExtensionCustomImageName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("languageExtensionName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    languageExtensionName = new KustoLanguageExtensionName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("languageExtensionImageName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    languageExtensionImageName = new KustoLanguageExtensionImageName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("languageExtensionCustomImageName"u8))
                {
                    languageExtensionCustomImageName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new KustoLanguageExtension(Optional.ToNullable(languageExtensionName), Optional.ToNullable(languageExtensionImageName), languageExtensionCustomImageName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<KustoLanguageExtension>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoLanguageExtension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(KustoLanguageExtension)} does not support '{options.Format}' format.");
            }
        }

        KustoLanguageExtension IPersistableModel<KustoLanguageExtension>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<KustoLanguageExtension>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeKustoLanguageExtension(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(KustoLanguageExtension)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<KustoLanguageExtension>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
