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

namespace Google.Cloud.Retail.V2.Snippets
{
    // [START retail_v2_generated_ProductService_RemoveLocalInventories_sync_flattened]
    using Google.Cloud.Retail.V2;
    using Google.LongRunning;

    public sealed partial class GeneratedProductServiceClientSnippets
    {
        /// <summary>Snippet for RemoveLocalInventories</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void RemoveLocalInventories()
        {
            // Create client
            ProductServiceClient productServiceClient = ProductServiceClient.Create();
            // Initialize request argument(s)
            string product = "projects/[PROJECT]/locations/[LOCATION]/catalogs/[CATALOG]/branches/[BRANCH]/products/[PRODUCT]";
            // Make the request
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> response = productServiceClient.RemoveLocalInventories(product);

            // Poll until the returned long-running operation is complete
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            RemoveLocalInventoriesResponse result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<RemoveLocalInventoriesResponse, RemoveLocalInventoriesMetadata> retrievedResponse = productServiceClient.PollOnceRemoveLocalInventories(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                RemoveLocalInventoriesResponse retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END retail_v2_generated_ProductService_RemoveLocalInventories_sync_flattened]
}