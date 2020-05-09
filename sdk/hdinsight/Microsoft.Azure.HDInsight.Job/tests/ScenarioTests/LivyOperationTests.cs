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
                var originalResponse = client.SparkBatch.List();
                Assert.NotNull(originalResponse);

                LivyBatchRequest creatRequest = new LivyBatchRequest
                {
                    File = "wasbs:///example/jars/spark-examples.jar",
                    ClassName = "org.apache.spark.examples.SparkPi",
                    Args = new List<string>(){"10"}
                };
                var creatResponse = client.SparkBatch.Create("admin", creatRequest);
                Assert.NotNull(creatResponse);
                Assert.Equal("starting", creatResponse.State);

                var checkResponse = client.SparkBatch.List();
                Assert.NotNull(checkResponse);
                Assert.Equal(originalResponse.Total+1, checkResponse.Total);

                var specifySizeResponse = originalResponse = client.SparkBatch.List(1,0);
                Assert.NotNull(checkResponse);
                Assert.Equal(1, specifySizeResponse.FromProperty);
                Assert.Equal(0, specifySizeResponse.Sessions.Count);
            }
        }

        [Fact]
        public void GetJobsSparkBatch()
        {
            using (var context = MockContext.Start(this.GetType()))
            using (var client = this.CommonData.GetHDInsightLivyJobManagementClient(context))
            {
                LivyBatchRequest creatRequest = new LivyBatchRequest
                {
                    File = "wasbs:///example/jars/spark-examples.jar",
                    ClassName = "org.apache.spark.examples.SparkPi",
                    Args = new List<string>() { "10" }
                };
                var creatResponse = client.SparkBatch.Create("admin", creatRequest);
                Assert.NotNull(creatResponse);
                Assert.Equal("starting", creatResponse.State);

                var response = client.SparkBatch.Get((int)creatResponse.Id);
                Assert.NotNull(response);
            }
        }

        [Fact]
        public void DeleteJobsSparkBatch()
        {
            using (var context = MockContext.Start(this.GetType()))
            using (var client = this.CommonData.GetHDInsightLivyJobManagementClient(context))
            {
                LivyBatchRequest creatRequest = new LivyBatchRequest
                {
                    File = "wasbs:///example/jars/spark-examples.jar",
                    ClassName = "org.apache.spark.examples.SparkPi",
                    Args = new List<string>() { "10" }
                };
                var creatResponse = client.SparkBatch.Create("admin", creatRequest);
                Assert.NotNull(creatResponse);
                Assert.Equal("starting", creatResponse.State);

                var originalResponse = client.SparkBatch.List();
                Assert.NotNull(originalResponse);

                client.SparkBatch.Delete("admin",(int)creatResponse.Id);

                var checkResponse = client.SparkBatch.List();
                Assert.NotNull(checkResponse);
                Assert.Equal(originalResponse.Total-1, checkResponse.Total);
            }
        }
    }
}
