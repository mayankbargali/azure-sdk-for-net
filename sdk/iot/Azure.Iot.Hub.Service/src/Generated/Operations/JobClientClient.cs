// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Models;

namespace Azure.Iot.Hub.Service
{
    public partial class JobClientClient
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal JobClientRestClient RestClient { get; }
        /// <summary> Initializes a new instance of JobClientClient for mocking. </summary>
        protected JobClientClient()
        {
        }
        /// <summary> Initializes a new instance of JobClientClient. </summary>
        internal JobClientClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "https://fully-qualified-iothubname.azure-devices.net", string apiVersion = "2020-05-31-preview")
        {
            RestClient = new JobClientRestClient(clientDiagnostics, pipeline, host, apiVersion);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Create a new import/export job on an IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="jobProperties"> Specifies the job specification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobProperties>> CreateImportExportJobAsync(JobProperties jobProperties, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateImportExportJobAsync(jobProperties, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Create a new import/export job on an IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="jobProperties"> Specifies the job specification. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobProperties> CreateImportExportJob(JobProperties jobProperties, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateImportExportJob(jobProperties, cancellationToken);
        }

        /// <summary> Gets the status of all import/export jobs in an iot hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<IReadOnlyList<JobProperties>>> GetImportExportJobsAsync(CancellationToken cancellationToken = default)
        {
            return await RestClient.GetImportExportJobsAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets the status of all import/export jobs in an iot hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<IReadOnlyList<JobProperties>> GetImportExportJobs(CancellationToken cancellationToken = default)
        {
            return RestClient.GetImportExportJobs(cancellationToken);
        }

        /// <summary> Gets the status of an import or export job in an iot hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobProperties>> GetImportExportJobAsync(string id, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetImportExportJobAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Gets the status of an import or export job in an iot hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobProperties> GetImportExportJob(string id, CancellationToken cancellationToken = default)
        {
            return RestClient.GetImportExportJob(id, cancellationToken);
        }

        /// <summary> Cancels an import or export job in an IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<object>> CancelImportExportJobAsync(string id, CancellationToken cancellationToken = default)
        {
            return await RestClient.CancelImportExportJobAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Cancels an import or export job in an IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-identity-registry#import-and-export-device-identities for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<object> CancelImportExportJob(string id, CancellationToken cancellationToken = default)
        {
            return RestClient.CancelImportExportJob(id, cancellationToken);
        }

        /// <summary> Retrieves details of a scheduled job from an IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobResponse>> GetJobAsync(string id, CancellationToken cancellationToken = default)
        {
            return await RestClient.GetJobAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Retrieves details of a scheduled job from an IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobResponse> GetJob(string id, CancellationToken cancellationToken = default)
        {
            return RestClient.GetJob(id, cancellationToken);
        }

        /// <summary> Creates a new job to schedule update twins or device direct methods on an IoT hub at a scheduled time. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="jobRequest"> The JobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobResponse>> CreateJobAsync(string id, JobRequest jobRequest, CancellationToken cancellationToken = default)
        {
            return await RestClient.CreateJobAsync(id, jobRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Creates a new job to schedule update twins or device direct methods on an IoT hub at a scheduled time. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="jobRequest"> The JobRequest to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobResponse> CreateJob(string id, JobRequest jobRequest, CancellationToken cancellationToken = default)
        {
            return RestClient.CreateJob(id, jobRequest, cancellationToken);
        }

        /// <summary> Cancels a scheduled job on an IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<JobResponse>> CancelJobAsync(string id, CancellationToken cancellationToken = default)
        {
            return await RestClient.CancelJobAsync(id, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Cancels a scheduled job on an IoT hub. See https://docs.microsoft.com/en-us/azure/iot-hub/iot-hub-devguide-jobs for more information. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Job ID. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<JobResponse> CancelJob(string id, CancellationToken cancellationToken = default)
        {
            return RestClient.CancelJob(id, cancellationToken);
        }

        /// <summary> Query an IoT hub to retrieve information regarding jobs using the IoT Hub query language. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. Pagination of results is supported. This returns information about jobs only. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="jobType"> Job Type. </param>
        /// <param name="jobStatus"> Job Status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<QueryResult>> QueryJobsAsync(string jobType = null, string jobStatus = null, CancellationToken cancellationToken = default)
        {
            return await RestClient.QueryJobsAsync(jobType, jobStatus, cancellationToken).ConfigureAwait(false);
        }

        /// <summary> Query an IoT hub to retrieve information regarding jobs using the IoT Hub query language. See https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language for more information. Pagination of results is supported. This returns information about jobs only. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="jobType"> Job Type. </param>
        /// <param name="jobStatus"> Job Status. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<QueryResult> QueryJobs(string jobType = null, string jobStatus = null, CancellationToken cancellationToken = default)
        {
            return RestClient.QueryJobs(jobType, jobStatus, cancellationToken);
        }
    }
}
