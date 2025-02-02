// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Workloads;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> The response from the List provider instances operation. </summary>
    internal partial class ProviderInstanceListResult
    {
        /// <summary> Initializes a new instance of <see cref="ProviderInstanceListResult"/>. </summary>
        internal ProviderInstanceListResult()
        {
            Value = new ChangeTrackingList<SapProviderInstanceData>();
        }

        /// <summary> Initializes a new instance of <see cref="ProviderInstanceListResult"/>. </summary>
        /// <param name="value"> The list of provider instances. </param>
        /// <param name="nextLink"> The URL to get the next set of provider instances. </param>
        internal ProviderInstanceListResult(IReadOnlyList<SapProviderInstanceData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of provider instances. </summary>
        public IReadOnlyList<SapProviderInstanceData> Value { get; }
        /// <summary> The URL to get the next set of provider instances. </summary>
        public string NextLink { get; }
    }
}
