// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyPlayReadyPlayRight : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyPlayReadyPlayRight>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyPlayReadyPlayRight>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContentKeyPolicyPlayReadyPlayRight>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyPlayRight)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (FirstPlayExpiration.HasValue)
            {
                writer.WritePropertyName("firstPlayExpiration"u8);
                writer.WriteStringValue(FirstPlayExpiration.Value, "P");
            }
            if (ScmsRestriction.HasValue)
            {
                writer.WritePropertyName("scmsRestriction"u8);
                writer.WriteNumberValue(ScmsRestriction.Value);
            }
            if (AgcAndColorStripeRestriction.HasValue)
            {
                writer.WritePropertyName("agcAndColorStripeRestriction"u8);
                writer.WriteNumberValue(AgcAndColorStripeRestriction.Value);
            }
            if (ExplicitAnalogTelevisionOutputRestriction != null)
            {
                writer.WritePropertyName("explicitAnalogTelevisionOutputRestriction"u8);
                writer.WriteObjectValue(ExplicitAnalogTelevisionOutputRestriction);
            }
            writer.WritePropertyName("digitalVideoOnlyContentRestriction"u8);
            writer.WriteBooleanValue(HasDigitalVideoOnlyContentRestriction);
            writer.WritePropertyName("imageConstraintForAnalogComponentVideoRestriction"u8);
            writer.WriteBooleanValue(HasImageConstraintForAnalogComponentVideoRestriction);
            writer.WritePropertyName("imageConstraintForAnalogComputerMonitorRestriction"u8);
            writer.WriteBooleanValue(HasImageConstraintForAnalogComputerMonitorRestriction);
            writer.WritePropertyName("allowPassingVideoContentToUnknownOutput"u8);
            writer.WriteStringValue(AllowPassingVideoContentToUnknownOutput.ToString());
            if (UncompressedDigitalVideoOutputProtectionLevel.HasValue)
            {
                writer.WritePropertyName("uncompressedDigitalVideoOpl"u8);
                writer.WriteNumberValue(UncompressedDigitalVideoOutputProtectionLevel.Value);
            }
            if (CompressedDigitalVideoOutputProtectionLevel.HasValue)
            {
                writer.WritePropertyName("compressedDigitalVideoOpl"u8);
                writer.WriteNumberValue(CompressedDigitalVideoOutputProtectionLevel.Value);
            }
            if (AnalogVideoOutputProtectionLevel.HasValue)
            {
                writer.WritePropertyName("analogVideoOpl"u8);
                writer.WriteNumberValue(AnalogVideoOutputProtectionLevel.Value);
            }
            if (CompressedDigitalAudioOutputProtectionLevel.HasValue)
            {
                writer.WritePropertyName("compressedDigitalAudioOpl"u8);
                writer.WriteNumberValue(CompressedDigitalAudioOutputProtectionLevel.Value);
            }
            if (UncompressedDigitalAudioOutputProtectionLevel.HasValue)
            {
                writer.WritePropertyName("uncompressedDigitalAudioOpl"u8);
                writer.WriteNumberValue(UncompressedDigitalAudioOutputProtectionLevel.Value);
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

        ContentKeyPolicyPlayReadyPlayRight IJsonModel<ContentKeyPolicyPlayReadyPlayRight>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyPlayRight)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyPlayReadyPlayRight(document.RootElement, options);
        }

        internal static ContentKeyPolicyPlayReadyPlayRight DeserializeContentKeyPolicyPlayReadyPlayRight(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> firstPlayExpiration = default;
            Optional<int> scmsRestriction = default;
            Optional<int> agcAndColorStripeRestriction = default;
            Optional<ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction> explicitAnalogTelevisionOutputRestriction = default;
            bool digitalVideoOnlyContentRestriction = default;
            bool imageConstraintForAnalogComponentVideoRestriction = default;
            bool imageConstraintForAnalogComputerMonitorRestriction = default;
            ContentKeyPolicyPlayReadyUnknownOutputPassingOption allowPassingVideoContentToUnknownOutput = default;
            Optional<int> uncompressedDigitalVideoOpl = default;
            Optional<int> compressedDigitalVideoOpl = default;
            Optional<int> analogVideoOpl = default;
            Optional<int> compressedDigitalAudioOpl = default;
            Optional<int> uncompressedDigitalAudioOpl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstPlayExpiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstPlayExpiration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("scmsRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scmsRestriction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("agcAndColorStripeRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    agcAndColorStripeRestriction = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("explicitAnalogTelevisionOutputRestriction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    explicitAnalogTelevisionOutputRestriction = ContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction.DeserializeContentKeyPolicyPlayReadyExplicitAnalogTelevisionRestriction(property.Value, options);
                    continue;
                }
                if (property.NameEquals("digitalVideoOnlyContentRestriction"u8))
                {
                    digitalVideoOnlyContentRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("imageConstraintForAnalogComponentVideoRestriction"u8))
                {
                    imageConstraintForAnalogComponentVideoRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("imageConstraintForAnalogComputerMonitorRestriction"u8))
                {
                    imageConstraintForAnalogComputerMonitorRestriction = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("allowPassingVideoContentToUnknownOutput"u8))
                {
                    allowPassingVideoContentToUnknownOutput = new ContentKeyPolicyPlayReadyUnknownOutputPassingOption(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("uncompressedDigitalVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uncompressedDigitalVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compressedDigitalVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressedDigitalVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("analogVideoOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    analogVideoOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("compressedDigitalAudioOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compressedDigitalAudioOpl = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("uncompressedDigitalAudioOpl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    uncompressedDigitalAudioOpl = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContentKeyPolicyPlayReadyPlayRight(
                Optional.ToNullable(firstPlayExpiration),
                Optional.ToNullable(scmsRestriction),
                Optional.ToNullable(agcAndColorStripeRestriction),
                explicitAnalogTelevisionOutputRestriction.Value,
                digitalVideoOnlyContentRestriction,
                imageConstraintForAnalogComponentVideoRestriction,
                imageConstraintForAnalogComputerMonitorRestriction,
                allowPassingVideoContentToUnknownOutput,
                Optional.ToNullable(uncompressedDigitalVideoOpl),
                Optional.ToNullable(compressedDigitalVideoOpl),
                Optional.ToNullable(analogVideoOpl),
                Optional.ToNullable(compressedDigitalAudioOpl),
                Optional.ToNullable(uncompressedDigitalAudioOpl),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyPlayRight)} does not support '{options.Format}' format.");
            }
        }

        ContentKeyPolicyPlayReadyPlayRight IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicyPlayReadyPlayRight(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyPlayReadyPlayRight)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyPlayReadyPlayRight>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
