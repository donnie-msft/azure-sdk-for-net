// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ManagedClusterPodIdentity : IUtf8JsonSerializable, IJsonModel<ManagedClusterPodIdentity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedClusterPodIdentity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedClusterPodIdentity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPodIdentity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("namespace"u8);
            writer.WriteStringValue(Namespace);
            if (BindingSelector != null)
            {
                writer.WritePropertyName("bindingSelector"u8);
                writer.WriteStringValue(BindingSelector);
            }
            writer.WritePropertyName("identity"u8);
            writer.WriteObjectValue(Identity);
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && ProvisioningInfo != null)
            {
                writer.WritePropertyName("provisioningInfo"u8);
                writer.WriteObjectValue(ProvisioningInfo);
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

        ManagedClusterPodIdentity IJsonModel<ManagedClusterPodIdentity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedClusterPodIdentity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedClusterPodIdentity(document.RootElement, options);
        }

        internal static ManagedClusterPodIdentity DeserializeManagedClusterPodIdentity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string @namespace = default;
            Optional<string> bindingSelector = default;
            ContainerServiceUserAssignedIdentity identity = default;
            Optional<ManagedClusterPodIdentityProvisioningState> provisioningState = default;
            Optional<ManagedClusterPodIdentityProvisioningInfo> provisioningInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("namespace"u8))
                {
                    @namespace = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("bindingSelector"u8))
                {
                    bindingSelector = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    identity = ContainerServiceUserAssignedIdentity.DeserializeContainerServiceUserAssignedIdentity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ManagedClusterPodIdentityProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningInfo = ManagedClusterPodIdentityProvisioningInfo.DeserializeManagedClusterPodIdentityProvisioningInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedClusterPodIdentity(
                name,
                @namespace,
                bindingSelector.Value,
                identity,
                Optional.ToNullable(provisioningState),
                provisioningInfo.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedClusterPodIdentity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPodIdentity)} does not support '{options.Format}' format.");
            }
        }

        ManagedClusterPodIdentity IPersistableModel<ManagedClusterPodIdentity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedClusterPodIdentity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedClusterPodIdentity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedClusterPodIdentity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedClusterPodIdentity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
