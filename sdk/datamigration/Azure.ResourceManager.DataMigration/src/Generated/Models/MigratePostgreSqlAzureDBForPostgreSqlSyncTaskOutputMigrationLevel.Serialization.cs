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
    public partial class MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel : IUtf8JsonSerializable, IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
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
            if (options.Format != "W" && SourceServerVersion != null)
            {
                writer.WritePropertyName("sourceServerVersion"u8);
                writer.WriteStringValue(SourceServerVersion);
            }
            if (options.Format != "W" && SourceServer != null)
            {
                writer.WritePropertyName("sourceServer"u8);
                writer.WriteStringValue(SourceServer);
            }
            if (options.Format != "W" && TargetServerVersion != null)
            {
                writer.WritePropertyName("targetServerVersion"u8);
                writer.WriteStringValue(TargetServerVersion);
            }
            if (options.Format != "W" && TargetServer != null)
            {
                writer.WritePropertyName("targetServer"u8);
                writer.WriteStringValue(TargetServer);
            }
            if (options.Format != "W" && SourceServerType.HasValue)
            {
                writer.WritePropertyName("sourceServerType"u8);
                writer.WriteStringValue(SourceServerType.Value.ToString());
            }
            if (options.Format != "W" && TargetServerType.HasValue)
            {
                writer.WritePropertyName("targetServerType"u8);
                writer.WriteStringValue(TargetServerType.Value.ToString());
            }
            if (options.Format != "W" && State.HasValue)
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (DatabaseCount.HasValue)
            {
                writer.WritePropertyName("databaseCount"u8);
                writer.WriteNumberValue(DatabaseCount.Value);
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

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel IJsonModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(document.RootElement, options);
        }

        internal static MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> startedOn = default;
            Optional<DateTimeOffset> endedOn = default;
            Optional<string> sourceServerVersion = default;
            Optional<string> sourceServer = default;
            Optional<string> targetServerVersion = default;
            Optional<string> targetServer = default;
            Optional<ScenarioSource> sourceServerType = default;
            Optional<ScenarioTarget> targetServerType = default;
            Optional<ReplicateMigrationState> state = default;
            Optional<float> databaseCount = default;
            Optional<string> id = default;
            string resultType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                if (property.NameEquals("sourceServerVersion"u8))
                {
                    sourceServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServer"u8))
                {
                    sourceServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServerVersion"u8))
                {
                    targetServerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetServer"u8))
                {
                    targetServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceServerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceServerType = new ScenarioSource(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetServerType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetServerType = new ScenarioTarget(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ReplicateMigrationState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("databaseCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    databaseCount = property.Value.GetSingle();
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
            return new MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(
                id.Value,
                resultType,
                serializedAdditionalRawData,
                Optional.ToNullable(startedOn),
                Optional.ToNullable(endedOn),
                sourceServerVersion.Value,
                sourceServer.Value,
                targetServerVersion.Value,
                targetServer.Value,
                Optional.ToNullable(sourceServerType),
                Optional.ToNullable(targetServerType),
                Optional.ToNullable(state),
                Optional.ToNullable(databaseCount));
        }

        BinaryData IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MigratePostgreSqlAzureDBForPostgreSqlSyncTaskOutputMigrationLevel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
