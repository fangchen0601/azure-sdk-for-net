// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Network.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing the VpnGateway data model. </summary>
    public partial class VpnGatewayData : NetworkTrackedResourceData
    {
        /// <summary> Initializes a new instance of VpnGatewayData. </summary>
        public VpnGatewayData()
        {
            Connections = new ChangeTrackingList<VpnConnectionData>();
            IPConfigurations = new ChangeTrackingList<VpnGatewayIPConfiguration>();
            NatRules = new ChangeTrackingList<VpnGatewayNatRuleData>();
        }

        /// <summary> Initializes a new instance of VpnGatewayData. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="resourceType"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="etag"> A unique read-only string that changes whenever the resource is updated. </param>
        /// <param name="virtualHub"> The VirtualHub to which the gateway belongs. </param>
        /// <param name="connections"> List of all vpn connections to the gateway. </param>
        /// <param name="bgpSettings"> Local network gateway&apos;s BGP speaker settings. </param>
        /// <param name="provisioningState"> The provisioning state of the VPN gateway resource. </param>
        /// <param name="vpnGatewayScaleUnit"> The scale unit for this vpn gateway. </param>
        /// <param name="ipConfigurations"> List of all IPs configured on the gateway. </param>
        /// <param name="isRoutingPreferenceInternet"> Enable Routing Preference property for the Public IP Interface of the VpnGateway. </param>
        /// <param name="natRules"> List of all the nat Rules associated with the gateway. </param>
        internal VpnGatewayData(ResourceIdentifier id, string name, ResourceType? resourceType, AzureLocation? location, IDictionary<string, string> tags, string etag, WritableSubResource virtualHub, IList<VpnConnectionData> connections, BgpSettings bgpSettings, NetworkProvisioningState? provisioningState, int? vpnGatewayScaleUnit, IReadOnlyList<VpnGatewayIPConfiguration> ipConfigurations, bool? isRoutingPreferenceInternet, IList<VpnGatewayNatRuleData> natRules) : base(id, name, resourceType, location, tags)
        {
            Etag = etag;
            VirtualHub = virtualHub;
            Connections = connections;
            BgpSettings = bgpSettings;
            ProvisioningState = provisioningState;
            VpnGatewayScaleUnit = vpnGatewayScaleUnit;
            IPConfigurations = ipConfigurations;
            IsRoutingPreferenceInternet = isRoutingPreferenceInternet;
            NatRules = natRules;
        }

        /// <summary> A unique read-only string that changes whenever the resource is updated. </summary>
        public string Etag { get; }
        /// <summary> The VirtualHub to which the gateway belongs. </summary>
        internal WritableSubResource VirtualHub { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier VirtualHubId
        {
            get => VirtualHub is null ? default : VirtualHub.Id;
            set
            {
                if (VirtualHub is null)
                    VirtualHub = new WritableSubResource();
                VirtualHub.Id = value;
            }
        }

        /// <summary> List of all vpn connections to the gateway. </summary>
        public IList<VpnConnectionData> Connections { get; }
        /// <summary> Local network gateway&apos;s BGP speaker settings. </summary>
        public BgpSettings BgpSettings { get; set; }
        /// <summary> The provisioning state of the VPN gateway resource. </summary>
        public NetworkProvisioningState? ProvisioningState { get; }
        /// <summary> The scale unit for this vpn gateway. </summary>
        public int? VpnGatewayScaleUnit { get; set; }
        /// <summary> List of all IPs configured on the gateway. </summary>
        public IReadOnlyList<VpnGatewayIPConfiguration> IPConfigurations { get; }
        /// <summary> Enable Routing Preference property for the Public IP Interface of the VpnGateway. </summary>
        public bool? IsRoutingPreferenceInternet { get; set; }
        /// <summary> List of all the nat Rules associated with the gateway. </summary>
        public IList<VpnGatewayNatRuleData> NatRules { get; }
    }
}
