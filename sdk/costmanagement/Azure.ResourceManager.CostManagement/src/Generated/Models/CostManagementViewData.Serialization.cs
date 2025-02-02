// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.CostManagement
{
    public partial class CostManagementViewData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("eTag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(Chart))
            {
                writer.WritePropertyName("chart"u8);
                writer.WriteStringValue(Chart.Value.ToString());
            }
            if (Optional.IsDefined(Accumulated))
            {
                writer.WritePropertyName("accumulated"u8);
                writer.WriteStringValue(Accumulated.Value.ToString());
            }
            if (Optional.IsDefined(Metric))
            {
                writer.WritePropertyName("metric"u8);
                writer.WriteStringValue(Metric.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Kpis))
            {
                writer.WritePropertyName("kpis"u8);
                writer.WriteStartArray();
                foreach (var item in Kpis)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Pivots))
            {
                writer.WritePropertyName("pivots"u8);
                writer.WriteStartArray();
                foreach (var item in Pivots)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("query"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(TypePropertiesQueryType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(TypePropertiesQueryType.Value.ToString());
            }
            if (Optional.IsDefined(Timeframe))
            {
                writer.WritePropertyName("timeframe"u8);
                writer.WriteStringValue(Timeframe.Value.ToString());
            }
            if (Optional.IsDefined(TimePeriod))
            {
                writer.WritePropertyName("timePeriod"u8);
                writer.WriteObjectValue(TimePeriod);
            }
            if (Optional.IsDefined(DataSet))
            {
                writer.WritePropertyName("dataSet"u8);
                writer.WriteObjectValue(DataSet);
            }
            if (Optional.IsDefined(IncludeMonetaryCommitment))
            {
                writer.WritePropertyName("includeMonetaryCommitment"u8);
                writer.WriteBooleanValue(IncludeMonetaryCommitment.Value);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
