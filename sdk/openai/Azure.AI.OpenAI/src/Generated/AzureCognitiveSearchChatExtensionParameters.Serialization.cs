// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.OpenAI
{
    internal partial class AzureCognitiveSearchChatExtensionParameters : IUtf8JsonSerializable, IJsonModel<AzureCognitiveSearchChatExtensionParameters>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureCognitiveSearchChatExtensionParameters>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureCognitiveSearchChatExtensionParameters>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCognitiveSearchChatExtensionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCognitiveSearchChatExtensionParameters)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Authentication != null)
            {
                writer.WritePropertyName("authentication"u8);
                writer.WriteObjectValue(Authentication);
            }
            if (DocumentCount.HasValue)
            {
                writer.WritePropertyName("topNDocuments"u8);
                writer.WriteNumberValue(DocumentCount.Value);
            }
            if (ShouldRestrictResultScope.HasValue)
            {
                writer.WritePropertyName("inScope"u8);
                writer.WriteBooleanValue(ShouldRestrictResultScope.Value);
            }
            if (Strictness.HasValue)
            {
                writer.WritePropertyName("strictness"u8);
                writer.WriteNumberValue(Strictness.Value);
            }
            if (RoleInformation != null)
            {
                writer.WritePropertyName("roleInformation"u8);
                writer.WriteStringValue(RoleInformation);
            }
            writer.WritePropertyName("endpoint"u8);
            writer.WriteStringValue(SearchEndpoint.AbsoluteUri);
            writer.WritePropertyName("indexName"u8);
            writer.WriteStringValue(IndexName);
            if (Key != null)
            {
                writer.WritePropertyName("key"u8);
                writer.WriteStringValue(Key);
            }
            if (FieldMappingOptions != null)
            {
                writer.WritePropertyName("fieldsMapping"u8);
                writer.WriteObjectValue(FieldMappingOptions);
            }
            if (QueryType.HasValue)
            {
                writer.WritePropertyName("queryType"u8);
                writer.WriteStringValue(QueryType.Value.ToString());
            }
            if (SemanticConfiguration != null)
            {
                writer.WritePropertyName("semanticConfiguration"u8);
                writer.WriteStringValue(SemanticConfiguration);
            }
            if (Filter != null)
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStringValue(Filter);
            }
            if (EmbeddingEndpoint != null)
            {
                writer.WritePropertyName("embeddingEndpoint"u8);
                writer.WriteStringValue(EmbeddingEndpoint.AbsoluteUri);
            }
            if (EmbeddingKey != null)
            {
                writer.WritePropertyName("embeddingKey"u8);
                writer.WriteStringValue(EmbeddingKey);
            }
            if (EmbeddingDependency != null)
            {
                writer.WritePropertyName("embeddingDependency"u8);
                writer.WriteObjectValue(EmbeddingDependency);
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

        AzureCognitiveSearchChatExtensionParameters IJsonModel<AzureCognitiveSearchChatExtensionParameters>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCognitiveSearchChatExtensionParameters>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AzureCognitiveSearchChatExtensionParameters)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureCognitiveSearchChatExtensionParameters(document.RootElement, options);
        }

        internal static AzureCognitiveSearchChatExtensionParameters DeserializeAzureCognitiveSearchChatExtensionParameters(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<OnYourDataAuthenticationOptions> authentication = default;
            Optional<int> topNDocuments = default;
            Optional<bool> inScope = default;
            Optional<int> strictness = default;
            Optional<string> roleInformation = default;
            Uri endpoint = default;
            string indexName = default;
            Optional<string> key = default;
            Optional<AzureCognitiveSearchIndexFieldMappingOptions> fieldsMapping = default;
            Optional<AzureCognitiveSearchQueryType> queryType = default;
            Optional<string> semanticConfiguration = default;
            Optional<string> filter = default;
            Optional<Uri> embeddingEndpoint = default;
            Optional<string> embeddingKey = default;
            Optional<OnYourDataVectorizationSource> embeddingDependency = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authentication = OnYourDataAuthenticationOptions.DeserializeOnYourDataAuthenticationOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("topNDocuments"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    topNDocuments = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("inScope"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    inScope = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("strictness"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    strictness = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("roleInformation"u8))
                {
                    roleInformation = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("endpoint"u8))
                {
                    endpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("indexName"u8))
                {
                    indexName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("key"u8))
                {
                    key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fieldsMapping"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fieldsMapping = AzureCognitiveSearchIndexFieldMappingOptions.DeserializeAzureCognitiveSearchIndexFieldMappingOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("queryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queryType = new AzureCognitiveSearchQueryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("semanticConfiguration"u8))
                {
                    semanticConfiguration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"u8))
                {
                    filter = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("embeddingEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    embeddingEndpoint = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("embeddingKey"u8))
                {
                    embeddingKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("embeddingDependency"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    embeddingDependency = OnYourDataVectorizationSource.DeserializeOnYourDataVectorizationSource(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureCognitiveSearchChatExtensionParameters(
                authentication.Value,
                Optional.ToNullable(topNDocuments),
                Optional.ToNullable(inScope),
                Optional.ToNullable(strictness),
                roleInformation.Value,
                endpoint,
                indexName,
                key.Value,
                fieldsMapping.Value,
                Optional.ToNullable(queryType),
                semanticConfiguration.Value,
                filter.Value,
                embeddingEndpoint.Value,
                embeddingKey.Value,
                embeddingDependency.Value,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureCognitiveSearchChatExtensionParameters>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCognitiveSearchChatExtensionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AzureCognitiveSearchChatExtensionParameters)} does not support '{options.Format}' format.");
            }
        }

        AzureCognitiveSearchChatExtensionParameters IPersistableModel<AzureCognitiveSearchChatExtensionParameters>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AzureCognitiveSearchChatExtensionParameters>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAzureCognitiveSearchChatExtensionParameters(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AzureCognitiveSearchChatExtensionParameters)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AzureCognitiveSearchChatExtensionParameters>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AzureCognitiveSearchChatExtensionParameters FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAzureCognitiveSearchChatExtensionParameters(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
