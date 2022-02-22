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

namespace Google.Cloud.Debugger.V2.Snippets
{
    // [START clouddebugger_v2_generated_Controller2_ListActiveBreakpoints_sync]
    using Google.Cloud.Debugger.V2;

    public sealed partial class GeneratedController2ClientSnippets
    {
        /// <summary>Snippet for ListActiveBreakpoints</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void ListActiveBreakpointsRequestObject()
        {
            // Create client
            Controller2Client controller2Client = Controller2Client.Create();
            // Initialize request argument(s)
            ListActiveBreakpointsRequest request = new ListActiveBreakpointsRequest
            {
                DebuggeeId = "",
                WaitToken = "",
                SuccessOnTimeout = false,
            };
            // Make the request
            ListActiveBreakpointsResponse response = controller2Client.ListActiveBreakpoints(request);
        }
    }
    // [END clouddebugger_v2_generated_Controller2_ListActiveBreakpoints_sync]
}