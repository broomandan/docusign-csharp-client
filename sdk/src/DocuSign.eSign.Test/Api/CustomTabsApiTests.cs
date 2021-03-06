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
    ///  Class for testing CustomTabsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class CustomTabsApiTests
    {
        private CustomTabsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new CustomTabsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CustomTabsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' CustomTabsApi
            //Assert.IsInstanceOfType(typeof(CustomTabsApi), instance, "instance is a CustomTabsApi");
        }

        
        /// <summary>
        /// Test TabDeleteCustomTab
        /// </summary>
        [Test]
        public void TabDeleteCustomTabTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string customTabId = null;
            //instance.TabDeleteCustomTab(accountId, customTabId);
            
        }
        
        /// <summary>
        /// Test TabGetCustomTab
        /// </summary>
        [Test]
        public void TabGetCustomTabTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string customTabId = null;
            //var response = instance.TabGetCustomTab(accountId, customTabId);
            //Assert.IsInstanceOf<CustomTabs> (response, "response is CustomTabs");
        }
        
        /// <summary>
        /// Test TabPutCustomTab
        /// </summary>
        [Test]
        public void TabPutCustomTabTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string customTabId = null;
            //CustomTabs customTabs = null;
            //var response = instance.TabPutCustomTab(accountId, customTabId, customTabs);
            //Assert.IsInstanceOf<CustomTabs> (response, "response is CustomTabs");
        }
        
        /// <summary>
        /// Test TabsGetTabDefinitions
        /// </summary>
        [Test]
        public void TabsGetTabDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string customTabOnly = null;
            //var response = instance.TabsGetTabDefinitions(accountId, customTabOnly);
            //Assert.IsInstanceOf<TabMetadataList> (response, "response is TabMetadataList");
        }
        
        /// <summary>
        /// Test TabsPostTabDefinitions
        /// </summary>
        [Test]
        public void TabsPostTabDefinitionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //CustomTabs customTabs = null;
            //var response = instance.TabsPostTabDefinitions(accountId, customTabs);
            //Assert.IsInstanceOf<CustomTabs> (response, "response is CustomTabs");
        }
        
    }

}
