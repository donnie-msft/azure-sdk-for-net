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
    /// PublicIPAddress resource
    /// </summary>
    public partial class PublicIPAddress : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPAddress class.
        /// </summary>
        public PublicIPAddress() { }

        /// <summary>
        /// Initializes a new instance of the PublicIPAddress class.
        /// </summary>
        public PublicIPAddress(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string etag = default(string), string publicIPAllocationMethod = default(string), IPConfiguration ipConfiguration = default(IPConfiguration), PublicIPAddressDnsSettings dnsSettings = default(PublicIPAddressDnsSettings), string ipAddress = default(string), int? idleTimeoutInMinutes = default(int?), string resourceGuid = default(string), string provisioningState = default(string))
            : base(id, name, type, location, tags)
        {
            Etag = etag;
            PublicIPAllocationMethod = publicIPAllocationMethod;
            IpConfiguration = ipConfiguration;
            DnsSettings = dnsSettings;
            IpAddress = ipAddress;
            IdleTimeoutInMinutes = idleTimeoutInMinutes;
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
        /// Gets or sets PublicIP allocation method (Static/Dynamic). Possible
        /// values for this property include: 'Static', 'Dynamic'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAllocationMethod")]
        public string PublicIPAllocationMethod { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipConfiguration")]
        public IPConfiguration IpConfiguration { get; set; }

        /// <summary>
        /// Gets or sets FQDN of the DNS record associated with the public IP
        /// address
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsSettings")]
        public PublicIPAddressDnsSettings DnsSettings { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipAddress")]
        public string IpAddress { get; set; }

        /// <summary>
        /// Gets or sets the Idletimeout of the public IP address
        /// </summary>
        [JsonProperty(PropertyName = "properties.idleTimeoutInMinutes")]
        public int? IdleTimeoutInMinutes { get; set; }

        /// <summary>
        /// Gets or sets resource guid property of the PublicIP resource
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
