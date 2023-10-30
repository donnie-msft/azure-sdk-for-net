// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.Support
{
    /// <summary>
    /// A Class representing a SupportTicketChatTranscript along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SupportTicketChatTranscriptResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSupportTicketChatTranscriptResource method.
    /// Otherwise you can get one from its parent resource <see cref="SubscriptionSupportTicketResource" /> using the GetSupportTicketChatTranscript method.
    /// </summary>
    public partial class SupportTicketChatTranscriptResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SupportTicketChatTranscriptResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string supportTicketName, string chatTranscriptName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _supportTicketChatTranscriptChatTranscriptsClientDiagnostics;
        private readonly ChatTranscriptsRestOperations _supportTicketChatTranscriptChatTranscriptsRestClient;
        private readonly ChatTranscriptDetailData _data;

        /// <summary> Initializes a new instance of the <see cref="SupportTicketChatTranscriptResource"/> class for mocking. </summary>
        protected SupportTicketChatTranscriptResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SupportTicketChatTranscriptResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SupportTicketChatTranscriptResource(ArmClient client, ChatTranscriptDetailData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SupportTicketChatTranscriptResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SupportTicketChatTranscriptResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _supportTicketChatTranscriptChatTranscriptsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.Support", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string supportTicketChatTranscriptChatTranscriptsApiVersion);
            _supportTicketChatTranscriptChatTranscriptsRestClient = new ChatTranscriptsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, supportTicketChatTranscriptChatTranscriptsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Support/supportTickets/chatTranscripts";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual ChatTranscriptDetailData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Returns chatTranscript details for a support ticket under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SupportTicketChatTranscriptResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _supportTicketChatTranscriptChatTranscriptsClientDiagnostics.CreateScope("SupportTicketChatTranscriptResource.Get");
            scope.Start();
            try
            {
                var response = await _supportTicketChatTranscriptChatTranscriptsRestClient.GetAsync(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketChatTranscriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Returns chatTranscript details for a support ticket under a subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Support/supportTickets/{supportTicketName}/chatTranscripts/{chatTranscriptName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ChatTranscripts_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SupportTicketChatTranscriptResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _supportTicketChatTranscriptChatTranscriptsClientDiagnostics.CreateScope("SupportTicketChatTranscriptResource.Get");
            scope.Start();
            try
            {
                var response = _supportTicketChatTranscriptChatTranscriptsRestClient.Get(Id.SubscriptionId, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SupportTicketChatTranscriptResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
