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

namespace Microsoft.Azure.Synapse.Tests
{
    using Microsoft.Azure.Test.HttpRecorder;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using System;

    public class CommonTestsFixture : TestBase, IDisposable
    {
        /// <summary>
        /// HDInsight cluster name
        /// </summary>
        public string SynapseWorkspaceName { get; set; }

        /// <summary>
        /// Gets or sets HDInsight cluster suffix.
        /// By default: azurehdinsight.net
        /// </summary>
        public string SynapseWorkspaceSuffix { get; set; }

        public string SynapseWorkspaceUrl
        {
            get
            {
                return $"{SynapseWorkspaceName}.{SynapseWorkspaceSuffix}";
            }
        }

        /// <summary>
        /// Gets or sets the helper for managing resources used during test process.
        /// </summary>
        //public HDInsightManagementHelper HDInsightManagementHelper { get; set; }

        /// <summary>
        /// Gets or sets the mock context.
        /// </summary>
        private MockContext context;

        /// <summary>
        /// Ctor.
        /// </summary>
        public CommonTestsFixture()
        {
            var context = MockContext.Start(this.GetType(), ".ctor");
            this.Initialize(context);
        }

        /// <summary>
        /// Initializes common data properties.
        /// </summary>
        public virtual void Initialize(MockContext contextToUse)
        {
            try
            {
                context = contextToUse;
                SynapseWorkspaceSuffix = "dev.azuresynapse.net";
                SynapseWorkspaceName = "shangweisynapseworkspace";
            }
            catch
            {
                Cleanup();
                throw;
            }
            finally
            {
                HttpMockServer.Flush();
            }
        }

        #region Dispose

        private void Cleanup()
        {
            if (HttpMockServer.Mode == HttpRecorderMode.Record)
            {
                HttpMockServer.Initialize(this.GetType(), ".cleanup");
            }
            if (context != null)
            {
                context.Dispose();
                context = null;
            }
        }

        public void Dispose()
        {
            Cleanup();
        }

        #endregion
    }
}
