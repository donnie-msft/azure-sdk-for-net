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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class AppServiceVirtualNetworkValidationContent : IUtf8JsonSerializable, IJsonModel<AppServiceVirtualNetworkValidationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppServiceVirtualNetworkValidationContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppServiceVirtualNetworkValidationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceVirtualNetworkValidationContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Kind != null)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && SystemData != null)
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (VnetResourceGroup != null)
            {
                writer.WritePropertyName("vnetResourceGroup"u8);
                writer.WriteStringValue(VnetResourceGroup);
            }
            if (VnetName != null)
            {
                writer.WritePropertyName("vnetName"u8);
                writer.WriteStringValue(VnetName);
            }
            if (VnetSubnetName != null)
            {
                writer.WritePropertyName("vnetSubnetName"u8);
                writer.WriteStringValue(VnetSubnetName);
            }
            if (SubnetResourceId != null)
            {
                writer.WritePropertyName("subnetResourceId"u8);
                writer.WriteStringValue(SubnetResourceId);
            }
            writer.WriteEndObject();
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

        AppServiceVirtualNetworkValidationContent IJsonModel<AppServiceVirtualNetworkValidationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkValidationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppServiceVirtualNetworkValidationContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppServiceVirtualNetworkValidationContent(document.RootElement, options);
        }

        internal static AppServiceVirtualNetworkValidationContent DeserializeAppServiceVirtualNetworkValidationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> vnetResourceGroup = default;
            Optional<string> vnetName = default;
            Optional<string> vnetSubnetName = default;
            Optional<ResourceIdentifier> subnetResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("vnetResourceGroup"u8))
                        {
                            vnetResourceGroup = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vnetName"u8))
                        {
                            vnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vnetSubnetName"u8))
                        {
                            vnetSubnetName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subnetResourceId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetResourceId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppServiceVirtualNetworkValidationContent(
                id,
                name,
                type,
                systemData.Value,
                vnetResourceGroup.Value,
                vnetName.Value,
                vnetSubnetName.Value,
                subnetResourceId.Value,
                kind.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppServiceVirtualNetworkValidationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppServiceVirtualNetworkValidationContent)} does not support '{options.Format}' format.");
            }
        }

        AppServiceVirtualNetworkValidationContent IPersistableModel<AppServiceVirtualNetworkValidationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppServiceVirtualNetworkValidationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppServiceVirtualNetworkValidationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppServiceVirtualNetworkValidationContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppServiceVirtualNetworkValidationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
