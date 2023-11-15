// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridNetwork.Models
{
    /// <summary> Network function definition group properties. </summary>
    public partial class NetworkFunctionDefinitionGroupPropertiesFormat
    {
        /// <summary> Initializes a new instance of NetworkFunctionDefinitionGroupPropertiesFormat. </summary>
        public NetworkFunctionDefinitionGroupPropertiesFormat()
        {
        }

        /// <summary> Initializes a new instance of NetworkFunctionDefinitionGroupPropertiesFormat. </summary>
        /// <param name="provisioningState"> The provisioning state of the network function definition groups resource. </param>
        /// <param name="description"> The network function definition group description. </param>
        internal NetworkFunctionDefinitionGroupPropertiesFormat(ProvisioningState? provisioningState, string description)
        {
            ProvisioningState = provisioningState;
            Description = description;
        }

        /// <summary> The provisioning state of the network function definition groups resource. </summary>
        public ProvisioningState? ProvisioningState { get; }
        /// <summary> The network function definition group description. </summary>
        public string Description { get; set; }
    }
}
