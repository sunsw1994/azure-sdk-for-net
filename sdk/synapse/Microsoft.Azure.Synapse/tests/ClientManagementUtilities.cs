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
    using Microsoft.Azure.Synapse;
    using Microsoft.Rest;
    using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
    using System;
    using System.Globalization;
    using Microsoft.IdentityModel.Clients.ActiveDirectory;
    using System.Threading.Tasks;
    using Microsoft.Azure.Test.HttpRecorder;
    using System.Net.Http;


    public static class ClientManagementUtilities
    {
        /// <summary>
        /// Default constructor for management clients, using the TestSupport Infrastructure
        /// </summary>
        /// <param name="testBase">the test class</param>
        /// <returns>A management client, created from the current context (environment variables)</returns>
        public static TServiceClient GetServiceClient<TServiceClient>(this TestBase testBase, MockContext context) where TServiceClient : class, IDisposable
        {
            return context.GetServiceClient<TServiceClient>();
        }

        public static SynapseClient GetSynapseClient(this CommonTestsFixture testFixture, MockContext context)
        {
            string tenantId = GetTenantId();
            var accessToken = GetAccessToken("https://login.windows.net/" + tenantId, "https://dev.azuresynapse.net", "");
            var credential = new TokenCredentials(accessToken.Result);
            TestEnvironment currentEnvironment = TestEnvironmentFactory.GetTestEnvironment();
            var client = context.GetServiceClientWithCredentials<SynapseClient>(currentEnvironment,credential,true);
            client.Endpoint = "https://" + testFixture.SynapseWorkspaceUrl;
            return client;
        }

        public static async Task<string> GetAccessToken(string authority, string resource, string scope)
        {
            string accessToken = null;
            if (IsRecordMode())
            {
                var context = new AuthenticationContext(authority, TokenCache.DefaultShared);
                string authClientId = GetServicePrincipalId();
                string authSecret = GetServicePrincipalSecret();
                var clientCredential = new ClientCredential(authClientId, authSecret);
                var result = await context.AcquireTokenAsync(resource, clientCredential).ConfigureAwait(false);
                accessToken = result.AccessToken;
            }
            else if (IsPlaybackMode())
            {
                accessToken = "fake-token";
            }

            return accessToken;
        }

        public static bool IsRecordMode()
        {
            return HttpMockServer.Mode == HttpRecorderMode.Record;
        }

        public static bool IsPlaybackMode()
        {
            return HttpMockServer.Mode == HttpRecorderMode.Playback;
        }

        public static string GetServicePrincipalSecret()
        {
            string servicePrincipalSecret = null;
            if (IsRecordMode())
            {
                var environment = TestEnvironmentFactory.GetTestEnvironment();
                servicePrincipalSecret = environment.ConnectionString.KeyValuePairs.GetValueUsingCaseInsensitiveKey(ConnectionStringKeys.ServicePrincipalSecretKey);
            }
            else if (IsPlaybackMode())
            {
                servicePrincipalSecret = "xyz";
            }
            return servicePrincipalSecret;
        }

        public static string GetTenantId()
        {
            string tenantId = null;
            if (IsRecordMode())
            {
                var environment = TestEnvironmentFactory.GetTestEnvironment();
                HttpMockServer.Variables[ConnectionStringKeys.AADTenantKey] = environment.ConnectionString.KeyValuePairs.GetValueUsingCaseInsensitiveKey(ConnectionStringKeys.AADTenantKey);
                tenantId = HttpMockServer.Variables[ConnectionStringKeys.AADTenantKey];
            }
            else if (IsPlaybackMode())
            {
                tenantId = HttpMockServer.Variables[ConnectionStringKeys.AADTenantKey];
            }
            return tenantId;
        }

        /// <summary>
        /// Get service principal object id from test configurations(Environment variables).
        /// </summary>
        /// <returns></returns>
        public static string GetServicePrincipalObjectId()
        {
            string servicePrincipalObjectId = null;
            if (IsRecordMode())
            {
                var environment = TestEnvironmentFactory.GetTestEnvironment();
                HttpMockServer.Variables[ConnectionStringKeys.AADClientIdKey] = environment.ConnectionString.KeyValuePairs.GetValueUsingCaseInsensitiveKey(ConnectionStringKeys.AADClientIdKey);
                servicePrincipalObjectId = HttpMockServer.Variables[ConnectionStringKeys.AADClientIdKey];
            }
            else if (IsPlaybackMode())
            {
                servicePrincipalObjectId = HttpMockServer.Variables[ConnectionStringKeys.AADClientIdKey];
            }
            return servicePrincipalObjectId;
        }

        public static string GetServicePrincipalId()
        {
            string servicePrincipalId = null;
            if (HttpMockServer.Mode == HttpRecorderMode.Record)
            {
                var environment = TestEnvironmentFactory.GetTestEnvironment();
                HttpMockServer.Variables[ConnectionStringKeys.ServicePrincipalKey] = environment.ConnectionString.KeyValuePairs.GetValueUsingCaseInsensitiveKey(ConnectionStringKeys.ServicePrincipalKey);
                servicePrincipalId = HttpMockServer.Variables[ConnectionStringKeys.ServicePrincipalKey];
            }
            else if (HttpMockServer.Mode == HttpRecorderMode.Playback)
            {
                servicePrincipalId = HttpMockServer.Variables[ConnectionStringKeys.ServicePrincipalKey];
            }
            return servicePrincipalId;
        }

        public static DelegatingHandler[] GetHandlers()
        {
            HttpMockServer server = HttpMockServer.CreateInstance();
            return new DelegatingHandler[] { server };
        }
    }
}