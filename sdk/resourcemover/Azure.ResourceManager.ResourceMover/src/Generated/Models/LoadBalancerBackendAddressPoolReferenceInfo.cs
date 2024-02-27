// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    /// <summary> Defines reference to load balancer backend address pools. </summary>
    public partial class LoadBalancerBackendAddressPoolReferenceInfo : ProxyResourceReferenceInfo
    {
        /// <summary> Initializes a new instance of <see cref="LoadBalancerBackendAddressPoolReferenceInfo"/>. </summary>
        /// <param name="sourceArmResourceId"> Gets the ARM resource ID of the tracked resource being referenced. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceArmResourceId"/> is null. </exception>
        public LoadBalancerBackendAddressPoolReferenceInfo(ResourceIdentifier sourceArmResourceId) : base(sourceArmResourceId)
        {
            if (sourceArmResourceId == null)
            {
                throw new ArgumentNullException(nameof(sourceArmResourceId));
            }
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerBackendAddressPoolReferenceInfo"/>. </summary>
        /// <param name="sourceArmResourceId"> Gets the ARM resource ID of the tracked resource being referenced. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> Gets the name of the proxy resource on the target side. </param>
        internal LoadBalancerBackendAddressPoolReferenceInfo(ResourceIdentifier sourceArmResourceId, IDictionary<string, BinaryData> serializedAdditionalRawData, string name) : base(sourceArmResourceId, serializedAdditionalRawData, name)
        {
        }

        /// <summary> Initializes a new instance of <see cref="LoadBalancerBackendAddressPoolReferenceInfo"/> for deserialization. </summary>
        internal LoadBalancerBackendAddressPoolReferenceInfo()
        {
        }
    }
}
