// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The DistributionConfiguration. </summary>
    public partial class DistributionConfiguration
    {
        /// <summary> Initializes a new instance of DistributionConfiguration. </summary>
        public DistributionConfiguration()
        {
        }

        /// <summary> Initializes a new instance of DistributionConfiguration. </summary>
        /// <param name="distributionType"> Specifies the type of distribution framework. </param>
        internal DistributionConfiguration(DistributionType distributionType)
        {
            DistributionType = distributionType;
        }

        /// <summary> Specifies the type of distribution framework. </summary>
        internal DistributionType DistributionType { get; set; }
    }
}