// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    internal partial class UnknownCertificateProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformCertificateProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformCertificateProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AppPlatformCertificateProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformCertificateProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CertificatePropertiesType);
            if (options.Format != "W" && Thumbprint != null)
            {
                writer.WritePropertyName("thumbprint"u8);
                writer.WriteStringValue(Thumbprint);
            }
            if (options.Format != "W" && Issuer != null)
            {
                writer.WritePropertyName("issuer"u8);
                writer.WriteStringValue(Issuer);
            }
            if (options.Format != "W" && IssuedOn.HasValue)
            {
                writer.WritePropertyName("issuedDate"u8);
                writer.WriteStringValue(IssuedOn.Value, "O");
            }
            if (options.Format != "W" && ExpireOn.HasValue)
            {
                writer.WritePropertyName("expirationDate"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
            }
            if (options.Format != "W" && ActivateOn.HasValue)
            {
                writer.WritePropertyName("activateDate"u8);
                writer.WriteStringValue(ActivateOn.Value, "O");
            }
            if (options.Format != "W" && SubjectName != null)
            {
                writer.WritePropertyName("subjectName"u8);
                writer.WriteStringValue(SubjectName);
            }
            if (options.Format != "W" && !(DnsNames is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("dnsNames"u8);
                writer.WriteStartArray();
                foreach (var item in DnsNames)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
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

        AppPlatformCertificateProperties IJsonModel<AppPlatformCertificateProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AppPlatformCertificateProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformCertificateProperties(document.RootElement, options);
        }

        internal static UnknownCertificateProperties DeserializeUnknownCertificateProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = "Unknown";
            Optional<string> thumbprint = default;
            Optional<string> issuer = default;
            Optional<DateTimeOffset> issuedDate = default;
            Optional<DateTimeOffset> expirationDate = default;
            Optional<DateTimeOffset> activateDate = default;
            Optional<string> subjectName = default;
            IReadOnlyList<string> dnsNames = default;
            Optional<AppPlatformCertificateProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("thumbprint"u8))
                {
                    thumbprint = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("issuedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    issuedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("expirationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expirationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activateDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activateDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("subjectName"u8))
                {
                    subjectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsNames"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    dnsNames = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformCertificateProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownCertificateProperties(
                type,
                thumbprint.Value,
                issuer.Value,
                Optional.ToNullable(issuedDate),
                Optional.ToNullable(expirationDate),
                Optional.ToNullable(activateDate),
                subjectName.Value,
                dnsNames ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(provisioningState),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformCertificateProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AppPlatformCertificateProperties)} does not support '{options.Format}' format.");
            }
        }

        AppPlatformCertificateProperties IPersistableModel<AppPlatformCertificateProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AppPlatformCertificateProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAppPlatformCertificateProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AppPlatformCertificateProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AppPlatformCertificateProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
