// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Search.Models
{
    using Azure;
    using Search;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines a data change detection policy that captures changes using the
    /// Integrated Change Tracking feature of Azure SQL Database.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Azure.Search.SqlIntegratedChangeTrackingPolicy")]
    public partial class SqlIntegratedChangeTrackingPolicy : DataChangeDetectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the SqlIntegratedChangeTrackingPolicy
        /// class.
        /// </summary>
        public SqlIntegratedChangeTrackingPolicy() { }


    }
}

