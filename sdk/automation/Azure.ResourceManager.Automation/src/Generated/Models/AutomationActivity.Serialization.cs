// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Automation.Models
{
    public partial class AutomationActivity : IUtf8JsonSerializable, IJsonModel<AutomationActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AutomationActivity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AutomationActivity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationActivity)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Id != null)
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W" && Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Definition != null)
            {
                writer.WritePropertyName("definition"u8);
                writer.WriteStringValue(Definition);
            }
            if (!(ParameterSets is ChangeTrackingList<AutomationActivityParameterSet> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameterSets"u8);
                writer.WriteStartArray();
                foreach (var item in ParameterSets)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(OutputTypes is ChangeTrackingList<AutomationActivityOutputType> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("outputTypes"u8);
                writer.WriteStartArray();
                foreach (var item in OutputTypes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (CreatedOn.HasValue)
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (LastModifiedOn.HasValue)
            {
                writer.WritePropertyName("lastModifiedTime"u8);
                writer.WriteStringValue(LastModifiedOn.Value, "O");
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        AutomationActivity IJsonModel<AutomationActivity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivity>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AutomationActivity)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAutomationActivity(document.RootElement, options);
        }

        internal static AutomationActivity DeserializeAutomationActivity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> id = default;
            Optional<string> name = default;
            Optional<string> definition = default;
            IReadOnlyList<AutomationActivityParameterSet> parameterSets = default;
            IReadOnlyList<AutomationActivityOutputType> outputTypes = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<DateTimeOffset> lastModifiedTime = default;
            Optional<string> description = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
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
                        if (property0.NameEquals("definition"u8))
                        {
                            definition = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parameterSets"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AutomationActivityParameterSet> array = new List<AutomationActivityParameterSet>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutomationActivityParameterSet.DeserializeAutomationActivityParameterSet(item, options));
                            }
                            parameterSets = array;
                            continue;
                        }
                        if (property0.NameEquals("outputTypes"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<AutomationActivityOutputType> array = new List<AutomationActivityOutputType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(AutomationActivityOutputType.DeserializeAutomationActivityOutputType(item, options));
                            }
                            outputTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("creationTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastModifiedTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
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
            return new AutomationActivity(
                id.Value,
                name.Value,
                definition.Value,
                parameterSets ?? new ChangeTrackingList<AutomationActivityParameterSet>(),
                outputTypes ?? new ChangeTrackingList<AutomationActivityOutputType>(),
                Optional.ToNullable(creationTime),
                Optional.ToNullable(lastModifiedTime),
                description.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AutomationActivity>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AutomationActivity)} does not support '{options.Format}' format.");
            }
        }

        AutomationActivity IPersistableModel<AutomationActivity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AutomationActivity>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAutomationActivity(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AutomationActivity)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AutomationActivity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
