// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    internal partial class CallConnectionPropertiesInternal
    {
        internal static CallConnectionPropertiesInternal DeserializeCallConnectionPropertiesInternal(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> callConnectionId = default;
            Optional<string> serverCallId = default;
            IReadOnlyList<CommunicationIdentifierModel> targets = default;
            Optional<CallConnectionState> callConnectionState = default;
            Optional<string> callbackUri = default;
            Optional<string> mediaSubscriptionId = default;
            Optional<string> dataSubscriptionId = default;
            Optional<PhoneNumberIdentifierModel> sourceCallerIdNumber = default;
            Optional<string> sourceDisplayName = default;
            Optional<CommunicationIdentifierModel> source = default;
            Optional<string> correlationId = default;
            Optional<CommunicationUserIdentifierModel> answeredBy = default;
            Optional<PhoneNumberIdentifierModel> originalPstnTarget = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("callConnectionId"u8))
                {
                    callConnectionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverCallId"u8))
                {
                    serverCallId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<CommunicationIdentifierModel> array = new List<CommunicationIdentifierModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(item));
                    }
                    targets = array;
                    continue;
                }
                if (property.NameEquals("callConnectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callConnectionState = new CallConnectionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("callbackUri"u8))
                {
                    callbackUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mediaSubscriptionId"u8))
                {
                    mediaSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dataSubscriptionId"u8))
                {
                    dataSubscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCallerIdNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceCallerIdNumber = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceDisplayName"u8))
                {
                    sourceDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    source = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("answeredBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    answeredBy = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("originalPstnTarget"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    originalPstnTarget = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
            }
            return new CallConnectionPropertiesInternal(
                callConnectionId.Value,
                serverCallId.Value,
                targets ?? new ChangeTrackingList<CommunicationIdentifierModel>(),
                Optional.ToNullable(callConnectionState),
                callbackUri.Value,
                mediaSubscriptionId.Value,
                dataSubscriptionId.Value,
                sourceCallerIdNumber.Value,
                sourceDisplayName.Value,
                source.Value,
                correlationId.Value,
                answeredBy.Value,
                originalPstnTarget.Value);
        }
    }
}
