// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsRouterWorkerOfferExpiredEventDataConverter))]
    public partial class AcsRouterWorkerOfferExpiredEventData
    {
        internal static AcsRouterWorkerOfferExpiredEventData DeserializeAcsRouterWorkerOfferExpiredEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> queueId = default;
            Optional<string> offerId = default;
            Optional<string> workerId = default;
            Optional<string> jobId = default;
            Optional<string> channelReference = default;
            Optional<string> channelId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workerId"u8))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsRouterWorkerOfferExpiredEventData(
                jobId.Value,
                channelReference.Value,
                channelId.Value,
                workerId.Value,
                queueId.Value,
                offerId.Value);
        }

        internal partial class AcsRouterWorkerOfferExpiredEventDataConverter : JsonConverter<AcsRouterWorkerOfferExpiredEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterWorkerOfferExpiredEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsRouterWorkerOfferExpiredEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterWorkerOfferExpiredEventData(document.RootElement);
            }
        }
    }
}
