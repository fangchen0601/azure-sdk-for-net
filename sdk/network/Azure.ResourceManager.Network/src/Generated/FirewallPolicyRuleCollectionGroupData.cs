// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the FirewallPolicyRuleCollectionGroup data model. </summary>
    public partial class FirewallPolicyRuleCollectionGroupData : NetworkResourceData
    {
        /// <summary> Initializes a new instance of FirewallPolicyRuleCollectionGroupData. </summary>
        public FirewallPolicyRuleCollectionGroupData()
        {
            RuleCollections = new ChangeTrackingList<FirewallPolicyRuleCollection>();
        }

        /// <summary> Initializes a new instance of FirewallPolicyRuleCollectionGroupData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="priority"> Priority of the Firewall Policy Rule Collection Group resource. </param>
        /// <param name="ruleCollections"> Group of Firewall Policy rule collections. </param>
        /// <param name="provisioningState"> The provisioning state of the firewall policy rule collection group resource. </param>
        internal FirewallPolicyRuleCollectionGroupData(ResourceIdentifier id, string name, ResourceType? resourceType, string etag, int? priority, IList<FirewallPolicyRuleCollection> ruleCollections, NetworkProvisioningState? provisioningState) : base(id, name, resourceType)
        {
            Etag = etag;
            Priority = priority;
            RuleCollections = ruleCollections;
            ProvisioningState = provisioningState;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> Priority of the Firewall Policy Rule Collection Group resource. </summary>
        public int? Priority { get; set; }
        /// <summary> Group of Firewall Policy rule collections. </summary>
        public IList<FirewallPolicyRuleCollection> RuleCollections { get; }
        /// <summary> The provisioning state of the firewall policy rule collection group resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
    }
}
