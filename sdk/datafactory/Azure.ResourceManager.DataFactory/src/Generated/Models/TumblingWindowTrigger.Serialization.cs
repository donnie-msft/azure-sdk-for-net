// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class TumblingWindowTrigger : IUtf8JsonSerializable, IJsonModel<TumblingWindowTrigger>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TumblingWindowTrigger>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TumblingWindowTrigger>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TumblingWindowTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TumblingWindowTrigger)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("pipeline"u8);
            writer.WriteObjectValue(Pipeline);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TriggerType);
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (options.Format != "W" && RuntimeState.HasValue)
            {
                writer.WritePropertyName("runtimeState"u8);
                writer.WriteStringValue(RuntimeState.Value.ToString());
            }
            if (!(Annotations is ChangeTrackingList<BinaryData> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item);
#else
                    using (JsonDocument document = JsonDocument.Parse(item))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("frequency"u8);
            writer.WriteStringValue(Frequency.ToString());
            writer.WritePropertyName("interval"u8);
            writer.WriteNumberValue(Interval);
            writer.WritePropertyName("startTime"u8);
            writer.WriteStringValue(StartOn, "O");
            if (EndOn.HasValue)
            {
                writer.WritePropertyName("endTime"u8);
                writer.WriteStringValue(EndOn.Value, "O");
            }
            if (Delay != null)
            {
                writer.WritePropertyName("delay"u8);
                JsonSerializer.Serialize(writer, Delay);
            }
            writer.WritePropertyName("maxConcurrency"u8);
            writer.WriteNumberValue(MaxConcurrency);
            if (RetryPolicy != null)
            {
                writer.WritePropertyName("retryPolicy"u8);
                writer.WriteObjectValue(RetryPolicy);
            }
            if (!(DependsOn is ChangeTrackingList<DependencyReference> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
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
            writer.WriteEndObject();
        }

        TumblingWindowTrigger IJsonModel<TumblingWindowTrigger>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TumblingWindowTrigger>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(TumblingWindowTrigger)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTumblingWindowTrigger(document.RootElement, options);
        }

        internal static TumblingWindowTrigger DeserializeTumblingWindowTrigger(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            TriggerPipelineReference pipeline = default;
            string type = default;
            Optional<string> description = default;
            Optional<DataFactoryTriggerRuntimeState> runtimeState = default;
            IList<BinaryData> annotations = default;
            TumblingWindowFrequency frequency = default;
            int interval = default;
            DateTimeOffset startTime = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<DataFactoryElement<string>> delay = default;
            int maxConcurrency = default;
            Optional<RetryPolicy> retryPolicy = default;
            IList<DependencyReference> dependsOn = default;
            IDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipeline"u8))
                {
                    pipeline = TriggerPipelineReference.DeserializeTriggerPipelineReference(property.Value, options);
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("runtimeState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeState = new DataFactoryTriggerRuntimeState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BinaryData> array = new List<BinaryData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(BinaryData.FromString(item.GetRawText()));
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("frequency"u8))
                        {
                            frequency = new TumblingWindowFrequency(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("interval"u8))
                        {
                            interval = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("delay"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            delay = JsonSerializer.Deserialize<DataFactoryElement<string>>(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("maxConcurrency"u8))
                        {
                            maxConcurrency = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("retryPolicy"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retryPolicy = RetryPolicy.DeserializeRetryPolicy(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("dependsOn"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DependencyReference> array = new List<DependencyReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DependencyReference.DeserializeDependencyReference(item, options));
                            }
                            dependsOn = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new TumblingWindowTrigger(
                type,
                description.Value,
                Optional.ToNullable(runtimeState),
                annotations ?? new ChangeTrackingList<BinaryData>(),
                additionalProperties,
                pipeline,
                frequency,
                interval,
                startTime,
                Optional.ToNullable(endTime),
                delay.Value,
                maxConcurrency,
                retryPolicy.Value,
                dependsOn ?? new ChangeTrackingList<DependencyReference>());
        }

        BinaryData IPersistableModel<TumblingWindowTrigger>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TumblingWindowTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(TumblingWindowTrigger)} does not support '{options.Format}' format.");
            }
        }

        TumblingWindowTrigger IPersistableModel<TumblingWindowTrigger>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<TumblingWindowTrigger>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeTumblingWindowTrigger(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(TumblingWindowTrigger)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<TumblingWindowTrigger>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
