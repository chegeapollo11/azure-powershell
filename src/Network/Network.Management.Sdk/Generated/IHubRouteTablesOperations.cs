// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// HubRouteTablesOperations operations.
    /// </summary>
    public partial interface IHubRouteTablesOperations
    {
        /// <summary>
        /// Creates a RouteTable resource if it doesn&#39;t exist else updates the existing
        /// RouteTable.
        /// </summary>
        /// <remarks>
        /// Creates a RouteTable resource if it doesn&#39;t exist else updates the existing
        /// RouteTable.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='routeTableParameters'>
        /// Parameters supplied to create or update RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<HubRouteTable>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, HubRouteTable routeTableParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the details of a RouteTable.
        /// </summary>
        /// <remarks>
        /// Retrieves the details of a RouteTable.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<HubRouteTable>> GetWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes a RouteTable.
        /// </summary>
        /// <remarks>
        /// Deletes a RouteTable.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the RouteTable.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the details of all RouteTables.
        /// </summary>
        /// <remarks>
        /// Retrieves the details of all RouteTables.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<HubRouteTable>>> ListWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Creates a RouteTable resource if it doesn&#39;t exist else updates the existing
        /// RouteTable.
        /// </summary>
        /// <remarks>
        /// Creates a RouteTable resource if it doesn&#39;t exist else updates the existing
        /// RouteTable.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VirtualHub.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='routeTableParameters'>
        /// Parameters supplied to create or update RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<HubRouteTable>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, HubRouteTable routeTableParameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Deletes a RouteTable.
        /// </summary>
        /// <remarks>
        /// Deletes a RouteTable.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The resource group name of the RouteTable.
        /// </param>
        /// <param name='virtualHubName'>
        /// The name of the VirtualHub.
        /// </param>
        /// <param name='routeTableName'>
        /// The name of the RouteTable.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string virtualHubName, string routeTableName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Retrieves the details of all RouteTables.
        /// </summary>
        /// <remarks>
        /// Retrieves the details of all RouteTables.
        /// </remarks>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<HubRouteTable>>> ListNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

    }
}