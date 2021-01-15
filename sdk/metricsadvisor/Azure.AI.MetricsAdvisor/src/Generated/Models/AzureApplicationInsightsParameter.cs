// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureApplicationInsightsParameter. </summary>
    internal partial class AzureApplicationInsightsParameter
    {
        /// <summary> Initializes a new instance of AzureApplicationInsightsParameter. </summary>
        /// <param name="azureCloud"> Azure cloud environment. </param>
        /// <param name="applicationId"> Azure Application Insights ID. </param>
        /// <param name="apiKey"> API Key. </param>
        /// <param name="query"> Query. </param>
        public AzureApplicationInsightsParameter(string azureCloud, string applicationId, string apiKey, string query)
        {
            AzureCloud = azureCloud;
            ApplicationId = applicationId;
            ApiKey = apiKey;
            Query = query;
        }

        /// <summary> Azure cloud environment. </summary>
        public string AzureCloud { get; set; }
        /// <summary> Azure Application Insights ID. </summary>
        public string ApplicationId { get; set; }
        /// <summary> API Key. </summary>
        public string ApiKey { get; set; }
        /// <summary> Query. </summary>
        public string Query { get; set; }
    }
}