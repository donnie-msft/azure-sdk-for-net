// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SparkBatchJobStateConverter))]
    public partial class SparkBatchJobState
    {
        internal static SparkBatchJobState DeserializeSparkBatchJobState(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset?> notStartedAt = default;
            Optional<DateTimeOffset?> startingAt = default;
            Optional<DateTimeOffset?> runningAt = default;
            Optional<DateTimeOffset?> deadAt = default;
            Optional<DateTimeOffset?> successAt = default;
            Optional<DateTimeOffset?> killedAt = default;
            Optional<DateTimeOffset?> recoveringAt = default;
            Optional<string> currentState = default;
            Optional<SparkRequest> jobCreationRequest = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("notStartedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        notStartedAt = null;
                        continue;
                    }
                    notStartedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("startingAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        startingAt = null;
                        continue;
                    }
                    startingAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("runningAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        runningAt = null;
                        continue;
                    }
                    runningAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("deadAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        deadAt = null;
                        continue;
                    }
                    deadAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("successAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        successAt = null;
                        continue;
                    }
                    successAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("killedAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        killedAt = null;
                        continue;
                    }
                    killedAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("recoveringAt"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        recoveringAt = null;
                        continue;
                    }
                    recoveringAt = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("currentState"u8))
                {
                    currentState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobCreationRequest"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobCreationRequest = SparkRequest.DeserializeSparkRequest(property.Value);
                    continue;
                }
            }
            return new SparkBatchJobState(
                Optional.ToNullable(notStartedAt),
                Optional.ToNullable(startingAt),
                Optional.ToNullable(runningAt),
                Optional.ToNullable(deadAt),
                Optional.ToNullable(successAt),
                Optional.ToNullable(killedAt),
                Optional.ToNullable(recoveringAt),
                currentState.Value,
                jobCreationRequest.Value);
        }

        internal partial class SparkBatchJobStateConverter : JsonConverter<SparkBatchJobState>
        {
            public override void Write(Utf8JsonWriter writer, SparkBatchJobState model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override SparkBatchJobState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSparkBatchJobState(document.RootElement);
            }
        }
    }
}
