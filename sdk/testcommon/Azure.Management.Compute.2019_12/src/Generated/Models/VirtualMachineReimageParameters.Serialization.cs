// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineReimageParameters : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TempDisk))
            {
                writer.WritePropertyName("tempDisk");
                writer.WriteBooleanValue(TempDisk.Value);
            }
            writer.WriteEndObject();
        }
    }
}
