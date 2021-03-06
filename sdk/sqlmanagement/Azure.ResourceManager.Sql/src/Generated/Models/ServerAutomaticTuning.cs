// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Server-level Automatic Tuning. </summary>
    public partial class ServerAutomaticTuning : ProxyResource
    {
        /// <summary> Initializes a new instance of ServerAutomaticTuning. </summary>
        public ServerAutomaticTuning()
        {
            Options = new ChangeTrackingDictionary<string, AutomaticTuningServerOptions>();
        }

        /// <summary> Initializes a new instance of ServerAutomaticTuning. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="desiredState"> Automatic tuning desired state. </param>
        /// <param name="actualState"> Automatic tuning actual state. </param>
        /// <param name="options"> Automatic tuning options definition. </param>
        internal ServerAutomaticTuning(string id, string name, string type, AutomaticTuningServerMode? desiredState, AutomaticTuningServerMode? actualState, IDictionary<string, AutomaticTuningServerOptions> options) : base(id, name, type)
        {
            DesiredState = desiredState;
            ActualState = actualState;
            Options = options;
        }

        /// <summary> Automatic tuning desired state. </summary>
        public AutomaticTuningServerMode? DesiredState { get; set; }
        /// <summary> Automatic tuning actual state. </summary>
        public AutomaticTuningServerMode? ActualState { get; }
        /// <summary> Automatic tuning options definition. </summary>
        public IDictionary<string, AutomaticTuningServerOptions> Options { get; }
    }
}
