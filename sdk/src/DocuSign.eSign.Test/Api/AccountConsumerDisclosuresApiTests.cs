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
    ///  Class for testing AccountConsumerDisclosuresApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountConsumerDisclosuresApiTests
    {
        private AccountConsumerDisclosuresApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountConsumerDisclosuresApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountConsumerDisclosuresApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountConsumerDisclosuresApi
            //Assert.IsInstanceOfType(typeof(AccountConsumerDisclosuresApi), instance, "instance is a AccountConsumerDisclosuresApi");
        }

        
        /// <summary>
        /// Test ConsumerDisclosureGetConsumerDisclosure
        /// </summary>
        [Test]
        public void ConsumerDisclosureGetConsumerDisclosureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string langCode = null;
            //var response = instance.ConsumerDisclosureGetConsumerDisclosure(accountId, langCode);
            //Assert.IsInstanceOf<AccountConsumerDisclosures> (response, "response is AccountConsumerDisclosures");
        }
        
        /// <summary>
        /// Test ConsumerDisclosureGetConsumerDisclosureLangCode
        /// </summary>
        [Test]
        public void ConsumerDisclosureGetConsumerDisclosureLangCodeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string langCode = null;
            //var response = instance.ConsumerDisclosureGetConsumerDisclosureLangCode(accountId, langCode);
            //Assert.IsInstanceOf<AccountConsumerDisclosures> (response, "response is AccountConsumerDisclosures");
        }
        
        /// <summary>
        /// Test ConsumerDisclosurePutConsumerDisclosure
        /// </summary>
        [Test]
        public void ConsumerDisclosurePutConsumerDisclosureTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string langCode = null;
            //string includeMetadata = null;
            //EnvelopeConsumerDisclosures envelopeConsumerDisclosures = null;
            //var response = instance.ConsumerDisclosurePutConsumerDisclosure(accountId, langCode, includeMetadata, envelopeConsumerDisclosures);
            //Assert.IsInstanceOf<EnvelopeConsumerDisclosures> (response, "response is EnvelopeConsumerDisclosures");
        }
        
    }

}
