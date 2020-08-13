// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    /// <summary> Deployment dependency information. </summary>
    public partial class Dependency
    {
        /// <summary> Initializes a new instance of Dependency. </summary>
        internal Dependency()
        {
            DependsOn = new ChangeTrackingList<BasicDependency>();
        }

        /// <summary> Initializes a new instance of Dependency. </summary>
        /// <param name="dependsOn"> The list of dependencies. </param>
        /// <param name="id"> The ID of the dependency. </param>
        /// <param name="resourceType"> The dependency resource type. </param>
        /// <param name="resourceName"> The dependency resource name. </param>
        internal Dependency(IReadOnlyList<BasicDependency> dependsOn, string id, string resourceType, string resourceName)
        {
            DependsOn = dependsOn;
            Id = id;
            ResourceType = resourceType;
            ResourceName = resourceName;
        }

        /// <summary> The list of dependencies. </summary>
        public IReadOnlyList<BasicDependency> DependsOn { get; }
        /// <summary> The ID of the dependency. </summary>
        public string Id { get; }
        /// <summary> The dependency resource type. </summary>
        public string ResourceType { get; }
        /// <summary> The dependency resource name. </summary>
        public string ResourceName { get; }
    }
}
