//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace Microsoft.Azure.HDInsight.Job.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.IO;
    using Microsoft.Azure.Test.HttpRecorder;
    using Xunit;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using Microsoft.Azure.HDInsight.Job;
    using Microsoft.Azure.HDInsight.Job.Models;
    using System.Linq;

    public class LivyOperationTests : TestBase, IClassFixture<CommonTestsFixture> 
    {
        public CommonTestsFixture CommonData { get; set; }

        public LivyOperationTests(CommonTestsFixture commonData)
        {
            this.CommonData = commonData;
        }

        [Fact]
        public void ListJobsSparkBatch()
        {
            using (var context = MockContext.Start(this.GetType()))
            using (var client = this.CommonData.GetHDInsightLivyJobManagementClient(context))
            {
                var response = client.SparkBatch.List();
                Assert.NotNull(response);
                int? originalJobCount = response.Total;
                Assert.Equal(0, originalJobCount);
            }
        }
    }
}
