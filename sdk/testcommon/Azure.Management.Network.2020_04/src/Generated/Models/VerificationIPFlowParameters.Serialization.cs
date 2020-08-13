// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class VerificationIPFlowParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("targetResourceId");
            writer.WriteStringValue(TargetResourceId);
            writer.WritePropertyName("direction");
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("protocol");
            writer.WriteStringValue(Protocol.ToString());
            writer.WritePropertyName("localPort");
            writer.WriteStringValue(LocalPort);
            writer.WritePropertyName("remotePort");
            writer.WriteStringValue(RemotePort);
            writer.WritePropertyName("localIPAddress");
            writer.WriteStringValue(LocalIPAddress);
            writer.WritePropertyName("remoteIPAddress");
            writer.WriteStringValue(RemoteIPAddress);
            if (Optional.IsDefined(TargetNicResourceId))
            {
                writer.WritePropertyName("targetNicResourceId");
                writer.WriteStringValue(TargetNicResourceId);
            }
            writer.WriteEndObject();
        }
    }
}
