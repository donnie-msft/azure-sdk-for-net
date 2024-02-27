// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class DeletedManagedHsmProperties : IUtf8JsonSerializable, IJsonModel<DeletedManagedHsmProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeletedManagedHsmProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DeletedManagedHsmProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedManagedHsmProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeletedManagedHsmProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ManagedHsmId != null)
            {
                writer.WritePropertyName("mhsmId"u8);
                writer.WriteStringValue(ManagedHsmId);
            }
            if (options.Format != "W" && Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (options.Format != "W" && DeletedOn.HasValue)
            {
                writer.WritePropertyName("deletionDate"u8);
                writer.WriteStringValue(DeletedOn.Value, "O");
            }
            if (options.Format != "W" && ScheduledPurgeOn.HasValue)
            {
                writer.WritePropertyName("scheduledPurgeDate"u8);
                writer.WriteStringValue(ScheduledPurgeOn.Value, "O");
            }
            if (options.Format != "W" && PurgeProtectionEnabled.HasValue)
            {
                writer.WritePropertyName("purgeProtectionEnabled"u8);
                writer.WriteBooleanValue(PurgeProtectionEnabled.Value);
            }
            if (options.Format != "W" && !(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
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

        DeletedManagedHsmProperties IJsonModel<DeletedManagedHsmProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedManagedHsmProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeletedManagedHsmProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeletedManagedHsmProperties(document.RootElement, options);
        }

        internal static DeletedManagedHsmProperties DeserializeDeletedManagedHsmProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> managedHsmId = default;
            Optional<AzureLocation> location = default;
            Optional<DateTimeOffset> deletionDate = default;
            Optional<DateTimeOffset> scheduledPurgeDate = default;
            Optional<bool> purgeProtectionEnabled = default;
            IReadOnlyDictionary<string, string> tags = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("mhsmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedHsmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deletionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deletionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("scheduledPurgeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scheduledPurgeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("purgeProtectionEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    purgeProtectionEnabled = property.Value.GetBoolean();
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
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DeletedManagedHsmProperties(
                managedHsmId.Value,
                Optional.ToNullable(location),
                Optional.ToNullable(deletionDate),
                Optional.ToNullable(scheduledPurgeDate),
                Optional.ToNullable(purgeProtectionEnabled),
                tags ?? new ChangeTrackingDictionary<string, string>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DeletedManagedHsmProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedManagedHsmProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DeletedManagedHsmProperties)} does not support '{options.Format}' format.");
            }
        }

        DeletedManagedHsmProperties IPersistableModel<DeletedManagedHsmProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeletedManagedHsmProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDeletedManagedHsmProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeletedManagedHsmProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeletedManagedHsmProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
