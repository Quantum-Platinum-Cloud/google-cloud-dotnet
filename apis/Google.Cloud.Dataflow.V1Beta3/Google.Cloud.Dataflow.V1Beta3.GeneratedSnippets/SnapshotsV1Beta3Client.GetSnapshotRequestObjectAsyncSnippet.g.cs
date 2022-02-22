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

namespace Google.Cloud.Dataflow.V1Beta3.Snippets
{
    // [START dataflow_v1beta3_generated_SnapshotsV1Beta3_GetSnapshot_async]
    using Google.Cloud.Dataflow.V1Beta3;
    using System.Threading.Tasks;

    public sealed partial class GeneratedSnapshotsV1Beta3ClientSnippets
    {
        /// <summary>Snippet for GetSnapshotAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetSnapshotRequestObjectAsync()
        {
            // Create client
            SnapshotsV1Beta3Client snapshotsV1Beta3Client = await SnapshotsV1Beta3Client.CreateAsync();
            // Initialize request argument(s)
            GetSnapshotRequest request = new GetSnapshotRequest
            {
                ProjectId = "",
                SnapshotId = "",
                Location = "",
            };
            // Make the request
            Snapshot response = await snapshotsV1Beta3Client.GetSnapshotAsync(request);
        }
    }
    // [END dataflow_v1beta3_generated_SnapshotsV1Beta3_GetSnapshot_async]
}