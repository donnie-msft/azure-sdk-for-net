// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Grafana;

namespace Azure.ResourceManager.Grafana.Mocking
{
    /// <summary> A class to add extension methods to ResourceGroupResource. </summary>
    public partial class MockableGrafanaResourceGroupResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableGrafanaResourceGroupResource"/> class for mocking. </summary>
        protected MockableGrafanaResourceGroupResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableGrafanaResourceGroupResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableGrafanaResourceGroupResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of ManagedGrafanaResources in the ResourceGroupResource. </summary>
        /// <returns> An object representing collection of ManagedGrafanaResources and their operations over a ManagedGrafanaResource. </returns>
        public virtual ManagedGrafanaCollection GetManagedGrafanas()
        {
            return GetCachedClient(client => new ManagedGrafanaCollection(client, Id));
        }

        /// <summary>
        /// Get the properties of a specific workspace for Grafana resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<ManagedGrafanaResource>> GetManagedGrafanaAsync(string workspaceName, CancellationToken cancellationToken = default)
        {
            return await GetManagedGrafanas().GetAsync(workspaceName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the properties of a specific workspace for Grafana resource.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Dashboard/grafana/{workspaceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Grafana_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="workspaceName"> The workspace name of Azure Managed Grafana. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="workspaceName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<ManagedGrafanaResource> GetManagedGrafana(string workspaceName, CancellationToken cancellationToken = default)
        {
            return GetManagedGrafanas().Get(workspaceName, cancellationToken);
        }
    }
}
