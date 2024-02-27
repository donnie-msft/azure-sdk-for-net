// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.MachineLearning.Models;

namespace Azure.ResourceManager.MachineLearning
{
    internal partial class FeaturesRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of FeaturesRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public FeaturesRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2023-06-01-preview";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string workspaceName, string featuresetName, string featuresetVersion, string skip, string tags, string featureName, string description)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/featuresets/", false);
            uri.AppendPath(featuresetName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(featuresetVersion, true);
            uri.AppendPath("/features", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (skip != null)
            {
                uri.AppendQuery("$skip", skip, true);
            }
            if (tags != null)
            {
                uri.AppendQuery("tags", tags, true);
            }
            if (featureName != null)
            {
                uri.AppendQuery("featureName", featureName, true);
            }
            if (description != null)
            {
                uri.AppendQuery("description", description, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List Features. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="featuresetName"> Featureset name. This is case-sensitive. </param>
        /// <param name="featuresetVersion"> Featureset Version identifier. This is case-sensitive. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="featureName"> feature name. </param>
        /// <param name="description"> Description of the featureset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/> or <paramref name="featuresetVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/> or <paramref name="featuresetVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FeatureResourceArmPaginatedResult>> ListAsync(string subscriptionId, string resourceGroupName, string workspaceName, string featuresetName, string featuresetVersion, string skip = null, string tags = null, string featureName = null, string description = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (featuresetName == null)
            {
                throw new ArgumentNullException(nameof(featuresetName));
            }
            if (featuresetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetName));
            }
            if (featuresetVersion == null)
            {
                throw new ArgumentNullException(nameof(featuresetVersion));
            }
            if (featuresetVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetVersion));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion, skip, tags, featureName, description);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResourceArmPaginatedResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FeatureResourceArmPaginatedResult.DeserializeFeatureResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Features. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="featuresetName"> Featureset name. This is case-sensitive. </param>
        /// <param name="featuresetVersion"> Featureset Version identifier. This is case-sensitive. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="featureName"> feature name. </param>
        /// <param name="description"> Description of the featureset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/> or <paramref name="featuresetVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/> or <paramref name="featuresetVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FeatureResourceArmPaginatedResult> List(string subscriptionId, string resourceGroupName, string workspaceName, string featuresetName, string featuresetVersion, string skip = null, string tags = null, string featureName = null, string description = null, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (featuresetName == null)
            {
                throw new ArgumentNullException(nameof(featuresetName));
            }
            if (featuresetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetName));
            }
            if (featuresetVersion == null)
            {
                throw new ArgumentNullException(nameof(featuresetVersion));
            }
            if (featuresetVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetVersion));
            }

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion, skip, tags, featureName, description);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResourceArmPaginatedResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FeatureResourceArmPaginatedResult.DeserializeFeatureResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string workspaceName, string featuresetName, string featuresetVersion, string featureName)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.MachineLearningServices/workspaces/", false);
            uri.AppendPath(workspaceName, true);
            uri.AppendPath("/featuresets/", false);
            uri.AppendPath(featuresetName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(featuresetVersion, true);
            uri.AppendPath("/features/", false);
            uri.AppendPath(featureName, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Get feature. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="featuresetName"> Feature set name. This is case-sensitive. </param>
        /// <param name="featuresetVersion"> Feature set version identifier. This is case-sensitive. </param>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/>, <paramref name="featuresetVersion"/> or <paramref name="featureName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/>, <paramref name="featuresetVersion"/> or <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<MachineLearningFeatureData>> GetAsync(string subscriptionId, string resourceGroupName, string workspaceName, string featuresetName, string featuresetVersion, string featureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (featuresetName == null)
            {
                throw new ArgumentNullException(nameof(featuresetName));
            }
            if (featuresetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetName));
            }
            if (featuresetVersion == null)
            {
                throw new ArgumentNullException(nameof(featuresetVersion));
            }
            if (featuresetVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetVersion));
            }
            if (featureName == null)
            {
                throw new ArgumentNullException(nameof(featureName));
            }
            if (featureName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featureName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion, featureName);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningFeatureData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = MachineLearningFeatureData.DeserializeMachineLearningFeatureData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MachineLearningFeatureData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Get feature. </summary>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="featuresetName"> Feature set name. This is case-sensitive. </param>
        /// <param name="featuresetVersion"> Feature set version identifier. This is case-sensitive. </param>
        /// <param name="featureName"> Feature Name. This is case-sensitive. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/>, <paramref name="featuresetVersion"/> or <paramref name="featureName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/>, <paramref name="featuresetVersion"/> or <paramref name="featureName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<MachineLearningFeatureData> Get(string subscriptionId, string resourceGroupName, string workspaceName, string featuresetName, string featuresetVersion, string featureName, CancellationToken cancellationToken = default)
        {
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (featuresetName == null)
            {
                throw new ArgumentNullException(nameof(featuresetName));
            }
            if (featuresetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetName));
            }
            if (featuresetVersion == null)
            {
                throw new ArgumentNullException(nameof(featuresetVersion));
            }
            if (featuresetVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetVersion));
            }
            if (featureName == null)
            {
                throw new ArgumentNullException(nameof(featureName));
            }
            if (featureName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featureName));
            }

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion, featureName);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        MachineLearningFeatureData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = MachineLearningFeatureData.DeserializeMachineLearningFeatureData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((MachineLearningFeatureData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string featuresetName, string featuresetVersion, string skip, string tags, string featureName, string description)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> List Features. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="featuresetName"> Featureset name. This is case-sensitive. </param>
        /// <param name="featuresetVersion"> Featureset Version identifier. This is case-sensitive. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="featureName"> feature name. </param>
        /// <param name="description"> Description of the featureset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/> or <paramref name="featuresetVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/> or <paramref name="featuresetVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<FeatureResourceArmPaginatedResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string featuresetName, string featuresetVersion, string skip = null, string tags = null, string featureName = null, string description = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (featuresetName == null)
            {
                throw new ArgumentNullException(nameof(featuresetName));
            }
            if (featuresetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetName));
            }
            if (featuresetVersion == null)
            {
                throw new ArgumentNullException(nameof(featuresetVersion));
            }
            if (featuresetVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetVersion));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion, skip, tags, featureName, description);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResourceArmPaginatedResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                        value = FeatureResourceArmPaginatedResult.DeserializeFeatureResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> List Features. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The ID of the target subscription. </param>
        /// <param name="resourceGroupName"> The name of the resource group. The name is case insensitive. </param>
        /// <param name="workspaceName"> Name of Azure Machine Learning workspace. </param>
        /// <param name="featuresetName"> Featureset name. This is case-sensitive. </param>
        /// <param name="featuresetVersion"> Featureset Version identifier. This is case-sensitive. </param>
        /// <param name="skip"> Continuation token for pagination. </param>
        /// <param name="tags"> Comma-separated list of tag names (and optionally values). Example: tag1,tag2=value2. </param>
        /// <param name="featureName"> feature name. </param>
        /// <param name="description"> Description of the featureset. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/> or <paramref name="featuresetVersion"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workspaceName"/>, <paramref name="featuresetName"/> or <paramref name="featuresetVersion"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<FeatureResourceArmPaginatedResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string workspaceName, string featuresetName, string featuresetVersion, string skip = null, string tags = null, string featureName = null, string description = null, CancellationToken cancellationToken = default)
        {
            if (nextLink == null)
            {
                throw new ArgumentNullException(nameof(nextLink));
            }
            if (subscriptionId == null)
            {
                throw new ArgumentNullException(nameof(subscriptionId));
            }
            if (subscriptionId.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(subscriptionId));
            }
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (resourceGroupName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(resourceGroupName));
            }
            if (workspaceName == null)
            {
                throw new ArgumentNullException(nameof(workspaceName));
            }
            if (workspaceName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(workspaceName));
            }
            if (featuresetName == null)
            {
                throw new ArgumentNullException(nameof(featuresetName));
            }
            if (featuresetName.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetName));
            }
            if (featuresetVersion == null)
            {
                throw new ArgumentNullException(nameof(featuresetVersion));
            }
            if (featuresetVersion.Length == 0)
            {
                throw new ArgumentException("Value cannot be an empty string.", nameof(featuresetVersion));
            }

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workspaceName, featuresetName, featuresetVersion, skip, tags, featureName, description);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        FeatureResourceArmPaginatedResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream);
                        value = FeatureResourceArmPaginatedResult.DeserializeFeatureResourceArmPaginatedResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}
