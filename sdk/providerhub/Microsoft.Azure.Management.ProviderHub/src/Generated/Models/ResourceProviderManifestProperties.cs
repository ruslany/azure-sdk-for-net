// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ProviderHub.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ResourceProviderManifestProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ResourceProviderManifestProperties class.
        /// </summary>
        public ResourceProviderManifestProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ResourceProviderManifestProperties class.
        /// </summary>
        /// <param name="providerType">Possible values include: 'NotSpecified',
        /// 'Internal', 'External', 'Hidden', 'RegistrationFree',
        /// 'LegacyRegistrationRequired', 'TenantOnly',
        /// 'AuthorizationFree'</param>
        public ResourceProviderManifestProperties(ResourceProviderManifestPropertiesProviderAuthentication providerAuthentication = default(ResourceProviderManifestPropertiesProviderAuthentication), IList<ResourceProviderAuthorization> providerAuthorizations = default(IList<ResourceProviderAuthorization>), string namespaceProperty = default(string), string providerVersion = default(string), string providerType = default(string), IList<string> requiredFeatures = default(IList<string>), ResourceProviderManifestPropertiesFeaturesRule featuresRule = default(ResourceProviderManifestPropertiesFeaturesRule), ResourceProviderManifestPropertiesRequestHeaderOptions requestHeaderOptions = default(ResourceProviderManifestPropertiesRequestHeaderOptions), ResourceProviderManifestPropertiesManagement management = default(ResourceProviderManifestPropertiesManagement), IList<ResourceProviderCapabilities> capabilities = default(IList<ResourceProviderCapabilities>), object metadata = default(object), ResourceProviderManifestPropertiesTemplateDeploymentOptions templateDeploymentOptions = default(ResourceProviderManifestPropertiesTemplateDeploymentOptions))
        {
            ProviderAuthentication = providerAuthentication;
            ProviderAuthorizations = providerAuthorizations;
            NamespaceProperty = namespaceProperty;
            ProviderVersion = providerVersion;
            ProviderType = providerType;
            RequiredFeatures = requiredFeatures;
            FeaturesRule = featuresRule;
            RequestHeaderOptions = requestHeaderOptions;
            Management = management;
            Capabilities = capabilities;
            Metadata = metadata;
            TemplateDeploymentOptions = templateDeploymentOptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerAuthentication")]
        public ResourceProviderManifestPropertiesProviderAuthentication ProviderAuthentication { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerAuthorizations")]
        public IList<ResourceProviderAuthorization> ProviderAuthorizations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "providerVersion")]
        public string ProviderVersion { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'NotSpecified', 'Internal',
        /// 'External', 'Hidden', 'RegistrationFree',
        /// 'LegacyRegistrationRequired', 'TenantOnly', 'AuthorizationFree'
        /// </summary>
        [JsonProperty(PropertyName = "providerType")]
        public string ProviderType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requiredFeatures")]
        public IList<string> RequiredFeatures { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "featuresRule")]
        public ResourceProviderManifestPropertiesFeaturesRule FeaturesRule { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "requestHeaderOptions")]
        public ResourceProviderManifestPropertiesRequestHeaderOptions RequestHeaderOptions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "management")]
        public ResourceProviderManifestPropertiesManagement Management { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "capabilities")]
        public IList<ResourceProviderCapabilities> Capabilities { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "metadata")]
        public object Metadata { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "templateDeploymentOptions")]
        public ResourceProviderManifestPropertiesTemplateDeploymentOptions TemplateDeploymentOptions { get; set; }

    }
}
