// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Configuration for IotHub devices and modules. </summary>
    public partial class Configuration
    {
        /// <summary> Initializes a new instance of Configuration. </summary>
        public Configuration()
        {
        }

        /// <summary> Initializes a new instance of Configuration. </summary>
        /// <param name="id"> Gets Identifier for the configuration. </param>
        /// <param name="schemaVersion"> Gets Schema version for the configuration. </param>
        /// <param name="labels"> Gets or sets labels for the configuration. </param>
        /// <param name="content"> Gets or sets Content for the configuration. </param>
        /// <param name="targetCondition"> Gets or sets Target Condition for the configuration. </param>
        /// <param name="createdTimeUtc"> Gets creation time for the configuration. </param>
        /// <param name="lastUpdatedTimeUtc"> Gets last update time for the configuration. </param>
        /// <param name="priority"> Gets or sets Priority for the configuration. </param>
        /// <param name="systemMetrics"> System Configuration Metrics. </param>
        /// <param name="metrics"> Custom Configuration Metrics. </param>
        /// <param name="etag"> Gets or sets configuration&apos;s ETag. </param>
        internal Configuration(string id, string schemaVersion, IDictionary<string, string> labels, ConfigurationContent content, string targetCondition, DateTimeOffset? createdTimeUtc, DateTimeOffset? lastUpdatedTimeUtc, int? priority, ConfigurationMetrics systemMetrics, ConfigurationMetrics metrics, string etag)
        {
            Id = id;
            SchemaVersion = schemaVersion;
            Labels = labels;
            Content = content;
            TargetCondition = targetCondition;
            CreatedTimeUtc = createdTimeUtc;
            LastUpdatedTimeUtc = lastUpdatedTimeUtc;
            Priority = priority;
            SystemMetrics = systemMetrics;
            Metrics = metrics;
            Etag = etag;
        }

        /// <summary> Gets Identifier for the configuration. </summary>
        public string Id { get; set; }
        /// <summary> Gets Schema version for the configuration. </summary>
        public string SchemaVersion { get; set; }
        /// <summary> Gets or sets labels for the configuration. </summary>
        public IDictionary<string, string> Labels { get; set; }
        /// <summary> Gets or sets Content for the configuration. </summary>
        public ConfigurationContent Content { get; set; }
        /// <summary> Gets or sets Target Condition for the configuration. </summary>
        public string TargetCondition { get; set; }
        /// <summary> Gets creation time for the configuration. </summary>
        public DateTimeOffset? CreatedTimeUtc { get; set; }
        /// <summary> Gets last update time for the configuration. </summary>
        public DateTimeOffset? LastUpdatedTimeUtc { get; set; }
        /// <summary> Gets or sets Priority for the configuration. </summary>
        public int? Priority { get; set; }
        /// <summary> System Configuration Metrics. </summary>
        public ConfigurationMetrics SystemMetrics { get; set; }
        /// <summary> Custom Configuration Metrics. </summary>
        public ConfigurationMetrics Metrics { get; set; }
        /// <summary> Gets or sets configuration&apos;s ETag. </summary>
        public string Etag { get; set; }
    }
}
