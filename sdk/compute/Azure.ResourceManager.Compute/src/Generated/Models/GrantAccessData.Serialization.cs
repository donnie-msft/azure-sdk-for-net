// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class GrantAccessData : IUtf8JsonSerializable, IJsonModel<GrantAccessData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GrantAccessData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GrantAccessData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrantAccessData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GrantAccessData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("access"u8);
            writer.WriteStringValue(Access.ToString());
            writer.WritePropertyName("durationInSeconds"u8);
            writer.WriteNumberValue(DurationInSeconds);
            if (GetSecureVmGuestStateSas.HasValue)
            {
                writer.WritePropertyName("getSecureVMGuestStateSAS"u8);
                writer.WriteBooleanValue(GetSecureVmGuestStateSas.Value);
            }
            if (FileFormat.HasValue)
            {
                writer.WritePropertyName("fileFormat"u8);
                writer.WriteStringValue(FileFormat.Value.ToString());
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

        GrantAccessData IJsonModel<GrantAccessData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrantAccessData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GrantAccessData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGrantAccessData(document.RootElement, options);
        }

        internal static GrantAccessData DeserializeGrantAccessData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AccessLevel access = default;
            int durationInSeconds = default;
            Optional<bool> getSecureVmGuestStateSas = default;
            Optional<DiskImageFileFormat> fileFormat = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("access"u8))
                {
                    access = new AccessLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("durationInSeconds"u8))
                {
                    durationInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("getSecureVMGuestStateSAS"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    getSecureVmGuestStateSas = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fileFormat"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileFormat = new DiskImageFileFormat(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GrantAccessData(access, durationInSeconds, Optional.ToNullable(getSecureVmGuestStateSas), Optional.ToNullable(fileFormat), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GrantAccessData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrantAccessData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GrantAccessData)} does not support '{options.Format}' format.");
            }
        }

        GrantAccessData IPersistableModel<GrantAccessData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GrantAccessData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGrantAccessData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GrantAccessData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GrantAccessData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
