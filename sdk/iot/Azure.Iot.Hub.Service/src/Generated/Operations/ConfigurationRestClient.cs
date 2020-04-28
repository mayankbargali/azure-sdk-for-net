// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Iot.Hub.Service.Models;

namespace Azure.Iot.Hub.Service
{
    internal partial class ConfigurationRestClient
    {
        private string host;
        private string apiVersion;
        private ClientDiagnostics _clientDiagnostics;
        private HttpPipeline _pipeline;

        /// <summary> Initializes a new instance of ConfigurationRestClient. </summary>
        public ConfigurationRestClient(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string host = "https://fully-qualified-iothubname.azure-devices.net", string apiVersion = "2020-05-31-preview")
        {
            if (host == null)
            {
                throw new ArgumentNullException(nameof(host));
            }
            if (apiVersion == null)
            {
                throw new ArgumentNullException(nameof(apiVersion));
            }

            this.host = host;
            this.apiVersion = apiVersion;
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        internal HttpMessage CreateGetRequest(string id)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/configurations/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary>  For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<Configuration>> GetAsync(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(id);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            Configuration value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = Configuration.DeserializeConfiguration(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>  For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Configuration> Get(string id, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.Get");
            scope.Start();
            try
            {
                using var message = CreateGetRequest(id);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            Configuration value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = Configuration.DeserializeConfiguration(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateCreateOrUpdateRequest(string id, Configuration configuration, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Put;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/configurations/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(configuration);
            request.Content = content;
            return message;
        }

        /// <summary>  For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="configuration"> The Configuration to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<Configuration>> CreateOrUpdateAsync(string id, Configuration configuration, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(id, configuration, ifMatch);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                    case 201:
                        {
                            Configuration value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = Configuration.DeserializeConfiguration(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>  For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="configuration"> The Configuration to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<Configuration> CreateOrUpdate(string id, Configuration configuration, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.CreateOrUpdate");
            scope.Start();
            try
            {
                using var message = CreateCreateOrUpdateRequest(id, configuration, ifMatch);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                    case 201:
                        {
                            Configuration value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = Configuration.DeserializeConfiguration(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateDeleteRequest(string id, string ifMatch)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Delete;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/configurations/", false);
            uri.AppendPath(id, true);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            if (ifMatch != null)
            {
                request.Headers.Add("If-Match", ifMatch);
            }
            return message;
        }

        /// <summary>  For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response> DeleteAsync(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(id, ifMatch);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>  For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> The String to use. </param>
        /// <param name="ifMatch"> The String to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response Delete(string id, string ifMatch = null, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.Delete");
            scope.Start();
            try
            {
                using var message = CreateDeleteRequest(id, ifMatch);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 204:
                        return message.Response;
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateGetConfigurationsRequest(int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/configurations", false);
            if (top != null)
            {
                uri.AppendQuery("top", top.Value, true);
            }
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            return message;
        }

        /// <summary>  For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="top"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<IReadOnlyList<Configuration>>> GetConfigurationsAsync(int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.GetConfigurations");
            scope.Start();
            try
            {
                using var message = CreateGetConfigurationsRequest(top);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            IReadOnlyList<Configuration> value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                List<Configuration> array = new List<Configuration>();
                                foreach (var item in document.RootElement.EnumerateArray())
                                {
                                    if (item.ValueKind == JsonValueKind.Null)
                                    {
                                        array.Add(null);
                                    }
                                    else
                                    {
                                        array.Add(Configuration.DeserializeConfiguration(item));
                                    }
                                }
                                value = array;
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>  For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="top"> The Integer to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<IReadOnlyList<Configuration>> GetConfigurations(int? top = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.GetConfigurations");
            scope.Start();
            try
            {
                using var message = CreateGetConfigurationsRequest(top);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            IReadOnlyList<Configuration> value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                List<Configuration> array = new List<Configuration>();
                                foreach (var item in document.RootElement.EnumerateArray())
                                {
                                    if (item.ValueKind == JsonValueKind.Null)
                                    {
                                        array.Add(null);
                                    }
                                    else
                                    {
                                        array.Add(Configuration.DeserializeConfiguration(item));
                                    }
                                }
                                value = array;
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateTestQueriesRequest(ConfigurationQueriesTestInput input)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/configurations/testQueries", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(input);
            request.Content = content;
            return message;
        }

        /// <summary> Validates the target condition query and custom metric queries for a configuration. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="input"> The ConfigurationQueriesTestInput to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<ConfigurationQueriesTestResponse>> TestQueriesAsync(ConfigurationQueriesTestInput input, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.TestQueries");
            scope.Start();
            try
            {
                using var message = CreateTestQueriesRequest(input);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ConfigurationQueriesTestResponse value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = ConfigurationQueriesTestResponse.DeserializeConfigurationQueriesTestResponse(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Validates the target condition query and custom metric queries for a configuration. For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="input"> The ConfigurationQueriesTestInput to use. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<ConfigurationQueriesTestResponse> TestQueries(ConfigurationQueriesTestInput input, CancellationToken cancellationToken = default)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.TestQueries");
            scope.Start();
            try
            {
                using var message = CreateTestQueriesRequest(input);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            ConfigurationQueriesTestResponse value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = ConfigurationQueriesTestResponse.DeserializeConfigurationQueriesTestResponse(document.RootElement);
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        internal HttpMessage CreateApplyOnEdgeDeviceRequest(string id, ConfigurationContent content)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Post;
            var uri = new RawRequestUriBuilder();
            uri.AppendRaw(host, false);
            uri.AppendPath("/devices/", false);
            uri.AppendPath(id, true);
            uri.AppendPath("/applyConfigurationContent", false);
            uri.AppendQuery("api-version", apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Content-Type", "application/json");
            using var content0 = new Utf8JsonRequestContent();
            content0.JsonWriter.WriteObjectValue(content);
            request.Content = content0;
            return message;
        }

        /// <summary> Applies the provided configuration content to the specified edge device. Configuration content must have modules content For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="content"> Configuration Content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public async ValueTask<Response<object>> ApplyOnEdgeDeviceAsync(string id, ConfigurationContent content, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.ApplyOnEdgeDevice");
            scope.Start();
            try
            {
                using var message = CreateApplyOnEdgeDeviceRequest(id, content);
                await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            object value = default;
                            using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, default, cancellationToken).ConfigureAwait(false);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = document.RootElement.GetObject();
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    case 204:
                        return Response.FromValue<object>(null, message.Response);
                    default:
                        throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(message.Response).ConfigureAwait(false);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Applies the provided configuration content to the specified edge device. Configuration content must have modules content For IoT Hub VNET related features(https://docs.microsoft.com/en-us/azure/iot-hub/virtual-network-support) please use API version &apos;2020-03-13&apos;.These features are currently in general availability in the East US, West US 2, and Southcentral US regions only. We are actively working to expand the availability of these features to all regions by end of month May. For rest of the APIs please continue using API version &apos;2019-10-01&apos;. </summary>
        /// <param name="id"> Device ID. </param>
        /// <param name="content"> Configuration Content. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public Response<object> ApplyOnEdgeDevice(string id, ConfigurationContent content, CancellationToken cancellationToken = default)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            using var scope = _clientDiagnostics.CreateScope("ConfigurationClient.ApplyOnEdgeDevice");
            scope.Start();
            try
            {
                using var message = CreateApplyOnEdgeDeviceRequest(id, content);
                _pipeline.Send(message, cancellationToken);
                switch (message.Response.Status)
                {
                    case 200:
                        {
                            object value = default;
                            using var document = JsonDocument.Parse(message.Response.ContentStream);
                            if (document.RootElement.ValueKind == JsonValueKind.Null)
                            {
                                value = null;
                            }
                            else
                            {
                                value = document.RootElement.GetObject();
                            }
                            return Response.FromValue(value, message.Response);
                        }
                    case 204:
                        return Response.FromValue<object>(null, message.Response);
                    default:
                        throw _clientDiagnostics.CreateRequestFailedException(message.Response);
                }
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
