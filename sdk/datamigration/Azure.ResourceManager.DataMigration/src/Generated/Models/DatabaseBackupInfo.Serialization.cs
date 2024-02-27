// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class DatabaseBackupInfo : IUtf8JsonSerializable, IJsonModel<DatabaseBackupInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DatabaseBackupInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DatabaseBackupInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseBackupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseBackupInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && DatabaseName != null)
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && BackupType.HasValue)
            {
                writer.WritePropertyName("backupType"u8);
                writer.WriteStringValue(BackupType.Value.ToString());
            }
            if (options.Format != "W" && !(BackupFiles is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("backupFiles"u8);
                writer.WriteStartArray();
                foreach (var item in BackupFiles)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Position.HasValue)
            {
                writer.WritePropertyName("position"u8);
                writer.WriteNumberValue(Position.Value);
            }
            if (options.Format != "W" && IsDamaged.HasValue)
            {
                writer.WritePropertyName("isDamaged"u8);
                writer.WriteBooleanValue(IsDamaged.Value);
            }
            if (options.Format != "W" && IsCompressed.HasValue)
            {
                writer.WritePropertyName("isCompressed"u8);
                writer.WriteBooleanValue(IsCompressed.Value);
            }
            if (options.Format != "W" && FamilyCount.HasValue)
            {
                writer.WritePropertyName("familyCount"u8);
                writer.WriteNumberValue(FamilyCount.Value);
            }
            if (options.Format != "W" && BackupFinishOn.HasValue)
            {
                writer.WritePropertyName("backupFinishDate"u8);
                writer.WriteStringValue(BackupFinishOn.Value, "O");
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

        DatabaseBackupInfo IJsonModel<DatabaseBackupInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseBackupInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DatabaseBackupInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDatabaseBackupInfo(document.RootElement, options);
        }

        internal static DatabaseBackupInfo DeserializeDatabaseBackupInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> databaseName = default;
            Optional<BackupType> backupType = default;
            IReadOnlyList<string> backupFiles = default;
            Optional<int> position = default;
            Optional<bool> isDamaged = default;
            Optional<bool> isCompressed = default;
            Optional<int> familyCount = default;
            Optional<DateTimeOffset> backupFinishDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("backupType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupType = new BackupType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("backupFiles"u8))
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
                    backupFiles = array;
                    continue;
                }
                if (property.NameEquals("position"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    position = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isDamaged"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isDamaged = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isCompressed"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isCompressed = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("familyCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupFinishDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backupFinishDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DatabaseBackupInfo(
                databaseName.Value,
                Optional.ToNullable(backupType),
                backupFiles ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(position),
                Optional.ToNullable(isDamaged),
                Optional.ToNullable(isCompressed),
                Optional.ToNullable(familyCount),
                Optional.ToNullable(backupFinishDate),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DatabaseBackupInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseBackupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DatabaseBackupInfo)} does not support '{options.Format}' format.");
            }
        }

        DatabaseBackupInfo IPersistableModel<DatabaseBackupInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DatabaseBackupInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDatabaseBackupInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DatabaseBackupInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DatabaseBackupInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
