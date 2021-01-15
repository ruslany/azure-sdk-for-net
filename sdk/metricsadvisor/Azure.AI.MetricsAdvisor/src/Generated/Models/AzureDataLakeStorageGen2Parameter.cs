// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureDataLakeStorageGen2Parameter. </summary>
    internal partial class AzureDataLakeStorageGen2Parameter
    {
        /// <summary> Initializes a new instance of AzureDataLakeStorageGen2Parameter. </summary>
        /// <param name="accountName"> Account name. </param>
        /// <param name="accountKey"> Account key. </param>
        /// <param name="fileSystemName"> File system name (Container). </param>
        /// <param name="directoryTemplate"> Directory template. </param>
        /// <param name="fileTemplate"> File template. </param>
        public AzureDataLakeStorageGen2Parameter(string accountName, string accountKey, string fileSystemName, string directoryTemplate, string fileTemplate)
        {
            AccountName = accountName;
            AccountKey = accountKey;
            FileSystemName = fileSystemName;
            DirectoryTemplate = directoryTemplate;
            FileTemplate = fileTemplate;
        }

        /// <summary> Account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Account key. </summary>
        public string AccountKey { get; set; }
        /// <summary> File system name (Container). </summary>
        public string FileSystemName { get; set; }
        /// <summary> Directory template. </summary>
        public string DirectoryTemplate { get; set; }
        /// <summary> File template. </summary>
        public string FileTemplate { get; set; }
    }
}