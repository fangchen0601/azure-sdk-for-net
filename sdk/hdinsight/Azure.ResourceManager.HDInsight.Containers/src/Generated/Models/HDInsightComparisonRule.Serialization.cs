// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    public partial class HDInsightComparisonRule : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("operator"u8);
            writer.WriteStringValue(Operator.ToString());
            writer.WritePropertyName("threshold"u8);
            writer.WriteNumberValue(Threshold);
            writer.WriteEndObject();
        }

        internal static HDInsightComparisonRule DeserializeHDInsightComparisonRule(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            HDInsightComparisonOperator @operator = default;
            float threshold = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operator"u8))
                {
                    @operator = new HDInsightComparisonOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("threshold"u8))
                {
                    threshold = property.Value.GetSingle();
                    continue;
                }
            }
            return new HDInsightComparisonRule(@operator, threshold);
        }
    }
}
