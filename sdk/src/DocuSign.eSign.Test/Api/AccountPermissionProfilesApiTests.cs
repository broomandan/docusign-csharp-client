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
    ///  Class for testing AccountPermissionProfilesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountPermissionProfilesApiTests
    {
        private AccountPermissionProfilesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountPermissionProfilesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountPermissionProfilesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountPermissionProfilesApi
            //Assert.IsInstanceOfType(typeof(AccountPermissionProfilesApi), instance, "instance is a AccountPermissionProfilesApi");
        }

        
        /// <summary>
        /// Test PermissionProfilesDeletePermissionProfiles
        /// </summary>
        [Test]
        public void PermissionProfilesDeletePermissionProfilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string permissionProfileId = null;
            //instance.PermissionProfilesDeletePermissionProfiles(accountId, permissionProfileId);
            
        }
        
        /// <summary>
        /// Test PermissionProfilesGetPermissionProfile
        /// </summary>
        [Test]
        public void PermissionProfilesGetPermissionProfileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string permissionProfileId = null;
            //string include = null;
            //var response = instance.PermissionProfilesGetPermissionProfile(accountId, permissionProfileId, include);
            //Assert.IsInstanceOf<AccountPermissionProfiles> (response, "response is AccountPermissionProfiles");
        }
        
        /// <summary>
        /// Test PermissionProfilesGetPermissionProfiles
        /// </summary>
        [Test]
        public void PermissionProfilesGetPermissionProfilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string include = null;
            //var response = instance.PermissionProfilesGetPermissionProfiles(accountId, include);
            //Assert.IsInstanceOf<PermissionProfileInformation> (response, "response is PermissionProfileInformation");
        }
        
        /// <summary>
        /// Test PermissionProfilesPostPermissionProfiles
        /// </summary>
        [Test]
        public void PermissionProfilesPostPermissionProfilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string include = null;
            //AccountPermissionProfiles accountPermissionProfiles = null;
            //var response = instance.PermissionProfilesPostPermissionProfiles(accountId, include, accountPermissionProfiles);
            //Assert.IsInstanceOf<AccountPermissionProfiles> (response, "response is AccountPermissionProfiles");
        }
        
        /// <summary>
        /// Test PermissionProfilesPutPermissionProfiles
        /// </summary>
        [Test]
        public void PermissionProfilesPutPermissionProfilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string permissionProfileId = null;
            //string include = null;
            //AccountPermissionProfiles accountPermissionProfiles = null;
            //var response = instance.PermissionProfilesPutPermissionProfiles(accountId, permissionProfileId, include, accountPermissionProfiles);
            //Assert.IsInstanceOf<AccountPermissionProfiles> (response, "response is AccountPermissionProfiles");
        }
        
    }

}
