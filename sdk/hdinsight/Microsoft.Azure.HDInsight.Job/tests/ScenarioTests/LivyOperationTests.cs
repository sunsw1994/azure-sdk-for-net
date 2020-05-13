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

                SparkBatchJobRequest createRequest = new SparkBatchJobRequest
                {
                    File = "wasbs:///example/jars/spark-examples.jar",
                    ClassName = "org.apache.spark.examples.SparkPi",
                    Arguments = new List<string>(){"10"}
                };
                var createResponse = client.SparkBatch.Create(createRequest);
                Assert.NotNull(createResponse);
                Assert.Equal("starting", createResponse.State);

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
                SparkBatchJobRequest createRequest = new SparkBatchJobRequest
                {
                    File = "wasbs:///example/jars/spark-examples.jar",
                    ClassName = "org.apache.spark.examples.SparkPi",
                    Arguments = new List<string>() { "10" }
                };
                var createResponse = client.SparkBatch.Create(createRequest);
                Assert.NotNull(createResponse);
                Assert.Equal("starting", createResponse.State);

                var response = client.SparkBatch.Get((int)createResponse.Id);
                Assert.NotNull(response);
            }
        }

        [Fact]
        public void DeleteJobsSparkBatch()
        {
            using (var context = MockContext.Start(this.GetType()))
            using (var client = this.CommonData.GetHDInsightLivyJobManagementClient(context))
            {
                SparkBatchJobRequest createRequest = new SparkBatchJobRequest
                {
                    File = "wasbs:///example/jars/spark-examples.jar",
                    ClassName = "org.apache.spark.examples.SparkPi",
                    Arguments = new List<string>() { "10" }
                };
                var createResponse = client.SparkBatch.Create(createRequest);
                Assert.NotNull(createResponse);
                Assert.Equal("starting", createResponse.State);

                var originalResponse = client.SparkBatch.List();
                Assert.NotNull(originalResponse);

                client.SparkBatch.Delete((int)createResponse.Id);

                var checkResponse = client.SparkBatch.List();
                Assert.NotNull(checkResponse);
                Assert.Equal(originalResponse.Total-1, checkResponse.Total);
            }
        }

        [Fact]
        public void ListJobsSparkSession()
        {
            using (var context = MockContext.Start(this.GetType()))
            using (var client = this.CommonData.GetHDInsightLivyJobManagementClient(context))
            {
                var originalResponse = client.SparkSession.List();
                Assert.NotNull(originalResponse);

                SparkSessionJobRequest createRequest = new SparkSessionJobRequest
                {
                    Kind = "spark"
                };

                var createResponse = client.SparkSession.Create(createRequest);
                Assert.NotNull(createResponse);
                Assert.Equal("starting", createResponse.State);
                TestUtilities.Wait(10000);

                var checkResponse = client.SparkSession.List();
                Assert.NotNull(checkResponse);
                Assert.Equal(originalResponse.Total + 1, checkResponse.Total);

                var specifySizeResponse = client.SparkSession.List(1, 0);
                Assert.NotNull(checkResponse);
                Assert.Equal(1, specifySizeResponse.FromProperty);
                Assert.Equal(0, specifySizeResponse.Sessions.Count);

                client.SparkSession.Delete((int)createResponse.Id);
            }
        }

        [Fact]
        public void GetJobsSparkSession()
        {
            using (var context = MockContext.Start(this.GetType()))
            using (var client = this.CommonData.GetHDInsightLivyJobManagementClient(context))
            {
                SparkSessionJobRequest createRequest = new SparkSessionJobRequest
                {
                    Kind = "spark"
                };
                var createResponse = client.SparkSession.Create(createRequest);
                Assert.NotNull(createResponse);
                Assert.Equal("starting", createResponse.State);
                TestUtilities.Wait(10000);

                var response = client.SparkSession.Get((int)createResponse.Id);
                Assert.NotNull(response);

                client.SparkSession.Delete((int)createResponse.Id);
            }
        }

        [Fact]
        public void DeleteJobsSparkSession()
        {
            using (var context = MockContext.Start(this.GetType()))
            using (var client = this.CommonData.GetHDInsightLivyJobManagementClient(context))
            {
                //create session
                SparkSessionJobRequest createRequest = new SparkSessionJobRequest
                {
                    Kind = "spark"
                };
                var createResponse = client.SparkSession.Create(createRequest);
                Assert.NotNull(createResponse);
                Assert.Equal("starting", createResponse.State);

                var originalResponse = client.SparkSession.List();
                Assert.NotNull(originalResponse);

                //delete session
                client.SparkSession.Delete((int)createResponse.Id);

                var checkResponse = client.SparkSession.List();
                Assert.NotNull(checkResponse);
                Assert.Equal(originalResponse.Total - 1, checkResponse.Total);
            }
        }

        [Fact]
        public void OperationJobsSparkSessionStatments()
        {
            using (var context = MockContext.Start(this.GetType()))
            using (var client = this.CommonData.GetHDInsightLivyJobManagementClient(context))
            {
                //create session
                SparkSessionJobRequest createRequest = new SparkSessionJobRequest
                {
                    Kind = "spark"
                };

                var createResponse = client.SparkSession.Create(createRequest);
                Assert.NotNull(createResponse);
                Assert.Equal("starting", createResponse.State);
                TestUtilities.Wait(10000);

                var originalResponse = client.SparkSession.ListStatements((int)createResponse.Id);
                Assert.NotNull(originalResponse);

                //create statements
                SparkStatementRequest statementRequest = new SparkStatementRequest
                {
                    Code = "1+1"
                };

                var statementResponse = client.SparkSession.CreateStatement((int)createResponse.Id, statementRequest);
                Assert.NotNull(statementResponse);
                Assert.Equal("waiting", statementResponse.State);

                var checkcreateResponse = client.SparkSession.ListStatements((int)createResponse.Id);
                Assert.NotNull(checkcreateResponse);
                Assert.Equal(originalResponse.Statements.Count + 1, checkcreateResponse.Statements.Count);
                TestUtilities.Wait(10000);

                //delete statements
                var cancelResponse = client.SparkSession.DeleteStatement((int)createResponse.Id, (int)statementResponse.Id);
                Assert.Equal("canceled", cancelResponse.CancelMessage);
                
                //delete session
                client.SparkSession.Delete((int)createResponse.Id);
            }
        }
    }
}
