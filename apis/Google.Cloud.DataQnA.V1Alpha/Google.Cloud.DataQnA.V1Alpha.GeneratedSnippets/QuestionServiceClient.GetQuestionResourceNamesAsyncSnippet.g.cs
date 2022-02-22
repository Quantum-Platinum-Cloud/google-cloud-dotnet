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

namespace Google.Cloud.DataQnA.V1Alpha.Snippets
{
    // [START dataqna_v1alpha_generated_QuestionService_GetQuestion_async_flattened_resourceNames]
    using Google.Cloud.DataQnA.V1Alpha;
    using System.Threading.Tasks;

    public sealed partial class GeneratedQuestionServiceClientSnippets
    {
        /// <summary>Snippet for GetQuestionAsync</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public async Task GetQuestionResourceNamesAsync()
        {
            // Create client
            QuestionServiceClient questionServiceClient = await QuestionServiceClient.CreateAsync();
            // Initialize request argument(s)
            QuestionName name = QuestionName.FromProjectLocationQuestion("[PROJECT]", "[LOCATION]", "[QUESTION]");
            // Make the request
            Question response = await questionServiceClient.GetQuestionAsync(name);
        }
    }
    // [END dataqna_v1alpha_generated_QuestionService_GetQuestion_async_flattened_resourceNames]
}