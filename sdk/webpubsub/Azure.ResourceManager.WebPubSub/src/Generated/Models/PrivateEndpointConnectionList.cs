// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.WebPubSub;

namespace Azure.ResourceManager.WebPubSub.Models
{
    /// <summary> A list of private endpoint connections. </summary>
    internal partial class PrivateEndpointConnectionList
    {
        /// <summary> Initializes a new instance of PrivateEndpointConnectionList. </summary>
        internal PrivateEndpointConnectionList()
        {
            Value = new ChangeTrackingList<WebPubSubPrivateEndpointConnectionData>();
        }

        /// <summary> Initializes a new instance of PrivateEndpointConnectionList. </summary>
        /// <param name="value"> The list of the private endpoint connections. </param>
        /// <param name="nextLink"> Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested private endpoint connections exceed maximum page size. </param>
        internal PrivateEndpointConnectionList(IReadOnlyList<WebPubSubPrivateEndpointConnectionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of the private endpoint connections. </summary>
        public IReadOnlyList<WebPubSubPrivateEndpointConnectionData> Value { get; }
        /// <summary> Request URL that can be used to query next page of private endpoint connections. Returned when the total number of requested private endpoint connections exceed maximum page size. </summary>
        public string NextLink { get; }
    }
}
