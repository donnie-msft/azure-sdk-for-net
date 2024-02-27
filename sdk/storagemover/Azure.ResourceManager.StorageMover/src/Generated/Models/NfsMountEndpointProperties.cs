// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> The properties of NFS share endpoint. </summary>
    public partial class NfsMountEndpointProperties : EndpointBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="NfsMountEndpointProperties"/>. </summary>
        /// <param name="host"> The host name or IP address of the server exporting the file system. </param>
        /// <param name="export"> The directory being exported from the server. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="host"/> or <paramref name="export"/> is null. </exception>
        public NfsMountEndpointProperties(string host, string export)
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            if (export == null)
            {
                throw new ArgumentNullException(nameof(export));
            }

            Host = host;
            Export = export;
            EndpointType = EndpointType.NfsMount;
        }

        /// <summary> Initializes a new instance of <see cref="NfsMountEndpointProperties"/>. </summary>
        /// <param name="endpointType"> The Endpoint resource type. </param>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="host"> The host name or IP address of the server exporting the file system. </param>
        /// <param name="nfsVersion"> The NFS protocol version. </param>
        /// <param name="export"> The directory being exported from the server. </param>
        internal NfsMountEndpointProperties(EndpointType endpointType, string description, StorageMoverProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData, string host, NfsVersion? nfsVersion, string export) : base(endpointType, description, provisioningState, serializedAdditionalRawData)
        {
            Host = host;
            NfsVersion = nfsVersion;
            Export = export;
            EndpointType = endpointType;
        }

        /// <summary> Initializes a new instance of <see cref="NfsMountEndpointProperties"/> for deserialization. </summary>
        internal NfsMountEndpointProperties()
        {
        }

        /// <summary> The host name or IP address of the server exporting the file system. </summary>
        public string Host { get; set; }
        /// <summary> The NFS protocol version. </summary>
        public NfsVersion? NfsVersion { get; set; }
        /// <summary> The directory being exported from the server. </summary>
        public string Export { get; set; }
    }
}
