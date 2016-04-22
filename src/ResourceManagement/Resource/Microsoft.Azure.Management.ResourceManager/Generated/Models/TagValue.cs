// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Tag information.
    /// </summary>
    public partial class TagValue
    {
        /// <summary>
        /// Initializes a new instance of the TagValue class.
        /// </summary>
        public TagValue() { }

        /// <summary>
        /// Initializes a new instance of the TagValue class.
        /// </summary>
        public TagValue(string id = default(string), string tagValueProperty = default(string), TagCount count = default(TagCount))
        {
            Id = id;
            TagValueProperty = tagValueProperty;
            Count = count;
        }

        /// <summary>
        /// Gets or sets the tag ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the tag value.
        /// </summary>
        [JsonProperty(PropertyName = "tagValue")]
        public string TagValueProperty { get; set; }

        /// <summary>
        /// Gets or sets the tag value count.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public TagCount Count { get; set; }

    }
}
