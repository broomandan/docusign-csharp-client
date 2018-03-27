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
    ///  Class for testing EnvelopeRecipientsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class EnvelopeRecipientsApiTests
    {
        private EnvelopeRecipientsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new EnvelopeRecipientsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of EnvelopeRecipientsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' EnvelopeRecipientsApi
            //Assert.IsInstanceOfType(typeof(EnvelopeRecipientsApi), instance, "instance is a EnvelopeRecipientsApi");
        }

        
        /// <summary>
        /// Test RecipientsDeleteRecipient
        /// </summary>
        [Test]
        public void RecipientsDeleteRecipientTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string envelopeId = null;
            //string recipientId = null;
            //var response = instance.RecipientsDeleteRecipient(accountId, envelopeId, recipientId);
            //Assert.IsInstanceOf<EnvelopeRecipients> (response, "response is EnvelopeRecipients");
        }
        
        /// <summary>
        /// Test RecipientsDeleteRecipients
        /// </summary>
        [Test]
        public void RecipientsDeleteRecipientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string envelopeId = null;
            //EnvelopeRecipients envelopeRecipients = null;
            //var response = instance.RecipientsDeleteRecipients(accountId, envelopeId, envelopeRecipients);
            //Assert.IsInstanceOf<EnvelopeRecipients> (response, "response is EnvelopeRecipients");
        }
        
        /// <summary>
        /// Test RecipientsGetRecipients
        /// </summary>
        [Test]
        public void RecipientsGetRecipientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string envelopeId = null;
            //string includeAnchorTabLocations = null;
            //string includeExtended = null;
            //string includeMetadata = null;
            //string includeTabs = null;
            //var response = instance.RecipientsGetRecipients(accountId, envelopeId, includeAnchorTabLocations, includeExtended, includeMetadata, includeTabs);
            //Assert.IsInstanceOf<EnvelopeRecipients> (response, "response is EnvelopeRecipients");
        }
        
        /// <summary>
        /// Test RecipientsPostRecipients
        /// </summary>
        [Test]
        public void RecipientsPostRecipientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string envelopeId = null;
            //string resendEnvelope = null;
            //EnvelopeRecipients envelopeRecipients = null;
            //var response = instance.RecipientsPostRecipients(accountId, envelopeId, resendEnvelope, envelopeRecipients);
            //Assert.IsInstanceOf<EnvelopeRecipients> (response, "response is EnvelopeRecipients");
        }
        
        /// <summary>
        /// Test RecipientsPutRecipients
        /// </summary>
        [Test]
        public void RecipientsPutRecipientsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string envelopeId = null;
            //string resendEnvelope = null;
            //EnvelopeRecipients envelopeRecipients = null;
            //var response = instance.RecipientsPutRecipients(accountId, envelopeId, resendEnvelope, envelopeRecipients);
            //Assert.IsInstanceOf<RecipientsUpdateSummary> (response, "response is RecipientsUpdateSummary");
        }
        
    }

}
