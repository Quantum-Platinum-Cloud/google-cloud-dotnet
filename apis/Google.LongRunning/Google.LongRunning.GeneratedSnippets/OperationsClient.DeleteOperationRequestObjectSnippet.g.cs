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

namespace Google.LongRunning.Snippets
{
    // [START longrunning_generated_Operations_DeleteOperation_sync]
    using Google.LongRunning;

    public sealed partial class GeneratedOperationsClientSnippets
    {
        /// <summary>Snippet for DeleteOperation</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void DeleteOperationRequestObject()
        {
            // Create client
            OperationsClient operationsClient = OperationsClient.Create();
            // Initialize request argument(s)
            DeleteOperationRequest request = new DeleteOperationRequest { Name = "", };
            // Make the request
            operationsClient.DeleteOperation(request);
        }
    }
    // [END longrunning_generated_Operations_DeleteOperation_sync]
}