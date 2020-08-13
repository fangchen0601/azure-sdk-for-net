// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ManagementPolicyBaseBlob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(TierToCool))
            {
                writer.WritePropertyName("tierToCool");
                writer.WriteObjectValue(TierToCool);
            }
            if (Optional.IsDefined(TierToArchive))
            {
                writer.WritePropertyName("tierToArchive");
                writer.WriteObjectValue(TierToArchive);
            }
            if (Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete");
                writer.WriteObjectValue(Delete);
            }
            writer.WriteEndObject();
        }

        internal static ManagementPolicyBaseBlob DeserializeManagementPolicyBaseBlob(JsonElement element)
        {
            Optional<DateAfterModification> tierToCool = default;
            Optional<DateAfterModification> tierToArchive = default;
            Optional<DateAfterModification> delete = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tierToCool"))
                {
                    tierToCool = DateAfterModification.DeserializeDateAfterModification(property.Value);
                    continue;
                }
                if (property.NameEquals("tierToArchive"))
                {
                    tierToArchive = DateAfterModification.DeserializeDateAfterModification(property.Value);
                    continue;
                }
                if (property.NameEquals("delete"))
                {
                    delete = DateAfterModification.DeserializeDateAfterModification(property.Value);
                    continue;
                }
            }
            return new ManagementPolicyBaseBlob(tierToCool.Value, tierToArchive.Value, delete.Value);
        }
    }
}
