// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> Represents the MediaGraphTopologyDeleteRequest. </summary>
    public partial class MediaGraphTopologyDeleteRequest : ItemNonSetRequestBase
    {
        /// <summary> Initializes a new instance of MediaGraphTopologyDeleteRequest. </summary>
        /// <param name="name"> method name. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public MediaGraphTopologyDeleteRequest(string name) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            MethodName = "GraphTopologyDelete";
        }

        /// <summary> Initializes a new instance of MediaGraphTopologyDeleteRequest. </summary>
        /// <param name="methodName"> method name. </param>
        /// <param name="apiVersion"> api version. </param>
        /// <param name="name"> method name. </param>
        internal MediaGraphTopologyDeleteRequest(string methodName, string apiVersion, string name) : base(methodName, apiVersion, name)
        {
            MethodName = methodName ?? "GraphTopologyDelete";
        }
    }
}