// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Iot.Hub.Service.Models
{
    /// <summary> Gets the corresponding Device&apos;s Status. </summary>
    public readonly partial struct TwinStatus : IEquatable<TwinStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="TwinStatus"/> values are the same. </summary>
        public TwinStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "enabled";
        private const string DisabledValue = "disabled";

        /// <summary> enabled. </summary>
        public static TwinStatus Enabled { get; } = new TwinStatus(EnabledValue);
        /// <summary> disabled. </summary>
        public static TwinStatus Disabled { get; } = new TwinStatus(DisabledValue);
        /// <summary> Determines if two <see cref="TwinStatus"/> values are the same. </summary>
        public static bool operator ==(TwinStatus left, TwinStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TwinStatus"/> values are not the same. </summary>
        public static bool operator !=(TwinStatus left, TwinStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TwinStatus"/>. </summary>
        public static implicit operator TwinStatus(string value) => new TwinStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TwinStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TwinStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
