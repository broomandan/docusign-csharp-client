/* 
 * DocuSign REST API
 *
 * The DocuSign REST API provides you with a powerful, convenient, and simple Web services API for interacting with DocuSign.
 *
 * OpenAPI spec version: v2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using DocuSign.eSign.Api;
using NUnit.Framework;

namespace DocuSign.eSign.Test.Api
{
    /// <summary>
    ///  Class for testing WorkspacesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class WorkspacesApiTests
    {
        private WorkspacesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new WorkspacesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of WorkspacesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' WorkspacesApi
            //Assert.IsInstanceOfType(typeof(WorkspacesApi), instance, "instance is a WorkspacesApi");
        }

        
        /// <summary>
        /// Test WorkspaceDeleteWorkspace
        /// </summary>
        [Test]
        public void WorkspaceDeleteWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string workspaceId = null;
            //var response = instance.WorkspaceDeleteWorkspace(accountId, workspaceId);
            //Assert.IsInstanceOf<Workspaces> (response, "response is Workspaces");
        }
        
        /// <summary>
        /// Test WorkspaceGetWorkspace
        /// </summary>
        [Test]
        public void WorkspaceGetWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string workspaceId = null;
            //var response = instance.WorkspaceGetWorkspace(accountId, workspaceId);
            //Assert.IsInstanceOf<Workspaces> (response, "response is Workspaces");
        }
        
        /// <summary>
        /// Test WorkspaceGetWorkspaces
        /// </summary>
        [Test]
        public void WorkspaceGetWorkspacesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.WorkspaceGetWorkspaces(accountId);
            //Assert.IsInstanceOf<WorkspaceList> (response, "response is WorkspaceList");
        }
        
        /// <summary>
        /// Test WorkspacePostWorkspace
        /// </summary>
        [Test]
        public void WorkspacePostWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //Workspaces workspaces = null;
            //var response = instance.WorkspacePostWorkspace(accountId, workspaces);
            //Assert.IsInstanceOf<Workspaces> (response, "response is Workspaces");
        }
        
        /// <summary>
        /// Test WorkspacePutWorkspace
        /// </summary>
        [Test]
        public void WorkspacePutWorkspaceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string workspaceId = null;
            //Workspaces workspaces = null;
            //var response = instance.WorkspacePutWorkspace(accountId, workspaceId, workspaces);
            //Assert.IsInstanceOf<Workspaces> (response, "response is Workspaces");
        }
        
    }

}
