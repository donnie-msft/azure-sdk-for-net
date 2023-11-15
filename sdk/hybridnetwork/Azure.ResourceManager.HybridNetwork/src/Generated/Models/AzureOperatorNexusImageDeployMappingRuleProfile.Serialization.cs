// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureOperatorNexusImageDeployMappingRuleProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ImageMappingRuleProfile))
            {
                writer.WritePropertyName("imageMappingRuleProfile"u8);
                writer.WriteObjectValue(ImageMappingRuleProfile);
            }
            if (Optional.IsDefined(ApplicationEnablement))
            {
                writer.WritePropertyName("applicationEnablement"u8);
                writer.WriteStringValue(ApplicationEnablement.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static AzureOperatorNexusImageDeployMappingRuleProfile DeserializeAzureOperatorNexusImageDeployMappingRuleProfile(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ImageMappingRuleProfile> imageMappingRuleProfile = default;
            Optional<ApplicationEnablement> applicationEnablement = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("imageMappingRuleProfile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    imageMappingRuleProfile = ImageMappingRuleProfile.DeserializeImageMappingRuleProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("applicationEnablement"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationEnablement = new ApplicationEnablement(property.Value.GetString());
                    continue;
                }
            }
            return new AzureOperatorNexusImageDeployMappingRuleProfile(Optional.ToNullable(applicationEnablement), imageMappingRuleProfile.Value);
        }
    }
}
