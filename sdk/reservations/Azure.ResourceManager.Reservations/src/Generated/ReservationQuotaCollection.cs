// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A class representing a collection of <see cref="ReservationQuotaResource"/> and their operations.
    /// Each <see cref="ReservationQuotaResource"/> in the collection will belong to the same instance of <see cref="SubscriptionResource"/>.
    /// To get a <see cref="ReservationQuotaCollection"/> instance call the GetReservationQuotas method from an instance of <see cref="SubscriptionResource"/>.
    /// </summary>
    public partial class ReservationQuotaCollection : ArmCollection, IEnumerable<ReservationQuotaResource>, IAsyncEnumerable<ReservationQuotaResource>
    {
        private readonly ClientDiagnostics _reservationQuotaQuotaClientDiagnostics;
        private readonly QuotaRestOperations _reservationQuotaQuotaRestClient;
        private readonly string _providerId;
        private readonly AzureLocation _location;

        /// <summary> Initializes a new instance of the <see cref="ReservationQuotaCollection"/> class for mocking. </summary>
        protected ReservationQuotaCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReservationQuotaCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        /// <param name="providerId"> Azure resource provider ID. </param>
        /// <param name="location"> Azure region. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerId"/> is an empty string, and was expected to be non-empty. </exception>
        internal ReservationQuotaCollection(ArmClient client, ResourceIdentifier id, string providerId, AzureLocation location) : base(client, id)
        {
            _providerId = providerId;
            _location = location;
            _reservationQuotaQuotaClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ReservationQuotaResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ReservationQuotaResource.ResourceType, out string reservationQuotaQuotaApiVersion);
            _reservationQuotaQuotaRestClient = new QuotaRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reservationQuotaQuotaApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Create or update the quota (service limits) of a resource to the requested value.
        ///  Steps:
        ///   1. Make the Get request to get the quota information for specific resource.
        ///   2. To increase the quota, update the limit field in the response from Get request to new value.
        ///   3. Submit the JSON to the quota request API to update the quota.
        ///   The Create quota request may be constructed as follows. The PUT operation can be used to update the quota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="data"> Quota requests payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<ReservationQuotaResource>> CreateOrUpdateAsync(WaitUntil waitUntil, string resourceName, ReservationQuotaData data, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _reservationQuotaQuotaRestClient.CreateOrUpdateAsync(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, data, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<ReservationQuotaResource>(new ReservationQuotaOperationSource(Client), _reservationQuotaQuotaClientDiagnostics, Pipeline, _reservationQuotaQuotaRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update the quota (service limits) of a resource to the requested value.
        ///  Steps:
        ///   1. Make the Get request to get the quota information for specific resource.
        ///   2. To increase the quota, update the limit field in the response from Get request to new value.
        ///   3. Submit the JSON to the quota request API to update the quota.
        ///   The Create quota request may be constructed as follows. The PUT operation can be used to update the quota.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="data"> Quota requests payload. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> or <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<ReservationQuotaResource> CreateOrUpdate(WaitUntil waitUntil, string resourceName, ReservationQuotaData data, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }
            if (data == null)
            {
                throw new ArgumentNullException(nameof(data));
            }

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _reservationQuotaQuotaRestClient.CreateOrUpdate(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, data, cancellationToken);
                var operation = new ReservationsArmOperation<ReservationQuotaResource>(new ReservationQuotaOperationSource(Client), _reservationQuotaQuotaClientDiagnostics, Pipeline, _reservationQuotaQuotaRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the current quota (service limit) and usage of a resource. You can use the response from the GET operation to submit quota update request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<ReservationQuotaResource>> GetAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaCollection.Get");
            scope.Start();
            try
            {
                var response = await _reservationQuotaQuotaRestClient.GetAsync(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the current quota (service limit) and usage of a resource. You can use the response from the GET operation to submit quota update request.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<ReservationQuotaResource> Get(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaCollection.Get");
            scope.Start();
            try
            {
                var response = _reservationQuotaQuotaRestClient.Get(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets a list of current quotas (service limits) and usage for all resources. The response from the list quota operation can be leveraged to request quota updates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationQuotaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationQuotaResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationQuotaQuotaRestClient.CreateListRequest(Id.SubscriptionId, _providerId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationQuotaQuotaRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, _providerId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ReservationQuotaResource(Client, ReservationQuotaData.DeserializeReservationQuotaData(e)), _reservationQuotaQuotaClientDiagnostics, Pipeline, "ReservationQuotaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Gets a list of current quotas (service limits) and usage for all resources. The response from the list quota operation can be leveraged to request quota updates.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationQuotaResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationQuotaResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationQuotaQuotaRestClient.CreateListRequest(Id.SubscriptionId, _providerId, new AzureLocation(_location));
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationQuotaQuotaRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId, _providerId, new AzureLocation(_location));
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ReservationQuotaResource(Client, ReservationQuotaData.DeserializeReservationQuotaData(e)), _reservationQuotaQuotaClientDiagnostics, Pipeline, "ReservationQuotaCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaCollection.Exists");
            scope.Start();
            try
            {
                var response = await _reservationQuotaQuotaRestClient.GetAsync(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual Response<bool> Exists(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaCollection.Exists");
            scope.Start();
            try
            {
                var response = _reservationQuotaQuotaRestClient.Get(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual async Task<NullableResponse<ReservationQuotaResource>> GetIfExistsAsync(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _reservationQuotaQuotaRestClient.GetAsync(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ReservationQuotaResource>(response.GetRawResponse());
                return Response.FromValue(new ReservationQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Tries to get details for this resource from the service.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Capacity/resourceProviders/{providerId}/locations/{location}/serviceLimits/{resourceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Quota_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2020-10-25</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationQuotaResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="resourceName"> The resource name for a resource provider, such as SKU name for Microsoft.Compute, Sku or TotalLowPriorityCores for Microsoft.MachineLearningServices. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceName"/> is null. </exception>
        public virtual NullableResponse<ReservationQuotaResource> GetIfExists(string resourceName, CancellationToken cancellationToken = default)
        {
            if (resourceName == null)
            {
                throw new ArgumentNullException(nameof(resourceName));
            }
            if (resourceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceName));
            }

            using var scope = _reservationQuotaQuotaClientDiagnostics.CreateScope("ReservationQuotaCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _reservationQuotaQuotaRestClient.Get(Id.SubscriptionId, _providerId, new AzureLocation(_location), resourceName, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ReservationQuotaResource>(response.GetRawResponse());
                return Response.FromValue(new ReservationQuotaResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ReservationQuotaResource> IEnumerable<ReservationQuotaResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ReservationQuotaResource> IAsyncEnumerable<ReservationQuotaResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
