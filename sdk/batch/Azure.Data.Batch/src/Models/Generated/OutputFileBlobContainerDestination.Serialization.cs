// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Data.Batch.Models
{
    public partial class OutputFileBlobContainerDestination : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path");
                writer.WriteStringValue(Path);
            }
            writer.WritePropertyName("containerUrl");
            writer.WriteStringValue(ContainerUrl);
            if (Optional.IsDefined(IdentityReference))
            {
                writer.WritePropertyName("identityReference");
                writer.WriteObjectValue(IdentityReference);
            }
            if (Optional.IsCollectionDefined(UploadHeaders))
            {
                writer.WritePropertyName("uploadHeaders");
                writer.WriteStartArray();
                foreach (var item in UploadHeaders)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static OutputFileBlobContainerDestination DeserializeOutputFileBlobContainerDestination(JsonElement element)
        {
            Optional<string> path = default;
            string containerUrl = default;
            Optional<ComputeNodeIdentityReference> identityReference = default;
            Optional<IList<HttpHeader>> uploadHeaders = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("path"))
                {
                    path = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("containerUrl"))
                {
                    containerUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identityReference"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identityReference = ComputeNodeIdentityReference.DeserializeComputeNodeIdentityReference(property.Value);
                    continue;
                }
                if (property.NameEquals("uploadHeaders"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<HttpHeader> array = new List<HttpHeader>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(HttpHeader.DeserializeHttpHeader(item));
                    }
                    uploadHeaders = array;
                    continue;
                }
            }
            return new OutputFileBlobContainerDestination(path.Value, containerUrl, identityReference.Value, Optional.ToList(uploadHeaders));
        }
    }
}
