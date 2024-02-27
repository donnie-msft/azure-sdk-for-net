// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class VpnConfigurationPatchableProperties : IUtf8JsonSerializable, IJsonModel<VpnConfigurationPatchableProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnConfigurationPatchableProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnConfigurationPatchableProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (NetworkToNetworkInterconnectId != null)
            {
                writer.WritePropertyName("networkToNetworkInterconnectId"u8);
                writer.WriteStringValue(NetworkToNetworkInterconnectId);
            }
            if (PeeringOption.HasValue)
            {
                writer.WritePropertyName("peeringOption"u8);
                writer.WriteStringValue(PeeringOption.Value.ToString());
            }
            if (OptionBProperties != null)
            {
                writer.WritePropertyName("optionBProperties"u8);
                writer.WriteObjectValue(OptionBProperties);
            }
            if (OptionAProperties != null)
            {
                writer.WritePropertyName("optionAProperties"u8);
                writer.WriteObjectValue(OptionAProperties);
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

        VpnConfigurationPatchableProperties IJsonModel<VpnConfigurationPatchableProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnConfigurationPatchableProperties(document.RootElement, options);
        }

        internal static VpnConfigurationPatchableProperties DeserializeVpnConfigurationPatchableProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> networkToNetworkInterconnectId = default;
            Optional<PeeringOption> peeringOption = default;
            Optional<OptionBProperties> optionBProperties = default;
            Optional<VpnConfigurationPatchableOptionAProperties> optionAProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkToNetworkInterconnectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkToNetworkInterconnectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("peeringOption"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    peeringOption = new PeeringOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("optionBProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionBProperties = OptionBProperties.DeserializeOptionBProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("optionAProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    optionAProperties = VpnConfigurationPatchableOptionAProperties.DeserializeVpnConfigurationPatchableOptionAProperties(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnConfigurationPatchableProperties(networkToNetworkInterconnectId.Value, Optional.ToNullable(peeringOption), optionBProperties.Value, optionAProperties.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnConfigurationPatchableProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support '{options.Format}' format.");
            }
        }

        VpnConfigurationPatchableProperties IPersistableModel<VpnConfigurationPatchableProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnConfigurationPatchableProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnConfigurationPatchableProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnConfigurationPatchableProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnConfigurationPatchableProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
