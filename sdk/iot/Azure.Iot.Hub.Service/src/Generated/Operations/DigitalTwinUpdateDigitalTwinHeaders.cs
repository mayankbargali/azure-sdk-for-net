// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure;
using Azure.Core;

namespace Azure.Iot.Hub.Service
{
    internal class DigitalTwinUpdateDigitalTwinHeaders
    {
        private readonly Response _response;
        public DigitalTwinUpdateDigitalTwinHeaders(Response response)
        {
            _response = response;
        }
        public string Location => _response.Headers.TryGetValue("Location", out string value) ? value : null;
    }
}
