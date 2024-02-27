// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    public partial class ProgramDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (IsVanity.HasValue)
            {
                writer.WritePropertyName("isVanity"u8);
                writer.WriteBooleanValue(IsVanity.Value);
            }
            if (!(PreferredVanityNumbers is ChangeTrackingList<string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("preferredVanityNumbers"u8);
                writer.WriteStartArray();
                foreach (var item in PreferredVanityNumbers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (NumberType.HasValue)
            {
                writer.WritePropertyName("numberType"u8);
                writer.WriteStringValue(NumberType.Value.ToString());
            }
            if (IsPoliticalCampaign.HasValue)
            {
                writer.WritePropertyName("isPoliticalCampaign"u8);
                writer.WriteBooleanValue(IsPoliticalCampaign.Value);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Url != null)
            {
                writer.WritePropertyName("url"u8);
                writer.WriteStringValue(Url.AbsoluteUri);
            }
            if (!(SignUpTypes is ChangeTrackingList<ProgramSignUpType> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("signUpTypes"u8);
                writer.WriteStartArray();
                foreach (var item in SignUpTypes)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (SignUpUrl != null)
            {
                writer.WritePropertyName("signUpUrl"u8);
                writer.WriteStringValue(SignUpUrl.AbsoluteUri);
            }
            if (TermsOfServiceUrl != null)
            {
                writer.WritePropertyName("termsOfServiceUrl"u8);
                writer.WriteStringValue(TermsOfServiceUrl.AbsoluteUri);
            }
            if (PrivacyPolicyUrl != null)
            {
                writer.WritePropertyName("privacyPolicyUrl"u8);
                writer.WriteStringValue(PrivacyPolicyUrl.AbsoluteUri);
            }
            if (ExpectedDateOfService.HasValue)
            {
                writer.WritePropertyName("expectedDateOfService"u8);
                writer.WriteStringValue(ExpectedDateOfService.Value, "O");
            }
            writer.WriteEndObject();
        }

        internal static ProgramDetails DeserializeProgramDetails(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> isVanity = default;
            IList<string> preferredVanityNumbers = default;
            Optional<NumberType> numberType = default;
            Optional<bool> isPoliticalCampaign = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<Uri> url = default;
            IList<ProgramSignUpType> signUpTypes = default;
            Optional<Uri> signUpUrl = default;
            Optional<Uri> termsOfServiceUrl = default;
            Optional<Uri> privacyPolicyUrl = default;
            Optional<DateTimeOffset> expectedDateOfService = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("isVanity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isVanity = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("preferredVanityNumbers"u8))
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
                    preferredVanityNumbers = array;
                    continue;
                }
                if (property.NameEquals("numberType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    numberType = new NumberType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("isPoliticalCampaign"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPoliticalCampaign = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("url"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signUpTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ProgramSignUpType> array = new List<ProgramSignUpType>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new ProgramSignUpType(item.GetString()));
                    }
                    signUpTypes = array;
                    continue;
                }
                if (property.NameEquals("signUpUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signUpUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("termsOfServiceUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    termsOfServiceUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("privacyPolicyUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privacyPolicyUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("expectedDateOfService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expectedDateOfService = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new ProgramDetails(
                Optional.ToNullable(isVanity),
                preferredVanityNumbers ?? new ChangeTrackingList<string>(),
                Optional.ToNullable(numberType),
                Optional.ToNullable(isPoliticalCampaign),
                name.Value,
                description.Value,
                url.Value,
                signUpTypes ?? new ChangeTrackingList<ProgramSignUpType>(),
                signUpUrl.Value,
                termsOfServiceUrl.Value,
                privacyPolicyUrl.Value,
                Optional.ToNullable(expectedDateOfService));
        }
    }
}
