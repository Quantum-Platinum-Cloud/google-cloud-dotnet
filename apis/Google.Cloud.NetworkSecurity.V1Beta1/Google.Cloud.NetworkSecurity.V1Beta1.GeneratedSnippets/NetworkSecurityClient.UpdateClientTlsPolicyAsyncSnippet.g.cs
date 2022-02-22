// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

namespace Google.Cloud.NetworkSecurity.V1Beta1.Snippets
{
    // [START networksecurity_v1beta1_generated_NetworkSecurity_UpdateClientTlsPolicy_async_flattened]
    using Google.Cloud.NetworkSecurity.V1Beta1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;
    using System.Threading.Tasks;

    public sealed partial class GeneratedNetworkSecurityClientSnippets
    {
        /// <summary>Snippet for UpdateClientTlsPolicyAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task UpdateClientTlsPolicyAsync()
        {
            // Create client
            NetworkSecurityClient networkSecurityClient = await NetworkSecurityClient.CreateAsync();
            // Initialize request argument(s)
            ClientTlsPolicy clientTlsPolicy = new ClientTlsPolicy();
            FieldMask updateMask = new FieldMask();
            // Make the request
            Operation<ClientTlsPolicy, OperationMetadata> response = await networkSecurityClient.UpdateClientTlsPolicyAsync(clientTlsPolicy, updateMask);

            // Poll until the returned long-running operation is complete
            Operation<ClientTlsPolicy, OperationMetadata> completedResponse = await response.PollUntilCompletedAsync();
            // Retrieve the operation result
            ClientTlsPolicy result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<ClientTlsPolicy, OperationMetadata> retrievedResponse = await networkSecurityClient.PollOnceUpdateClientTlsPolicyAsync(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                ClientTlsPolicy retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END networksecurity_v1beta1_generated_NetworkSecurity_UpdateClientTlsPolicy_async_flattened]
}