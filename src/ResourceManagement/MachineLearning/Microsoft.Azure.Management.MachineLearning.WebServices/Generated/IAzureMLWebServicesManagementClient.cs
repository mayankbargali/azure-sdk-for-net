// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.15.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MachineLearning.WebServices
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// [TODO] These APIs allows end users to operate on Web Services in Azure
    /// ML. They support the following operations:&lt;ul&gt;&lt;li&gt;Create
    /// a web service&lt;/li&gt;&lt;li&gt;Get a web
    /// service&lt;/li&gt;&lt;li&gt;Patch a web
    /// service&lt;/li&gt;&lt;li&gt;Delete a web
    /// service&lt;/li&gt;&lt;li&gt;Get All Web Services in a Resource Group
    /// &lt;/li&gt;&lt;li&gt;Get All Web Services in a
    /// Subscription&lt;/li&gt;&lt;li&gt;Get Web Services
    /// Keys&lt;/li&gt;&lt;li&gt;Get All Available
    /// Operations&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    public partial interface IAzureMLWebServicesManagementClient : IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Gets Azure subscription credentials.
        /// </summary>
        ServiceClientCredentials Credentials { get; }

        /// <summary>
        /// Azure subscription id.
        /// </summary>
        string SubscriptionId { get; set; }

        /// <summary>
        /// The versiong of the Microsoft.MachineLearning resource provider
        /// API to be used.
        /// </summary>
        string ApiVersion { get; }

        /// <summary>
        /// Gets or sets the preferred language for the response.
        /// </summary>
        string AcceptLanguage { get; set; }

        /// <summary>
        /// Gets or sets the retry timeout in seconds for Long Running
        /// Operations. Default value is 30.
        /// </summary>
        int? LongRunningOperationRetryTimeout { get; set; }

        /// <summary>
        /// When set to true a unique x-ms-client-request-id value is
        /// generated and included in each request. Default is true.
        /// </summary>
        bool? GenerateClientRequestId { get; set; }


        /// <summary>
        /// Gets the IWebServicesOperations.
        /// </summary>
        IWebServicesOperations WebServices { get; }

            /// <summary>
        /// Get all available operations for the Microsoft.MachineLearning
        /// provider.
        /// </summary>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<GetOperationsOKResponse>> GetOperationsWithHttpMessagesAsync(Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));

    }
}
