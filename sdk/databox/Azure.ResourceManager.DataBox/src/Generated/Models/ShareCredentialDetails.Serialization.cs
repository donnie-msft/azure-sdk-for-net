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
    public partial class ShareCredentialDetails : IUtf8JsonSerializable, IJsonModel<ShareCredentialDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ShareCredentialDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ShareCredentialDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareCredentialDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareCredentialDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && ShareName != null)
            {
                writer.WritePropertyName("shareName"u8);
                writer.WriteStringValue(ShareName);
            }
            if (options.Format != "W" && ShareType.HasValue)
            {
                writer.WritePropertyName("shareType"u8);
                writer.WriteStringValue(ShareType.Value.ToSerialString());
            }
            if (options.Format != "W" && UserName != null)
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteStringValue(UserName);
            }
            if (options.Format != "W" && Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteStringValue(Password);
            }
            if (options.Format != "W" && !(SupportedAccessProtocols is ChangeTrackingList<DataBoxAccessProtocol> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("supportedAccessProtocols"u8);
                writer.WriteStartArray();
                foreach (var item in SupportedAccessProtocols)
                {
                    writer.WriteStringValue(item.ToSerialString());
                }
                writer.WriteEndArray();
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

        ShareCredentialDetails IJsonModel<ShareCredentialDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareCredentialDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ShareCredentialDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeShareCredentialDetails(document.RootElement, options);
        }

        internal static ShareCredentialDetails DeserializeShareCredentialDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> shareName = default;
            Optional<ShareDestinationFormatType> shareType = default;
            Optional<string> userName = default;
            Optional<string> password = default;
            IReadOnlyList<DataBoxAccessProtocol> supportedAccessProtocols = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shareName"u8))
                {
                    shareName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shareType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shareType = property.Value.GetString().ToShareDestinationFormatType();
                    continue;
                }
                if (property.NameEquals("userName"u8))
                {
                    userName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("password"u8))
                {
                    password = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("supportedAccessProtocols"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxAccessProtocol> array = new List<DataBoxAccessProtocol>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString().ToDataBoxAccessProtocol());
                    }
                    supportedAccessProtocols = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ShareCredentialDetails(
                shareName.Value,
                Optional.ToNullable(shareType),
                userName.Value,
                password.Value,
                supportedAccessProtocols ?? new ChangeTrackingList<DataBoxAccessProtocol>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ShareCredentialDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareCredentialDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ShareCredentialDetails)} does not support '{options.Format}' format.");
            }
        }

        ShareCredentialDetails IPersistableModel<ShareCredentialDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ShareCredentialDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeShareCredentialDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ShareCredentialDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ShareCredentialDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
