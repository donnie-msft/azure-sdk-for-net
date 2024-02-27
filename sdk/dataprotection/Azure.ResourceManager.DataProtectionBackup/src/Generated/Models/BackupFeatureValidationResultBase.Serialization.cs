// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    [PersistableModelProxy(typeof(UnknownFeatureValidationResponseBase))]
    public partial class BackupFeatureValidationResultBase : IUtf8JsonSerializable, IJsonModel<BackupFeatureValidationResultBase>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupFeatureValidationResultBase>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupFeatureValidationResultBase>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFeatureValidationResultBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupFeatureValidationResultBase)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        BackupFeatureValidationResultBase IJsonModel<BackupFeatureValidationResultBase>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFeatureValidationResultBase>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BackupFeatureValidationResultBase)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupFeatureValidationResultBase(document.RootElement, options);
        }

        internal static BackupFeatureValidationResultBase DeserializeBackupFeatureValidationResultBase(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "FeatureValidationResponse": return BackupFeatureValidationResult.DeserializeBackupFeatureValidationResult(element, options);
                }
            }
            return UnknownFeatureValidationResponseBase.DeserializeUnknownFeatureValidationResponseBase(element, options);
        }

        BinaryData IPersistableModel<BackupFeatureValidationResultBase>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFeatureValidationResultBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BackupFeatureValidationResultBase)} does not support '{options.Format}' format.");
            }
        }

        BackupFeatureValidationResultBase IPersistableModel<BackupFeatureValidationResultBase>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BackupFeatureValidationResultBase>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBackupFeatureValidationResultBase(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BackupFeatureValidationResultBase)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<BackupFeatureValidationResultBase>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
