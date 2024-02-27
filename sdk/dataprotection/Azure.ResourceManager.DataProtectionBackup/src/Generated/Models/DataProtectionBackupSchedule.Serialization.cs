// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    public partial class DataProtectionBackupSchedule : IUtf8JsonSerializable, IJsonModel<DataProtectionBackupSchedule>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataProtectionBackupSchedule>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataProtectionBackupSchedule>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupSchedule)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("repeatingTimeIntervals"u8);
            writer.WriteStartArray();
            foreach (var item in RepeatingTimeIntervals)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (TimeZone != null)
            {
                writer.WritePropertyName("timeZone"u8);
                writer.WriteStringValue(TimeZone);
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

        DataProtectionBackupSchedule IJsonModel<DataProtectionBackupSchedule>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataProtectionBackupSchedule)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataProtectionBackupSchedule(document.RootElement, options);
        }

        internal static DataProtectionBackupSchedule DeserializeDataProtectionBackupSchedule(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> repeatingTimeIntervals = default;
            Optional<string> timeZone = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("repeatingTimeIntervals"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    repeatingTimeIntervals = array;
                    continue;
                }
                if (property.NameEquals("timeZone"u8))
                {
                    timeZone = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataProtectionBackupSchedule(repeatingTimeIntervals, timeZone.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataProtectionBackupSchedule>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupSchedule)} does not support '{options.Format}' format.");
            }
        }

        DataProtectionBackupSchedule IPersistableModel<DataProtectionBackupSchedule>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataProtectionBackupSchedule>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataProtectionBackupSchedule(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataProtectionBackupSchedule)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataProtectionBackupSchedule>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
