// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxShippingAddress : IUtf8JsonSerializable, IJsonModel<DataBoxShippingAddress>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxShippingAddress>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxShippingAddress>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxShippingAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxShippingAddress)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("streetAddress1"u8);
            writer.WriteStringValue(StreetAddress1);
            if (StreetAddress2 != null)
            {
                writer.WritePropertyName("streetAddress2"u8);
                writer.WriteStringValue(StreetAddress2);
            }
            if (StreetAddress3 != null)
            {
                writer.WritePropertyName("streetAddress3"u8);
                writer.WriteStringValue(StreetAddress3);
            }
            if (City != null)
            {
                writer.WritePropertyName("city"u8);
                writer.WriteStringValue(City);
            }
            if (StateOrProvince != null)
            {
                writer.WritePropertyName("stateOrProvince"u8);
                writer.WriteStringValue(StateOrProvince);
            }
            writer.WritePropertyName("country"u8);
            writer.WriteStringValue(Country);
            writer.WritePropertyName("postalCode"u8);
            writer.WriteStringValue(PostalCode);
            if (ZipExtendedCode != null)
            {
                writer.WritePropertyName("zipExtendedCode"u8);
                writer.WriteStringValue(ZipExtendedCode);
            }
            if (CompanyName != null)
            {
                writer.WritePropertyName("companyName"u8);
                writer.WriteStringValue(CompanyName);
            }
            if (AddressType.HasValue)
            {
                writer.WritePropertyName("addressType"u8);
                writer.WriteStringValue(AddressType.Value.ToSerialString());
            }
            if (SkipAddressValidation.HasValue)
            {
                writer.WritePropertyName("skipAddressValidation"u8);
                writer.WriteBooleanValue(SkipAddressValidation.Value);
            }
            if (TaxIdentificationNumber != null)
            {
                writer.WritePropertyName("taxIdentificationNumber"u8);
                writer.WriteStringValue(TaxIdentificationNumber);
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

        DataBoxShippingAddress IJsonModel<DataBoxShippingAddress>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxShippingAddress>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxShippingAddress)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxShippingAddress(document.RootElement, options);
        }

        internal static DataBoxShippingAddress DeserializeDataBoxShippingAddress(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string streetAddress1 = default;
            Optional<string> streetAddress2 = default;
            Optional<string> streetAddress3 = default;
            Optional<string> city = default;
            Optional<string> stateOrProvince = default;
            string country = default;
            string postalCode = default;
            Optional<string> zipExtendedCode = default;
            Optional<string> companyName = default;
            Optional<DataBoxShippingAddressType> addressType = default;
            Optional<bool> skipAddressValidation = default;
            Optional<string> taxIdentificationNumber = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("streetAddress1"u8))
                {
                    streetAddress1 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress2"u8))
                {
                    streetAddress2 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("streetAddress3"u8))
                {
                    streetAddress3 = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("city"u8))
                {
                    city = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("stateOrProvince"u8))
                {
                    stateOrProvince = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("postalCode"u8))
                {
                    postalCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("zipExtendedCode"u8))
                {
                    zipExtendedCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("companyName"u8))
                {
                    companyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("addressType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    addressType = property.Value.GetString().ToDataBoxShippingAddressType();
                    continue;
                }
                if (property.NameEquals("skipAddressValidation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    skipAddressValidation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("taxIdentificationNumber"u8))
                {
                    taxIdentificationNumber = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DataBoxShippingAddress(
                streetAddress1,
                streetAddress2.Value,
                streetAddress3.Value,
                city.Value,
                stateOrProvince.Value,
                country,
                postalCode,
                zipExtendedCode.Value,
                companyName.Value,
                Optional.ToNullable(addressType),
                Optional.ToNullable(skipAddressValidation),
                taxIdentificationNumber.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxShippingAddress>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxShippingAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxShippingAddress)} does not support '{options.Format}' format.");
            }
        }

        DataBoxShippingAddress IPersistableModel<DataBoxShippingAddress>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxShippingAddress>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxShippingAddress(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxShippingAddress)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxShippingAddress>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
