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
    ///  Class for testing TemplateDocumentVisibilityApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TemplateDocumentVisibilityApiTests
    {
        private TemplateDocumentVisibilityApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TemplateDocumentVisibilityApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TemplateDocumentVisibilityApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TemplateDocumentVisibilityApi
            //Assert.IsInstanceOfType(typeof(TemplateDocumentVisibilityApi), instance, "instance is a TemplateDocumentVisibilityApi");
        }

        
        /// <summary>
        /// Test RecipientsGetTemplateRecipientDocumentVisibility
        /// </summary>
        [Test]
        public void RecipientsGetTemplateRecipientDocumentVisibilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string recipientId = null;
            //string templateId = null;
            //var response = instance.RecipientsGetTemplateRecipientDocumentVisibility(accountId, recipientId, templateId);
            //Assert.IsInstanceOf<EnvelopeDocumentVisibility> (response, "response is EnvelopeDocumentVisibility");
        }
        
        /// <summary>
        /// Test RecipientsPutTemplateRecipientDocumentVisibility
        /// </summary>
        [Test]
        public void RecipientsPutTemplateRecipientDocumentVisibilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string recipientId = null;
            //string templateId = null;
            //TemplateDocumentVisibility templateDocumentVisibility = null;
            //var response = instance.RecipientsPutTemplateRecipientDocumentVisibility(accountId, recipientId, templateId, templateDocumentVisibility);
            //Assert.IsInstanceOf<TemplateDocumentVisibility> (response, "response is TemplateDocumentVisibility");
        }
        
        /// <summary>
        /// Test RecipientsPutTemplateRecipientsDocumentVisibility
        /// </summary>
        [Test]
        public void RecipientsPutTemplateRecipientsDocumentVisibilityTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string templateId = null;
            //TemplateDocumentVisibility templateDocumentVisibility = null;
            //var response = instance.RecipientsPutTemplateRecipientsDocumentVisibility(accountId, templateId, templateDocumentVisibility);
            //Assert.IsInstanceOf<TemplateDocumentVisibility> (response, "response is TemplateDocumentVisibility");
        }
        
    }

}