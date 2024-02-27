// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> Route Properties. </summary>
    public partial class StaticRouteProperties
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

        /// <summary> Initializes a new instance of <see cref="StaticRouteProperties"/>. </summary>
        /// <param name="prefix"> Prefix of the route. </param>
        /// <param name="nextHop"> List of next hop addresses. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="prefix"/> or <paramref name="nextHop"/> is null. </exception>
        public StaticRouteProperties(string prefix, IEnumerable<string> nextHop)
        {
            if (prefix == null)
            {
                throw new ArgumentNullException(nameof(prefix));
            }
            if (nextHop == null)
            {
                throw new ArgumentNullException(nameof(nextHop));
            }

            Prefix = prefix;
            NextHop = nextHop.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="StaticRouteProperties"/>. </summary>
        /// <param name="prefix"> Prefix of the route. </param>
        /// <param name="nextHop"> List of next hop addresses. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticRouteProperties(string prefix, IList<string> nextHop, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Prefix = prefix;
            NextHop = nextHop;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="StaticRouteProperties"/> for deserialization. </summary>
        internal StaticRouteProperties()
        {
        }

        /// <summary> Prefix of the route. </summary>
        public string Prefix { get; set; }
        /// <summary> List of next hop addresses. </summary>
        public IList<string> NextHop { get; }
    }
}
