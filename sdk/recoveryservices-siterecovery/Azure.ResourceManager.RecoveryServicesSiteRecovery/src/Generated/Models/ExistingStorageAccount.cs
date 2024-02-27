// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Existing storage account input. </summary>
    public partial class ExistingStorageAccount : StorageAccountCustomDetails
    {
        /// <summary> Initializes a new instance of <see cref="ExistingStorageAccount"/>. </summary>
        /// <param name="azureStorageAccountId"> The storage account Arm Id. Throw error, if resource does not exists. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="azureStorageAccountId"/> is null. </exception>
        public ExistingStorageAccount(ResourceIdentifier azureStorageAccountId)
        {
            if (azureStorageAccountId == null)
            {
                throw new ArgumentNullException(nameof(azureStorageAccountId));
            }

            AzureStorageAccountId = azureStorageAccountId;
            ResourceType = "Existing";
        }

        /// <summary> Initializes a new instance of <see cref="ExistingStorageAccount"/>. </summary>
        /// <param name="resourceType"> The class type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="azureStorageAccountId"> The storage account Arm Id. Throw error, if resource does not exists. </param>
        internal ExistingStorageAccount(string resourceType, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier azureStorageAccountId) : base(resourceType, serializedAdditionalRawData)
        {
            AzureStorageAccountId = azureStorageAccountId;
            ResourceType = resourceType ?? "Existing";
        }

        /// <summary> Initializes a new instance of <see cref="ExistingStorageAccount"/> for deserialization. </summary>
        internal ExistingStorageAccount()
        {
        }

        /// <summary> The storage account Arm Id. Throw error, if resource does not exists. </summary>
        public ResourceIdentifier AzureStorageAccountId { get; set; }
    }
}
