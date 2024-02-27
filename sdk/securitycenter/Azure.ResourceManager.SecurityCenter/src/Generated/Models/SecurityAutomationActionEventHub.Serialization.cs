// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityAutomationActionEventHub : IUtf8JsonSerializable, IJsonModel<SecurityAutomationActionEventHub>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityAutomationActionEventHub>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityAutomationActionEventHub>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAutomationActionEventHub>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAutomationActionEventHub)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (EventHubResourceId != null)
            {
                writer.WritePropertyName("eventHubResourceId"u8);
                writer.WriteStringValue(EventHubResourceId);
            }
            if (options.Format != "W" && SasPolicyName != null)
            {
                writer.WritePropertyName("sasPolicyName"u8);
                writer.WriteStringValue(SasPolicyName);
            }
            if (ConnectionString != null)
            {
                writer.WritePropertyName("connectionString"u8);
                writer.WriteStringValue(ConnectionString);
            }
            writer.WritePropertyName("actionType"u8);
            writer.WriteStringValue(ActionType.ToString());
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

        SecurityAutomationActionEventHub IJsonModel<SecurityAutomationActionEventHub>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAutomationActionEventHub>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SecurityAutomationActionEventHub)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAutomationActionEventHub(document.RootElement, options);
        }

        internal static SecurityAutomationActionEventHub DeserializeSecurityAutomationActionEventHub(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> eventHubResourceId = default;
            Optional<string> sasPolicyName = default;
            Optional<string> connectionString = default;
            ActionType actionType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("eventHubResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    eventHubResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sasPolicyName"u8))
                {
                    sasPolicyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionString"u8))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionType"u8))
                {
                    actionType = new ActionType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityAutomationActionEventHub(actionType, serializedAdditionalRawData, eventHubResourceId.Value, sasPolicyName.Value, connectionString.Value);
        }

        BinaryData IPersistableModel<SecurityAutomationActionEventHub>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAutomationActionEventHub>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SecurityAutomationActionEventHub)} does not support '{options.Format}' format.");
            }
        }

        SecurityAutomationActionEventHub IPersistableModel<SecurityAutomationActionEventHub>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SecurityAutomationActionEventHub>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSecurityAutomationActionEventHub(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SecurityAutomationActionEventHub)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SecurityAutomationActionEventHub>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
