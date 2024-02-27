// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Defines the origin group override action for the delivery rule. </summary>
    public partial class OriginGroupOverrideAction : DeliveryRuleAction
    {
        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideAction"/>. </summary>
        /// <param name="properties"> Defines the parameters for the action. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="properties"/> is null. </exception>
        public OriginGroupOverrideAction(OriginGroupOverrideActionProperties properties)
        {
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Properties = properties;
            Name = DeliveryRuleActionType.OriginGroupOverride;
        }

        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideAction"/>. </summary>
        /// <param name="name"> The name of the action for the delivery rule. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="properties"> Defines the parameters for the action. </param>
        internal OriginGroupOverrideAction(DeliveryRuleActionType name, IDictionary<string, BinaryData> serializedAdditionalRawData, OriginGroupOverrideActionProperties properties) : base(name, serializedAdditionalRawData)
        {
            Properties = properties;
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="OriginGroupOverrideAction"/> for deserialization. </summary>
        internal OriginGroupOverrideAction()
        {
        }

        /// <summary> Defines the parameters for the action. </summary>
        public OriginGroupOverrideActionProperties Properties { get; set; }
    }
}
