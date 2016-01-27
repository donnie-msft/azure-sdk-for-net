// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// LoadBalancer resource
    /// </summary>
    public partial class LoadBalancer : Resource
    {
        /// <summary>
        /// Initializes a new instance of the LoadBalancer class.
        /// </summary>
        public LoadBalancer() { }

        /// <summary>
        /// Initializes a new instance of the LoadBalancer class.
        /// </summary>
        public LoadBalancer(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), IList<FrontendIPConfiguration> frontendIPConfigurations = default(IList<FrontendIPConfiguration>), IList<BackendAddressPool> backendAddressPools = default(IList<BackendAddressPool>), IList<LoadBalancingRule> loadBalancingRules = default(IList<LoadBalancingRule>), IList<Probe> probes = default(IList<Probe>), IList<InboundNatRule> inboundNatRules = default(IList<InboundNatRule>), IList<InboundNatPool> inboundNatPools = default(IList<InboundNatPool>), IList<OutboundNatRule> outboundNatRules = default(IList<OutboundNatRule>), string resourceGuid = default(string), string provisioningState = default(string))
            : base(id, name, type, location, tags)
        {
            Etag = etag;
            FrontendIPConfigurations = frontendIPConfigurations;
            BackendAddressPools = backendAddressPools;
            LoadBalancingRules = loadBalancingRules;
            Probes = probes;
            InboundNatRules = inboundNatRules;
            InboundNatPools = inboundNatPools;
            OutboundNatRules = outboundNatRules;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
        }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets frontend IP addresses of the load balancer
        /// </summary>
        [JsonProperty(PropertyName = "properties.frontendIPConfigurations")]
        public IList<FrontendIPConfiguration> FrontendIPConfigurations { get; set; }

        /// <summary>
        /// Gets or sets Pools of backend IP addresseses
        /// </summary>
        [JsonProperty(PropertyName = "properties.backendAddressPools")]
        public IList<BackendAddressPool> BackendAddressPools { get; set; }

        /// <summary>
        /// Gets or sets loadbalancing rules
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancingRules")]
        public IList<LoadBalancingRule> LoadBalancingRules { get; set; }

        /// <summary>
        /// Gets or sets list of Load balancer probes
        /// </summary>
        [JsonProperty(PropertyName = "properties.probes")]
        public IList<Probe> Probes { get; set; }

        /// <summary>
        /// Gets or sets list of inbound rules
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatRules")]
        public IList<InboundNatRule> InboundNatRules { get; set; }

        /// <summary>
        /// Gets or sets inbound NAT pools
        /// </summary>
        [JsonProperty(PropertyName = "properties.inboundNatPools")]
        public IList<InboundNatPool> InboundNatPools { get; set; }

        /// <summary>
        /// Gets or sets outbound NAT rules
        /// </summary>
        [JsonProperty(PropertyName = "properties.outboundNatRules")]
        public IList<OutboundNatRule> OutboundNatRules { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the Load balancer resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets Provisioning state of the PublicIP resource
        /// Updating/Deleting/Failed
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

    }
}
