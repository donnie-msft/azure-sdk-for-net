// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class ContainerAppDaprConfiguration : IUtf8JsonSerializable, IJsonModel<ContainerAppDaprConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerAppDaprConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContainerAppDaprConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDaprConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDaprConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsEnabled.HasValue)
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            if (AppId != null)
            {
                writer.WritePropertyName("appId"u8);
                writer.WriteStringValue(AppId);
            }
            if (AppProtocol.HasValue)
            {
                writer.WritePropertyName("appProtocol"u8);
                writer.WriteStringValue(AppProtocol.Value.ToString());
            }
            if (AppPort.HasValue)
            {
                writer.WritePropertyName("appPort"u8);
                writer.WriteNumberValue(AppPort.Value);
            }
            if (HttpReadBufferSize.HasValue)
            {
                writer.WritePropertyName("httpReadBufferSize"u8);
                writer.WriteNumberValue(HttpReadBufferSize.Value);
            }
            if (HttpMaxRequestSize.HasValue)
            {
                writer.WritePropertyName("httpMaxRequestSize"u8);
                writer.WriteNumberValue(HttpMaxRequestSize.Value);
            }
            if (LogLevel.HasValue)
            {
                writer.WritePropertyName("logLevel"u8);
                writer.WriteStringValue(LogLevel.Value.ToString());
            }
            if (IsApiLoggingEnabled.HasValue)
            {
                writer.WritePropertyName("enableApiLogging"u8);
                writer.WriteBooleanValue(IsApiLoggingEnabled.Value);
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

        ContainerAppDaprConfiguration IJsonModel<ContainerAppDaprConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDaprConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerAppDaprConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerAppDaprConfiguration(document.RootElement, options);
        }

        internal static ContainerAppDaprConfiguration DeserializeContainerAppDaprConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> enabled = default;
            Optional<string> appId = default;
            Optional<ContainerAppProtocol> appProtocol = default;
            Optional<int> appPort = default;
            Optional<int> httpReadBufferSize = default;
            Optional<int> httpMaxRequestSize = default;
            Optional<ContainerAppDaprLogLevel> logLevel = default;
            Optional<bool> enableApiLogging = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("appId"u8))
                {
                    appId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("appProtocol"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appProtocol = new ContainerAppProtocol(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("appPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    appPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpReadBufferSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpReadBufferSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpMaxRequestSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    httpMaxRequestSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("logLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    logLevel = new ContainerAppDaprLogLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("enableApiLogging"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableApiLogging = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContainerAppDaprConfiguration(
                Optional.ToNullable(enabled),
                appId.Value,
                Optional.ToNullable(appProtocol),
                Optional.ToNullable(appPort),
                Optional.ToNullable(httpReadBufferSize),
                Optional.ToNullable(httpMaxRequestSize),
                Optional.ToNullable(logLevel),
                Optional.ToNullable(enableApiLogging),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContainerAppDaprConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDaprConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDaprConfiguration)} does not support '{options.Format}' format.");
            }
        }

        ContainerAppDaprConfiguration IPersistableModel<ContainerAppDaprConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerAppDaprConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContainerAppDaprConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerAppDaprConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerAppDaprConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
