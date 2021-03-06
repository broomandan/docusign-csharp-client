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
    ///  Class for testing BillingPlansApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BillingPlansApiTests
    {
        private BillingPlansApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BillingPlansApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BillingPlansApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BillingPlansApi
            //Assert.IsInstanceOfType(typeof(BillingPlansApi), instance, "instance is a BillingPlansApi");
        }

        
        /// <summary>
        /// Test BillingPlanGetBillingPlan
        /// </summary>
        [Test]
        public void BillingPlanGetBillingPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string includeCreditCardInformation = null;
            //string includeMetadata = null;
            //string includeSuccessorPlans = null;
            //var response = instance.BillingPlanGetBillingPlan(accountId, includeCreditCardInformation, includeMetadata, includeSuccessorPlans);
            //Assert.IsInstanceOf<BillingPlans> (response, "response is BillingPlans");
        }
        
        /// <summary>
        /// Test BillingPlanGetCreditCardInfo
        /// </summary>
        [Test]
        public void BillingPlanGetCreditCardInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //var response = instance.BillingPlanGetCreditCardInfo(accountId);
            //Assert.IsInstanceOf<CreditCardInformation> (response, "response is CreditCardInformation");
        }
        
        /// <summary>
        /// Test BillingPlanPutBillingPlan
        /// </summary>
        [Test]
        public void BillingPlanPutBillingPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string previewBillingPlan = null;
            //BillingPlanInformation billingPlanInformation = null;
            //var response = instance.BillingPlanPutBillingPlan(accountId, previewBillingPlan, billingPlanInformation);
            //Assert.IsInstanceOf<BillingPlanUpdateResponse> (response, "response is BillingPlanUpdateResponse");
        }
        
        /// <summary>
        /// Test BillingPlansGetBillingPlan
        /// </summary>
        [Test]
        public void BillingPlansGetBillingPlanTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string billingPlanId = null;
            //var response = instance.BillingPlansGetBillingPlan(billingPlanId);
            //Assert.IsInstanceOf<BillingPlanResponse> (response, "response is BillingPlanResponse");
        }
        
        /// <summary>
        /// Test BillingPlansGetBillingPlans
        /// </summary>
        [Test]
        public void BillingPlansGetBillingPlansTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.BillingPlansGetBillingPlans();
            //Assert.IsInstanceOf<BillingPlansResponse> (response, "response is BillingPlansResponse");
        }
        
        /// <summary>
        /// Test PurchasedEnvelopesPutPurchasedEnvelopes
        /// </summary>
        [Test]
        public void PurchasedEnvelopesPutPurchasedEnvelopesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //PurchasedEnvelopesInformation purchasedEnvelopesInformation = null;
            //instance.PurchasedEnvelopesPutPurchasedEnvelopes(accountId, purchasedEnvelopesInformation);
            
        }
        
    }

}
