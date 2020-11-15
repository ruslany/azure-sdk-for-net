// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DevicesForHubOperations.
    /// </summary>
    public static partial class DevicesForHubOperationsExtensions
    {
            /// <summary>
            /// Get list of the devices for the specified IoT Hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='limit'>
            /// Limit the number of items returned in a single page
            /// </param>
            /// <param name='skipToken'>
            /// Skip token used for pagination
            /// </param>
            /// <param name='deviceManagementType'>
            /// Get devices only from specific type, Managed or Unmanaged. Possible values
            /// include: 'Managed', 'Unmanaged'
            /// </param>
            public static IPage<Device> List(this IDevicesForHubOperations operations, string resourceId, int? limit = default(int?), string skipToken = default(string), string deviceManagementType = default(string))
            {
                return operations.ListAsync(resourceId, limit, skipToken, deviceManagementType).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get list of the devices for the specified IoT Hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceId'>
            /// The identifier of the resource.
            /// </param>
            /// <param name='limit'>
            /// Limit the number of items returned in a single page
            /// </param>
            /// <param name='skipToken'>
            /// Skip token used for pagination
            /// </param>
            /// <param name='deviceManagementType'>
            /// Get devices only from specific type, Managed or Unmanaged. Possible values
            /// include: 'Managed', 'Unmanaged'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Device>> ListAsync(this IDevicesForHubOperations operations, string resourceId, int? limit = default(int?), string skipToken = default(string), string deviceManagementType = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceId, limit, skipToken, deviceManagementType, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get list of the devices for the specified IoT Hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Device> ListNext(this IDevicesForHubOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get list of the devices for the specified IoT Hub resource.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Device>> ListNextAsync(this IDevicesForHubOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}