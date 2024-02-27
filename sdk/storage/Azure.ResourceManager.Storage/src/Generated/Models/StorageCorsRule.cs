// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Specifies a CORS rule for the Blob service. </summary>
    public partial class StorageCorsRule
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageCorsRule"/>. </summary>
        /// <param name="allowedOrigins"> Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains. </param>
        /// <param name="allowedMethods"> Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin. </param>
        /// <param name="maxAgeInSeconds"> Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response. </param>
        /// <param name="exposedHeaders"> Required if CorsRule element is present. A list of response headers to expose to CORS clients. </param>
        /// <param name="allowedHeaders"> Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="allowedOrigins"/>, <paramref name="allowedMethods"/>, <paramref name="exposedHeaders"/> or <paramref name="allowedHeaders"/> is null. </exception>
        public StorageCorsRule(IEnumerable<string> allowedOrigins, IEnumerable<CorsRuleAllowedMethod> allowedMethods, int maxAgeInSeconds, IEnumerable<string> exposedHeaders, IEnumerable<string> allowedHeaders)
        {
            if (allowedOrigins == null)
            {
                throw new ArgumentNullException(nameof(allowedOrigins));
            }
            if (allowedMethods == null)
            {
                throw new ArgumentNullException(nameof(allowedMethods));
            }
            if (exposedHeaders == null)
            {
                throw new ArgumentNullException(nameof(exposedHeaders));
            }
            if (allowedHeaders == null)
            {
                throw new ArgumentNullException(nameof(allowedHeaders));
            }

            AllowedOrigins = allowedOrigins.ToList();
            AllowedMethods = allowedMethods.ToList();
            MaxAgeInSeconds = maxAgeInSeconds;
            ExposedHeaders = exposedHeaders.ToList();
            AllowedHeaders = allowedHeaders.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="StorageCorsRule"/>. </summary>
        /// <param name="allowedOrigins"> Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains. </param>
        /// <param name="allowedMethods"> Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin. </param>
        /// <param name="maxAgeInSeconds"> Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response. </param>
        /// <param name="exposedHeaders"> Required if CorsRule element is present. A list of response headers to expose to CORS clients. </param>
        /// <param name="allowedHeaders"> Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageCorsRule(IList<string> allowedOrigins, IList<CorsRuleAllowedMethod> allowedMethods, int maxAgeInSeconds, IList<string> exposedHeaders, IList<string> allowedHeaders, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AllowedOrigins = allowedOrigins;
            AllowedMethods = allowedMethods;
            MaxAgeInSeconds = maxAgeInSeconds;
            ExposedHeaders = exposedHeaders;
            AllowedHeaders = allowedHeaders;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StorageCorsRule"/> for deserialization. </summary>
        internal StorageCorsRule()
        {
        }

        /// <summary> Required if CorsRule element is present. A list of origin domains that will be allowed via CORS, or "*" to allow all domains. </summary>
        public IList<string> AllowedOrigins { get; }
        /// <summary> Required if CorsRule element is present. A list of HTTP methods that are allowed to be executed by the origin. </summary>
        public IList<CorsRuleAllowedMethod> AllowedMethods { get; }
        /// <summary> Required if CorsRule element is present. The number of seconds that the client/browser should cache a preflight response. </summary>
        public int MaxAgeInSeconds { get; set; }
        /// <summary> Required if CorsRule element is present. A list of response headers to expose to CORS clients. </summary>
        public IList<string> ExposedHeaders { get; }
        /// <summary> Required if CorsRule element is present. A list of headers allowed to be part of the cross-origin request. </summary>
        public IList<string> AllowedHeaders { get; }
    }
}
