// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> An Azure Cosmos DB MongoDB database event. </summary>
    public partial class RestorableMongodbDatabase : Resource
    {
        /// <summary> Initializes a new instance of RestorableMongodbDatabase. </summary>
        internal RestorableMongodbDatabase()
        {
        }

        /// <summary> Initializes a new instance of RestorableMongodbDatabase. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="resource"> The resource of an Azure Cosmos DB MongoDB database event. </param>
        internal RestorableMongodbDatabase(ResourceIdentifier id, string name, ResourceType type, RestorableMongodbDatabasePropertiesResource resource) : base(id, name, type)
        {
            Resource = resource;
        }

        /// <summary> The resource of an Azure Cosmos DB MongoDB database event. </summary>
        public RestorableMongodbDatabasePropertiesResource Resource { get; }
    }
}
