// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class ListQueueResource
    {
        internal static ListQueueResource DeserializeListQueueResource(JsonElement element)
        {
            Optional<IReadOnlyList<ListQueue>> value = default;
            Optional<string> nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    List<ListQueue> array = new List<ListQueue>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ListQueue.DeserializeListQueue(item));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ListQueueResource(Optional.ToList(value), nextLink.Value);
        }
    }
}
