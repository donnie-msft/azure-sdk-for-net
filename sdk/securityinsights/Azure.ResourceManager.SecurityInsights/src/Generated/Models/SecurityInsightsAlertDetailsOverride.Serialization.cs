// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAlertDetailsOverride : IUtf8JsonSerializable, IJsonModel<SecurityInsightsAlertDetailsOverride>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsAlertDetailsOverride>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsAlertDetailsOverride>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlertDetailsOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAlertDetailsOverride)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (AlertDisplayNameFormat != null)
            {
                writer.WritePropertyName("alertDisplayNameFormat"u8);
                writer.WriteStringValue(AlertDisplayNameFormat);
            }
            if (AlertDescriptionFormat != null)
            {
                writer.WritePropertyName("alertDescriptionFormat"u8);
                writer.WriteStringValue(AlertDescriptionFormat);
            }
            if (AlertTacticsColumnName != null)
            {
                writer.WritePropertyName("alertTacticsColumnName"u8);
                writer.WriteStringValue(AlertTacticsColumnName);
            }
            if (AlertSeverityColumnName != null)
            {
                writer.WritePropertyName("alertSeverityColumnName"u8);
                writer.WriteStringValue(AlertSeverityColumnName);
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

        SecurityInsightsAlertDetailsOverride IJsonModel<SecurityInsightsAlertDetailsOverride>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlertDetailsOverride>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAlertDetailsOverride)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAlertDetailsOverride(document.RootElement, options);
        }

        internal static SecurityInsightsAlertDetailsOverride DeserializeSecurityInsightsAlertDetailsOverride(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> alertDisplayNameFormat = default;
            Optional<string> alertDescriptionFormat = default;
            Optional<string> alertTacticsColumnName = default;
            Optional<string> alertSeverityColumnName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alertDisplayNameFormat"u8))
                {
                    alertDisplayNameFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertDescriptionFormat"u8))
                {
                    alertDescriptionFormat = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertTacticsColumnName"u8))
                {
                    alertTacticsColumnName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("alertSeverityColumnName"u8))
                {
                    alertSeverityColumnName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsAlertDetailsOverride(alertDisplayNameFormat.Value, alertDescriptionFormat.Value, alertTacticsColumnName.Value, alertSeverityColumnName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsAlertDetailsOverride>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlertDetailsOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAlertDetailsOverride)} does not support '{options.Format}' format.");
            }
        }

        SecurityInsightsAlertDetailsOverride IPersistableModel<SecurityInsightsAlertDetailsOverride>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityInsightsAlertDetailsOverride>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityInsightsAlertDetailsOverride(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityInsightsAlertDetailsOverride)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityInsightsAlertDetailsOverride>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
