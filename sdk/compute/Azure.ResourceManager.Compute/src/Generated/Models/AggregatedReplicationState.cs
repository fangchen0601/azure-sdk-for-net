// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> This is the aggregated replication status based on all the regional replication status flags. </summary>
    public readonly partial struct AggregatedReplicationState : IEquatable<AggregatedReplicationState>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="AggregatedReplicationState"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AggregatedReplicationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string InProgressValue = "InProgress";
        private const string CompletedValue = "Completed";
        private const string FailedValue = "Failed";

        /// <summary> Unknown. </summary>
        public static AggregatedReplicationState Unknown { get; } = new AggregatedReplicationState(UnknownValue);
        /// <summary> InProgress. </summary>
        public static AggregatedReplicationState InProgress { get; } = new AggregatedReplicationState(InProgressValue);
        /// <summary> Completed. </summary>
        public static AggregatedReplicationState Completed { get; } = new AggregatedReplicationState(CompletedValue);
        /// <summary> Failed. </summary>
        public static AggregatedReplicationState Failed { get; } = new AggregatedReplicationState(FailedValue);
        /// <summary> Determines if two <see cref="AggregatedReplicationState"/> values are the same. </summary>
        public static bool operator ==(AggregatedReplicationState left, AggregatedReplicationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AggregatedReplicationState"/> values are not the same. </summary>
        public static bool operator !=(AggregatedReplicationState left, AggregatedReplicationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="AggregatedReplicationState"/>. </summary>
        public static implicit operator AggregatedReplicationState(string value) => new AggregatedReplicationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AggregatedReplicationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AggregatedReplicationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
