// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Cdn.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn
{
    /// <summary> A class representing the CdnEndpoint data model. </summary>
    public partial class CdnEndpointData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of CdnEndpointData. </summary>
        /// <param name="location"> The location. </param>
        public CdnEndpointData(AzureLocation location) : base(location)
        {
            ContentTypesToCompress = new ChangeTrackingList<string>();
            GeoFilters = new ChangeTrackingList<GeoFilter>();
            UriSigningKeys = new ChangeTrackingList<UriSigningKey>();
            Origins = new ChangeTrackingList<DeepCreatedOrigin>();
            OriginGroups = new ChangeTrackingList<DeepCreatedOriginGroup>();
            CustomDomains = new ChangeTrackingList<CdnCustomDomainData>();
        }

        /// <summary> Initializes a new instance of CdnEndpointData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="originPath"> A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath. </param>
        /// <param name="contentTypesToCompress"> List of content types on which compression applies. The value should be a valid MIME type. </param>
        /// <param name="originHostHeader"> The host header value sent to the origin with each request. This property at Endpoint is only allowed when endpoint uses single origin and can be overridden by the same property specified at origin.If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. </param>
        /// <param name="isCompressionEnabled"> Indicates whether content compression is enabled on CDN. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won&apos;t be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB. </param>
        /// <param name="isHttpAllowed"> Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed. </param>
        /// <param name="isHttpsAllowed"> Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed. </param>
        /// <param name="queryStringCachingBehavior"> Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL. </param>
        /// <param name="optimizationType"> Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g. Download, Media services. With this information, CDN can apply scenario driven optimization. </param>
        /// <param name="probePath"> Path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin path. This property is only relevant when using a single origin. </param>
        /// <param name="geoFilters"> List of rules defining the user&apos;s geo access within a CDN endpoint. Each geo filter defines an access rule to a specified path or content, e.g. block APAC for path /pictures/. </param>
        /// <param name="defaultOriginGroup"> A reference to the origin group. </param>
        /// <param name="uriSigningKeys"> List of keys used to validate the signed URL hashes. </param>
        /// <param name="deliveryPolicy"> A policy that specifies the delivery rules to be used for an endpoint. </param>
        /// <param name="webApplicationFirewallPolicyLink"> Defines the Web Application Firewall policy for the endpoint (if applicable). </param>
        /// <param name="hostName"> The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net. </param>
        /// <param name="origins"> The source of the content being delivered via CDN. </param>
        /// <param name="originGroups"> The origin groups comprising of origins that are used for load balancing the traffic based on availability. </param>
        /// <param name="customDomains"> The custom domains under the endpoint. </param>
        /// <param name="resourceState"> Resource status of the endpoint. </param>
        /// <param name="provisioningState"> Provisioning status of the endpoint. </param>
        internal CdnEndpointData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string originPath, IList<string> contentTypesToCompress, string originHostHeader, bool? isCompressionEnabled, bool? isHttpAllowed, bool? isHttpsAllowed, QueryStringCachingBehavior? queryStringCachingBehavior, OptimizationType? optimizationType, string probePath, IList<GeoFilter> geoFilters, EndpointPropertiesUpdateParametersDefaultOriginGroup defaultOriginGroup, IList<UriSigningKey> uriSigningKeys, EndpointDeliveryPolicy deliveryPolicy, EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink webApplicationFirewallPolicyLink, string hostName, IList<DeepCreatedOrigin> origins, IList<DeepCreatedOriginGroup> originGroups, IReadOnlyList<CdnCustomDomainData> customDomains, EndpointResourceState? resourceState, string provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            OriginPath = originPath;
            ContentTypesToCompress = contentTypesToCompress;
            OriginHostHeader = originHostHeader;
            IsCompressionEnabled = isCompressionEnabled;
            IsHttpAllowed = isHttpAllowed;
            IsHttpsAllowed = isHttpsAllowed;
            QueryStringCachingBehavior = queryStringCachingBehavior;
            OptimizationType = optimizationType;
            ProbePath = probePath;
            GeoFilters = geoFilters;
            DefaultOriginGroup = defaultOriginGroup;
            UriSigningKeys = uriSigningKeys;
            DeliveryPolicy = deliveryPolicy;
            WebApplicationFirewallPolicyLink = webApplicationFirewallPolicyLink;
            HostName = hostName;
            Origins = origins;
            OriginGroups = originGroups;
            CustomDomains = customDomains;
            ResourceState = resourceState;
            ProvisioningState = provisioningState;
        }

        /// <summary> A directory path on the origin that CDN can use to retrieve content from, e.g. contoso.cloudapp.net/originpath. </summary>
        public string OriginPath { get; set; }
        /// <summary> List of content types on which compression applies. The value should be a valid MIME type. </summary>
        public IList<string> ContentTypesToCompress { get; }
        /// <summary> The host header value sent to the origin with each request. This property at Endpoint is only allowed when endpoint uses single origin and can be overridden by the same property specified at origin.If you leave this blank, the request hostname determines this value. Azure CDN origins, such as Web Apps, Blob Storage, and Cloud Services require this host header value to match the origin hostname by default. </summary>
        public string OriginHostHeader { get; set; }
        /// <summary> Indicates whether content compression is enabled on CDN. Default value is false. If compression is enabled, content will be served as compressed if user requests for a compressed version. Content won&apos;t be compressed on CDN when requested content is smaller than 1 byte or larger than 1 MB. </summary>
        public bool? IsCompressionEnabled { get; set; }
        /// <summary> Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed. </summary>
        public bool? IsHttpAllowed { get; set; }
        /// <summary> Indicates whether HTTPS traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed. </summary>
        public bool? IsHttpsAllowed { get; set; }
        /// <summary> Defines how CDN caches requests that include query strings. You can ignore any query strings when caching, bypass caching to prevent requests that contain query strings from being cached, or cache every request with a unique URL. </summary>
        public QueryStringCachingBehavior? QueryStringCachingBehavior { get; set; }
        /// <summary> Specifies what scenario the customer wants this CDN endpoint to optimize for, e.g. Download, Media services. With this information, CDN can apply scenario driven optimization. </summary>
        public OptimizationType? OptimizationType { get; set; }
        /// <summary> Path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the origin path. This property is only relevant when using a single origin. </summary>
        public string ProbePath { get; set; }
        /// <summary> List of rules defining the user&apos;s geo access within a CDN endpoint. Each geo filter defines an access rule to a specified path or content, e.g. block APAC for path /pictures/. </summary>
        public IList<GeoFilter> GeoFilters { get; }
        /// <summary> A reference to the origin group. </summary>
        internal EndpointPropertiesUpdateParametersDefaultOriginGroup DefaultOriginGroup { get; set; }
        /// <summary> Resource ID. </summary>
        public ResourceIdentifier DefaultOriginGroupId
        {
            get => DefaultOriginGroup is null ? default : DefaultOriginGroup.Id;
            set
            {
                if (DefaultOriginGroup is null)
                    DefaultOriginGroup = new EndpointPropertiesUpdateParametersDefaultOriginGroup();
                DefaultOriginGroup.Id = value;
            }
        }

        /// <summary> List of keys used to validate the signed URL hashes. </summary>
        public IList<UriSigningKey> UriSigningKeys { get; set; }
        /// <summary> A policy that specifies the delivery rules to be used for an endpoint. </summary>
        public EndpointDeliveryPolicy DeliveryPolicy { get; set; }
        /// <summary> Defines the Web Application Firewall policy for the endpoint (if applicable). </summary>
        internal EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink WebApplicationFirewallPolicyLink { get; set; }
        /// <summary> Resource ID. </summary>
        public ResourceIdentifier WebApplicationFirewallPolicyLinkId
        {
            get => WebApplicationFirewallPolicyLink is null ? default : WebApplicationFirewallPolicyLink.Id;
            set
            {
                if (WebApplicationFirewallPolicyLink is null)
                    WebApplicationFirewallPolicyLink = new EndpointPropertiesUpdateParametersWebApplicationFirewallPolicyLink();
                WebApplicationFirewallPolicyLink.Id = value;
            }
        }

        /// <summary> The host name of the endpoint structured as {endpointName}.{DNSZone}, e.g. contoso.azureedge.net. </summary>
        public string HostName { get; }
        /// <summary> The source of the content being delivered via CDN. </summary>
        public IList<DeepCreatedOrigin> Origins { get; }
        /// <summary> The origin groups comprising of origins that are used for load balancing the traffic based on availability. </summary>
        public IList<DeepCreatedOriginGroup> OriginGroups { get; }
        /// <summary> The custom domains under the endpoint. </summary>
        public IReadOnlyList<CdnCustomDomainData> CustomDomains { get; }
        /// <summary> Resource status of the endpoint. </summary>
        public EndpointResourceState? ResourceState { get; }
        /// <summary> Provisioning status of the endpoint. </summary>
        public string ProvisioningState { get; }
    }
}
