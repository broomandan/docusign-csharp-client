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
    ///  Class for testing GroupUsersApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class GroupUsersApiTests
    {
        private GroupUsersApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GroupUsersApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of GroupUsersApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' GroupUsersApi
            //Assert.IsInstanceOfType(typeof(GroupUsersApi), instance, "instance is a GroupUsersApi");
        }

        
        /// <summary>
        /// Test GroupsDeleteGroupUsers
        /// </summary>
        [Test]
        public void GroupsDeleteGroupUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string groupId = null;
            //UserInfoList userInfoList = null;
            //var response = instance.GroupsDeleteGroupUsers(accountId, groupId, userInfoList);
            //Assert.IsInstanceOf<GroupUsers> (response, "response is GroupUsers");
        }
        
        /// <summary>
        /// Test GroupsGetGroupUsers
        /// </summary>
        [Test]
        public void GroupsGetGroupUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string groupId = null;
            //string count = null;
            //string startPosition = null;
            //var response = instance.GroupsGetGroupUsers(accountId, groupId, count, startPosition);
            //Assert.IsInstanceOf<GroupUsers> (response, "response is GroupUsers");
        }
        
        /// <summary>
        /// Test GroupsPutGroupUsers
        /// </summary>
        [Test]
        public void GroupsPutGroupUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string groupId = null;
            //UserInfoList userInfoList = null;
            //var response = instance.GroupsPutGroupUsers(accountId, groupId, userInfoList);
            //Assert.IsInstanceOf<GroupUsers> (response, "response is GroupUsers");
        }
        
    }

}
