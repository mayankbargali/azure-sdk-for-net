// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary>
    /// Required.
    /// 
    /// The type of job to execute.
    /// </summary>
    public readonly partial struct JobPropertiesType : IEquatable<JobPropertiesType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="JobPropertiesType"/> values are the same. </summary>
        public JobPropertiesType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "unknown";
        private const string ExportValue = "export";
        private const string ImportValue = "import";
        private const string BackupValue = "backup";
        private const string ReadDevicePropertiesValue = "readDeviceProperties";
        private const string WriteDevicePropertiesValue = "writeDeviceProperties";
        private const string UpdateDeviceConfigurationValue = "updateDeviceConfiguration";
        private const string RebootDeviceValue = "rebootDevice";
        private const string FactoryResetDeviceValue = "factoryResetDevice";
        private const string FirmwareUpdateValue = "firmwareUpdate";
        private const string ScheduleDeviceMethodValue = "scheduleDeviceMethod";
        private const string ScheduleUpdateTwinValue = "scheduleUpdateTwin";
        private const string RestoreFromBackupValue = "restoreFromBackup";
        private const string FailoverDataCopyValue = "failoverDataCopy";

        /// <summary> unknown. </summary>
        public static JobPropertiesType Unknown { get; } = new JobPropertiesType(UnknownValue);
        /// <summary> export. </summary>
        public static JobPropertiesType Export { get; } = new JobPropertiesType(ExportValue);
        /// <summary> import. </summary>
        public static JobPropertiesType Import { get; } = new JobPropertiesType(ImportValue);
        /// <summary> backup. </summary>
        public static JobPropertiesType Backup { get; } = new JobPropertiesType(BackupValue);
        /// <summary> readDeviceProperties. </summary>
        public static JobPropertiesType ReadDeviceProperties { get; } = new JobPropertiesType(ReadDevicePropertiesValue);
        /// <summary> writeDeviceProperties. </summary>
        public static JobPropertiesType WriteDeviceProperties { get; } = new JobPropertiesType(WriteDevicePropertiesValue);
        /// <summary> updateDeviceConfiguration. </summary>
        public static JobPropertiesType UpdateDeviceConfiguration { get; } = new JobPropertiesType(UpdateDeviceConfigurationValue);
        /// <summary> rebootDevice. </summary>
        public static JobPropertiesType RebootDevice { get; } = new JobPropertiesType(RebootDeviceValue);
        /// <summary> factoryResetDevice. </summary>
        public static JobPropertiesType FactoryResetDevice { get; } = new JobPropertiesType(FactoryResetDeviceValue);
        /// <summary> firmwareUpdate. </summary>
        public static JobPropertiesType FirmwareUpdate { get; } = new JobPropertiesType(FirmwareUpdateValue);
        /// <summary> scheduleDeviceMethod. </summary>
        public static JobPropertiesType ScheduleDeviceMethod { get; } = new JobPropertiesType(ScheduleDeviceMethodValue);
        /// <summary> scheduleUpdateTwin. </summary>
        public static JobPropertiesType ScheduleUpdateTwin { get; } = new JobPropertiesType(ScheduleUpdateTwinValue);
        /// <summary> restoreFromBackup. </summary>
        public static JobPropertiesType RestoreFromBackup { get; } = new JobPropertiesType(RestoreFromBackupValue);
        /// <summary> failoverDataCopy. </summary>
        public static JobPropertiesType FailoverDataCopy { get; } = new JobPropertiesType(FailoverDataCopyValue);
        /// <summary> Determines if two <see cref="JobPropertiesType"/> values are the same. </summary>
        public static bool operator ==(JobPropertiesType left, JobPropertiesType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="JobPropertiesType"/> values are not the same. </summary>
        public static bool operator !=(JobPropertiesType left, JobPropertiesType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="JobPropertiesType"/>. </summary>
        public static implicit operator JobPropertiesType(string value) => new JobPropertiesType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is JobPropertiesType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(JobPropertiesType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
