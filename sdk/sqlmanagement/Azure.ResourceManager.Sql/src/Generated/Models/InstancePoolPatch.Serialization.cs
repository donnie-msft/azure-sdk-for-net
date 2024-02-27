// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class InstancePoolPatch : IUtf8JsonSerializable, IJsonModel<InstancePoolPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InstancePoolPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InstancePoolPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstancePoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstancePoolPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Sku != null)
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (SubnetId != null)
            {
                writer.WritePropertyName("subnetId"u8);
                writer.WriteStringValue(SubnetId);
            }
            if (VCores.HasValue)
            {
                writer.WritePropertyName("vCores"u8);
                writer.WriteNumberValue(VCores.Value);
            }
            if (LicenseType.HasValue)
            {
                writer.WritePropertyName("licenseType"u8);
                writer.WriteStringValue(LicenseType.Value.ToString());
            }
            if (options.Format != "W" && DnsZone != null)
            {
                writer.WritePropertyName("dnsZone"u8);
                writer.WriteStringValue(DnsZone);
            }
            if (MaintenanceConfigurationId != null)
            {
                writer.WritePropertyName("maintenanceConfigurationId"u8);
                writer.WriteStringValue(MaintenanceConfigurationId);
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

        InstancePoolPatch IJsonModel<InstancePoolPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstancePoolPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InstancePoolPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInstancePoolPatch(document.RootElement, options);
        }

        internal static InstancePoolPatch DeserializeInstancePoolPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SqlSku> sku = default;
            IDictionary<string, string> tags = default;
            Optional<ResourceIdentifier> subnetId = default;
            Optional<int> vCores = default;
            Optional<InstancePoolLicenseType> licenseType = default;
            Optional<string> dnsZone = default;
            Optional<ResourceIdentifier> maintenanceConfigurationId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = SqlSku.DeserializeSqlSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("tags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
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
                        if (property0.NameEquals("subnetId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            subnetId = new ResourceIdentifier(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("vCores"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            vCores = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("licenseType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseType = new InstancePoolLicenseType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("dnsZone"u8))
                        {
                            dnsZone = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("maintenanceConfigurationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maintenanceConfigurationId = new ResourceIdentifier(property0.Value.GetString());
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
            return new InstancePoolPatch(
                sku.Value,
                tags ?? new ChangeTrackingDictionary<string, string>(),
                subnetId.Value,
                Optional.ToNullable(vCores),
                Optional.ToNullable(licenseType),
                dnsZone.Value,
                maintenanceConfigurationId.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InstancePoolPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstancePoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(InstancePoolPatch)} does not support '{options.Format}' format.");
            }
        }

        InstancePoolPatch IPersistableModel<InstancePoolPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<InstancePoolPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeInstancePoolPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InstancePoolPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<InstancePoolPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
