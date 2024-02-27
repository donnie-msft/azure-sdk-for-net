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
using Azure.ResourceManager.Reservations.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Reservations
{
    /// <summary>
    /// A class representing a collection of <see cref="ReservationOrderResource"/> and their operations.
    /// Each <see cref="ReservationOrderResource"/> in the collection will belong to the same instance of <see cref="TenantResource"/>.
    /// To get a <see cref="ReservationOrderCollection"/> instance call the GetReservationOrders method from an instance of <see cref="TenantResource"/>.
    /// </summary>
    public partial class ReservationOrderCollection : ArmCollection, IEnumerable<ReservationOrderResource>, IAsyncEnumerable<ReservationOrderResource>
    {
        private readonly ClientDiagnostics _reservationOrderClientDiagnostics;
        private readonly ReservationOrderRestOperations _reservationOrderRestClient;

        /// <summary> Initializes a new instance of the <see cref="ReservationOrderCollection"/> class for mocking. </summary>
        protected ReservationOrderCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="ReservationOrderCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal ReservationOrderCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _reservationOrderClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Reservations", ReservationOrderResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ReservationOrderResource.ResourceType, out string reservationOrderApiVersion);
            _reservationOrderRestClient = new ReservationOrderRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, reservationOrderApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != TenantResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, TenantResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Purchase `ReservationOrder` and create resource under the specified URI.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Purchase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<ArmOperation<ReservationOrderResource>> CreateOrUpdateAsync(WaitUntil waitUntil, Guid reservationOrderId, ReservationPurchaseContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _reservationOrderRestClient.PurchaseAsync(reservationOrderId, content, cancellationToken).ConfigureAwait(false);
                var operation = new ReservationsArmOperation<ReservationOrderResource>(new ReservationOrderOperationSource(Client), _reservationOrderClientDiagnostics, Pipeline, _reservationOrderRestClient.CreatePurchaseRequest(reservationOrderId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Purchase `ReservationOrder` and create resource under the specified URI.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Purchase</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="content"> Information needed for calculate or purchase reservation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual ArmOperation<ReservationOrderResource> CreateOrUpdate(WaitUntil waitUntil, Guid reservationOrderId, ReservationPurchaseContent content, CancellationToken cancellationToken = default)
        {
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _reservationOrderRestClient.Purchase(reservationOrderId, content, cancellationToken);
                var operation = new ReservationsArmOperation<ReservationOrderResource>(new ReservationOrderOperationSource(Client), _reservationOrderClientDiagnostics, Pipeline, _reservationOrderRestClient.CreatePurchaseRequest(reservationOrderId, content).Request, response, OperationFinalStateVia.Location);
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
        /// Get the details of the `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ReservationOrderResource>> GetAsync(Guid reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderCollection.Get");
            scope.Start();
            try
            {
                var response = await _reservationOrderRestClient.GetAsync(reservationOrderId, expand, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the details of the `ReservationOrder`.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ReservationOrderResource> Get(Guid reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderCollection.Get");
            scope.Start();
            try
            {
                var response = _reservationOrderRestClient.Get(reservationOrderId, expand, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ReservationOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// List of all the `ReservationOrder`s that the user has access to in the current tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ReservationOrderResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ReservationOrderResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationOrderRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationOrderRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ReservationOrderResource(Client, ReservationOrderData.DeserializeReservationOrderData(e)), _reservationOrderClientDiagnostics, Pipeline, "ReservationOrderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// List of all the `ReservationOrder`s that the user has access to in the current tenant.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_List</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ReservationOrderResource"/> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ReservationOrderResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _reservationOrderRestClient.CreateListRequest();
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _reservationOrderRestClient.CreateListNextPageRequest(nextLink);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ReservationOrderResource(Client, ReservationOrderData.DeserializeReservationOrderData(e)), _reservationOrderClientDiagnostics, Pipeline, "ReservationOrderCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(Guid reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = await _reservationOrderRestClient.GetAsync(reservationOrderId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(Guid reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderCollection.Exists");
            scope.Start();
            try
            {
                var response = _reservationOrderRestClient.Get(reservationOrderId, expand, cancellationToken: cancellationToken);
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
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<NullableResponse<ReservationOrderResource>> GetIfExistsAsync(Guid reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = await _reservationOrderRestClient.GetAsync(reservationOrderId, expand, cancellationToken: cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    return new NoValueResponse<ReservationOrderResource>(response.GetRawResponse());
                return Response.FromValue(new ReservationOrderResource(Client, response.Value), response.GetRawResponse());
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
        /// <description>/providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ReservationOrder_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2022-11-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="ReservationOrderResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="reservationOrderId"> Order Id of the reservation. </param>
        /// <param name="expand"> May be used to expand the planInformation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual NullableResponse<ReservationOrderResource> GetIfExists(Guid reservationOrderId, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _reservationOrderClientDiagnostics.CreateScope("ReservationOrderCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _reservationOrderRestClient.Get(reservationOrderId, expand, cancellationToken: cancellationToken);
                if (response.Value == null)
                    return new NoValueResponse<ReservationOrderResource>(response.GetRawResponse());
                return Response.FromValue(new ReservationOrderResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<ReservationOrderResource> IEnumerable<ReservationOrderResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ReservationOrderResource> IAsyncEnumerable<ReservationOrderResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
