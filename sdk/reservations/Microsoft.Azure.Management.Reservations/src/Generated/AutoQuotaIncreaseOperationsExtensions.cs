// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AutoQuotaIncreaseOperations.
    /// </summary>
    public static partial class AutoQuotaIncreaseOperationsExtensions
    {
            /// <summary>
            /// Gets the Auto Quota Increase enrollment details for the specified
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            public static AutoQuotaIncreaseDetail GetProperties(this IAutoQuotaIncreaseOperations operations, string subscriptionId)
            {
                return operations.GetPropertiesAsync(subscriptionId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the Auto Quota Increase enrollment details for the specified
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AutoQuotaIncreaseDetail> GetPropertiesAsync(this IAutoQuotaIncreaseOperations operations, string subscriptionId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPropertiesWithHttpMessagesAsync(subscriptionId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Sets the Auto Quota Increase enrollment properties for the specified
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='autoQuotaIncreaseRequest'>
            /// Auto Quota increase request payload.
            /// </param>
            public static AutoQuotaIncreaseDetail Create(this IAutoQuotaIncreaseOperations operations, string subscriptionId, AutoQuotaIncreaseDetail autoQuotaIncreaseRequest)
            {
                return operations.CreateAsync(subscriptionId, autoQuotaIncreaseRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Sets the Auto Quota Increase enrollment properties for the specified
            /// subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='subscriptionId'>
            /// Azure subscription id.
            /// </param>
            /// <param name='autoQuotaIncreaseRequest'>
            /// Auto Quota increase request payload.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AutoQuotaIncreaseDetail> CreateAsync(this IAutoQuotaIncreaseOperations operations, string subscriptionId, AutoQuotaIncreaseDetail autoQuotaIncreaseRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(subscriptionId, autoQuotaIncreaseRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}