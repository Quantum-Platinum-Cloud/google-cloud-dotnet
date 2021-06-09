﻿// Copyright 2021 Google LLC
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

using Xunit;

namespace Google.Cloud.ApigeeConnect.V1.Tests
{
    // No tests are currently generated for ConnectionServiceClient and TetherClient as all the methods
    // are paginated or streaming. This causes a warning when building, so this placeholder test
    // just effectively suppresses this warning. If we ever generate actual tests, this
    // class can be removed.
    public class PlaceholderTest
    {
        [Fact]
        public void Placeholder() =>
            Assert.Equal(5, 5);
    }
}