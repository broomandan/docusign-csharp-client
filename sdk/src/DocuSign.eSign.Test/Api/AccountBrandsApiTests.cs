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
    ///  Class for testing AccountBrandsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class AccountBrandsApiTests
    {
        private AccountBrandsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AccountBrandsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of AccountBrandsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' AccountBrandsApi
            //Assert.IsInstanceOfType(typeof(AccountBrandsApi), instance, "instance is a AccountBrandsApi");
        }

        
        /// <summary>
        /// Test BrandDeleteBrand
        /// </summary>
        [Test]
        public void BrandDeleteBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //instance.BrandDeleteBrand(accountId, brandId);
            
        }
        
        /// <summary>
        /// Test BrandExportGetBrandExportFile
        /// </summary>
        [Test]
        public void BrandExportGetBrandExportFileTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //instance.BrandExportGetBrandExportFile(accountId, brandId);
            
        }
        
        /// <summary>
        /// Test BrandGetBrand
        /// </summary>
        [Test]
        public void BrandGetBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string includeExternalReferences = null;
            //string includeLogos = null;
            //var response = instance.BrandGetBrand(accountId, brandId, includeExternalReferences, includeLogos);
            //Assert.IsInstanceOf<Brand> (response, "response is Brand");
        }
        
        /// <summary>
        /// Test BrandLogoDeleteBrandLogo
        /// </summary>
        [Test]
        public void BrandLogoDeleteBrandLogoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string logoType = null;
            //instance.BrandLogoDeleteBrandLogo(accountId, brandId, logoType);
            
        }
        
        /// <summary>
        /// Test BrandLogoGetBrandLogo
        /// </summary>
        [Test]
        public void BrandLogoGetBrandLogoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string logoType = null;
            //instance.BrandLogoGetBrandLogo(accountId, brandId, logoType);
            
        }
        
        /// <summary>
        /// Test BrandLogoPutBrandLogo
        /// </summary>
        [Test]
        public void BrandLogoPutBrandLogoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string logoType = null;
            //instance.BrandLogoPutBrandLogo(accountId, brandId, logoType);
            
        }
        
        /// <summary>
        /// Test BrandPutBrand
        /// </summary>
        [Test]
        public void BrandPutBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //Brand brand = null;
            //var response = instance.BrandPutBrand(accountId, brandId, brand);
            //Assert.IsInstanceOf<Brand> (response, "response is Brand");
        }
        
        /// <summary>
        /// Test BrandResourcesGetBrandResources
        /// </summary>
        [Test]
        public void BrandResourcesGetBrandResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string resourceContentType = null;
            //string langcode = null;
            //string returnMaster = null;
            //instance.BrandResourcesGetBrandResources(accountId, brandId, resourceContentType, langcode, returnMaster);
            
        }
        
        /// <summary>
        /// Test BrandResourcesGetBrandResourcesList
        /// </summary>
        [Test]
        public void BrandResourcesGetBrandResourcesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //var response = instance.BrandResourcesGetBrandResourcesList(accountId, brandId);
            //Assert.IsInstanceOf<BrandResourcesList> (response, "response is BrandResourcesList");
        }
        
        /// <summary>
        /// Test BrandResourcesPutBrandResources
        /// </summary>
        [Test]
        public void BrandResourcesPutBrandResourcesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string brandId = null;
            //string resourceContentType = null;
            //var response = instance.BrandResourcesPutBrandResources(accountId, brandId, resourceContentType);
            //Assert.IsInstanceOf<BrandResources> (response, "response is BrandResources");
        }
        
        /// <summary>
        /// Test BrandsDeleteBrands
        /// </summary>
        [Test]
        public void BrandsDeleteBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //BrandsRequest brandsRequest = null;
            //var response = instance.BrandsDeleteBrands(accountId, brandsRequest);
            //Assert.IsInstanceOf<AccountBrands> (response, "response is AccountBrands");
        }
        
        /// <summary>
        /// Test BrandsGetBrands
        /// </summary>
        [Test]
        public void BrandsGetBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //string excludeDistributorBrand = null;
            //string includeLogos = null;
            //var response = instance.BrandsGetBrands(accountId, excludeDistributorBrand, includeLogos);
            //Assert.IsInstanceOf<AccountBrands> (response, "response is AccountBrands");
        }
        
        /// <summary>
        /// Test BrandsPostBrands
        /// </summary>
        [Test]
        public void BrandsPostBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accountId = null;
            //Brand brand = null;
            //var response = instance.BrandsPostBrands(accountId, brand);
            //Assert.IsInstanceOf<AccountBrands> (response, "response is AccountBrands");
        }
        
    }

}
