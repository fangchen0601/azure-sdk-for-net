// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class LoadBalancerSku : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name.Value.ToString());
            }
            writer.WriteEndObject();
        }

        internal static LoadBalancerSku DeserializeLoadBalancerSku(JsonElement element)
        {
            Optional<LoadBalancerSkuName> name = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = new LoadBalancerSkuName(property.Value.GetString());
                    continue;
                }
            }
            return new LoadBalancerSku(Optional.ToNullable(name));
        }
    }
}
