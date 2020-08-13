// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Management.Network.Models
{
    /// <summary> The type of issue. </summary>
    public readonly partial struct IssueType : IEquatable<IssueType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="IssueType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IssueType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UnknownValue = "Unknown";
        private const string AgentStoppedValue = "AgentStopped";
        private const string GuestFirewallValue = "GuestFirewall";
        private const string DnsResolutionValue = "DnsResolution";
        private const string SocketBindValue = "SocketBind";
        private const string NetworkSecurityRuleValue = "NetworkSecurityRule";
        private const string UserDefinedRouteValue = "UserDefinedRoute";
        private const string PortThrottledValue = "PortThrottled";
        private const string PlatformValue = "Platform";

        /// <summary> Unknown. </summary>
        public static IssueType Unknown { get; } = new IssueType(UnknownValue);
        /// <summary> AgentStopped. </summary>
        public static IssueType AgentStopped { get; } = new IssueType(AgentStoppedValue);
        /// <summary> GuestFirewall. </summary>
        public static IssueType GuestFirewall { get; } = new IssueType(GuestFirewallValue);
        /// <summary> DnsResolution. </summary>
        public static IssueType DnsResolution { get; } = new IssueType(DnsResolutionValue);
        /// <summary> SocketBind. </summary>
        public static IssueType SocketBind { get; } = new IssueType(SocketBindValue);
        /// <summary> NetworkSecurityRule. </summary>
        public static IssueType NetworkSecurityRule { get; } = new IssueType(NetworkSecurityRuleValue);
        /// <summary> UserDefinedRoute. </summary>
        public static IssueType UserDefinedRoute { get; } = new IssueType(UserDefinedRouteValue);
        /// <summary> PortThrottled. </summary>
        public static IssueType PortThrottled { get; } = new IssueType(PortThrottledValue);
        /// <summary> Platform. </summary>
        public static IssueType Platform { get; } = new IssueType(PlatformValue);
        /// <summary> Determines if two <see cref="IssueType"/> values are the same. </summary>
        public static bool operator ==(IssueType left, IssueType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IssueType"/> values are not the same. </summary>
        public static bool operator !=(IssueType left, IssueType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IssueType"/>. </summary>
        public static implicit operator IssueType(string value) => new IssueType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IssueType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IssueType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
