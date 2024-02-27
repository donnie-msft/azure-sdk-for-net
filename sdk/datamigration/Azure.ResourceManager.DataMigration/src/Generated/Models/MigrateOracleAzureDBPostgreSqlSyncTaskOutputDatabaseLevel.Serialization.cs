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
    public partial class MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel : IUtf8JsonSerializable, IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && DatabaseName != null)
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (options.Format != "W" && StartedOn.HasValue)
            {
                writer.WritePropertyName("startedOn"u8);
                writer.WriteStringValue(StartedOn.Value, "O");
            }
            if (options.Format != "W" && EndedOn.HasValue)
            {
                writer.WritePropertyName("endedOn"u8);
                writer.WriteStringValue(EndedOn.Value, "O");
            }
            if (options.Format != "W" && MigrationState.HasValue)
            {
                writer.WritePropertyName("migrationState"u8);
                writer.WriteStringValue(MigrationState.Value.ToString());
            }
            if (options.Format != "W" && IncomingChanges.HasValue)
            {
                writer.WritePropertyName("incomingChanges"u8);
                writer.WriteNumberValue(IncomingChanges.Value);
            }
            if (options.Format != "W" && AppliedChanges.HasValue)
            {
                writer.WritePropertyName("appliedChanges"u8);
                writer.WriteNumberValue(AppliedChanges.Value);
            }
            if (options.Format != "W" && CdcInsertCounter.HasValue)
            {
                writer.WritePropertyName("cdcInsertCounter"u8);
                writer.WriteNumberValue(CdcInsertCounter.Value);
            }
            if (options.Format != "W" && CdcDeleteCounter.HasValue)
            {
                writer.WritePropertyName("cdcDeleteCounter"u8);
                writer.WriteNumberValue(CdcDeleteCounter.Value);
            }
            if (options.Format != "W" && CdcUpdateCounter.HasValue)
            {
                writer.WritePropertyName("cdcUpdateCounter"u8);
                writer.WriteNumberValue(CdcUpdateCounter.Value);
            }
            if (options.Format != "W" && FullLoadCompletedTables.HasValue)
            {
                writer.WritePropertyName("fullLoadCompletedTables"u8);
                writer.WriteNumberValue(FullLoadCompletedTables.Value);
            }
            if (options.Format != "W" && FullLoadLoadingTables.HasValue)
            {
                writer.WritePropertyName("fullLoadLoadingTables"u8);
                writer.WriteNumberValue(FullLoadLoadingTables.Value);
            }
            if (options.Format != "W" && FullLoadQueuedTables.HasValue)
            {
                writer.WritePropertyName("fullLoadQueuedTables"u8);
                writer.WriteNumberValue(FullLoadQueuedTables.Value);
            }
            if (options.Format != "W" && FullLoadErroredTables.HasValue)
            {
                writer.WritePropertyName("fullLoadErroredTables"u8);
                writer.WriteNumberValue(FullLoadErroredTables.Value);
            }
            if (options.Format != "W" && InitializationCompleted.HasValue)
            {
                writer.WritePropertyName("initializationCompleted"u8);
                writer.WriteBooleanValue(InitializationCompleted.Value);
            }
            if (options.Format != "W" && Latency.HasValue)
            {
                writer.WritePropertyName("latency"u8);
                writer.WriteNumberValue(Latency.Value);
            }
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("resultType"u8);
            writer.WriteStringValue(ResultType);
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

        MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel IJsonModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel(document.RootElement, options);
        }

        internal static MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> databaseName = default;
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<SyncDatabaseMigrationReportingState> migrationState = default;
            Optional<long> incomingChanges = default;
            Optional<long> appliedChanges = default;
            Optional<long> cdcInsertCounter = default;
            Optional<long> cdcDeleteCounter = default;
            Optional<long> cdcUpdateCounter = default;
            Optional<long> fullLoadCompletedTables = default;
            Optional<long> fullLoadLoadingTables = default;
            Optional<long> fullLoadQueuedTables = default;
            Optional<long> fullLoadErroredTables = default;
            Optional<bool> initializationCompleted = default;
            Optional<long> latency = default;
            Optional<string> id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endedOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    endedOn = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("migrationState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    migrationState = new SyncDatabaseMigrationReportingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("incomingChanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    incomingChanges = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("appliedChanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appliedChanges = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcInsertCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcInsertCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcDeleteCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcDeleteCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("cdcUpdateCounter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cdcUpdateCounter = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadCompletedTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadCompletedTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadLoadingTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadLoadingTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadQueuedTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadQueuedTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("fullLoadErroredTables"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fullLoadErroredTables = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("initializationCompleted"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initializationCompleted = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("latency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    latency = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resultType"u8))
                {
                    resultType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel(
                id.Value,
                resultType,
                serializedAdditionalRawData,
                databaseName.Value,
                Optional.ToNullable(startedOn),
                Optional.ToNullable(endedOn),
                Optional.ToNullable(migrationState),
                Optional.ToNullable(incomingChanges),
                Optional.ToNullable(appliedChanges),
                Optional.ToNullable(cdcInsertCounter),
                Optional.ToNullable(cdcDeleteCounter),
                Optional.ToNullable(cdcUpdateCounter),
                Optional.ToNullable(fullLoadCompletedTables),
                Optional.ToNullable(fullLoadLoadingTables),
                Optional.ToNullable(fullLoadQueuedTables),
                Optional.ToNullable(fullLoadErroredTables),
                Optional.ToNullable(initializationCompleted),
                Optional.ToNullable(latency));
        }

        BinaryData IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel)} does not support '{options.Format}' format.");
            }
        }

        MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigrateOracleAzureDBPostgreSqlSyncTaskOutputDatabaseLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
