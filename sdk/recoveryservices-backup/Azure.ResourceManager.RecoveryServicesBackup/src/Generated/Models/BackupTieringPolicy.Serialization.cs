// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class BackupTieringPolicy : IUtf8JsonSerializable, IJsonModel<BackupTieringPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupTieringPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupTieringPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupTieringPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupTieringPolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (TieringMode.HasValue)
            {
                writer.WritePropertyName("tieringMode"u8);
                writer.WriteStringValue(TieringMode.Value.ToString());
            }
            if (DurationValue.HasValue)
            {
                writer.WritePropertyName("duration"u8);
                writer.WriteNumberValue(DurationValue.Value);
            }
            if (DurationType.HasValue)
            {
                writer.WritePropertyName("durationType"u8);
                writer.WriteStringValue(DurationType.Value.ToString());
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

        BackupTieringPolicy IJsonModel<BackupTieringPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupTieringPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupTieringPolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupTieringPolicy(document.RootElement, options);
        }

        internal static BackupTieringPolicy DeserializeBackupTieringPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TieringMode> tieringMode = default;
            Optional<int> duration = default;
            Optional<RetentionDurationType> durationType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tieringMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tieringMode = new TieringMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("duration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    duration = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("durationType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationType = new RetentionDurationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackupTieringPolicy(Optional.ToNullable(tieringMode), Optional.ToNullable(duration), Optional.ToNullable(durationType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackupTieringPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupTieringPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupTieringPolicy)} does not support '{options.Format}' format.");
            }
        }

        BackupTieringPolicy IPersistableModel<BackupTieringPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupTieringPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupTieringPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupTieringPolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupTieringPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
