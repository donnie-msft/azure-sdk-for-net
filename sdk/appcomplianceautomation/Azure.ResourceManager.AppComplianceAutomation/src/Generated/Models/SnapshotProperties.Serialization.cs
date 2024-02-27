// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class SnapshotProperties : IUtf8JsonSerializable, IJsonModel<SnapshotProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SnapshotProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SnapshotProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && SnapshotName != null)
            {
                writer.WritePropertyName("snapshotName"u8);
                writer.WriteStringValue(SnapshotName);
            }
            if (options.Format != "W" && CreatedOn.HasValue)
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && ReportProperties != null)
            {
                writer.WritePropertyName("reportProperties"u8);
                writer.WriteObjectValue(ReportProperties);
            }
            if (options.Format != "W" && ReportSystemData != null)
            {
                writer.WritePropertyName("reportSystemData"u8);
                JsonSerializer.Serialize(writer, ReportSystemData);
            }
            if (options.Format != "W" && !(ComplianceResults is ChangeTrackingList<ComplianceResult> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("complianceResults"u8);
                writer.WriteStartArray();
                foreach (var item in ComplianceResults)
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

        SnapshotProperties IJsonModel<SnapshotProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SnapshotProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSnapshotProperties(document.RootElement, options);
        }

        internal static SnapshotProperties DeserializeSnapshotProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<string> snapshotName = default;
            Optional<DateTimeOffset> createdAt = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<ReportProperties> reportProperties = default;
            Optional<SystemData> reportSystemData = default;
            IReadOnlyList<ComplianceResult> complianceResults = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("snapshotName"u8))
                {
                    snapshotName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createdAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("reportProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportProperties = ReportProperties.DeserializeReportProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("reportSystemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reportSystemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("complianceResults"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ComplianceResult> array = new List<ComplianceResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComplianceResult.DeserializeComplianceResult(item, options));
                    }
                    complianceResults = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SnapshotProperties(
                id.Value,
                snapshotName.Value,
                Optional.ToNullable(createdAt),
                Optional.ToNullable(provisioningState),
                reportProperties.Value,
                reportSystemData,
                complianceResults ?? new ChangeTrackingList<ComplianceResult>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SnapshotProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SnapshotProperties)} does not support '{options.Format}' format.");
            }
        }

        SnapshotProperties IPersistableModel<SnapshotProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSnapshotProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SnapshotProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SnapshotProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
