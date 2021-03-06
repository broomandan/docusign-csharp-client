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

using System;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// Contains information about an APP store product.
    /// </summary>
    [DataContract]
    public partial class AppStoreProduct :  IEquatable<AppStoreProduct>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AppStoreProduct" /> class.
        /// </summary>
        /// <param name="MarketPlace">.</param>
        /// <param name="ProductId">The Product ID from the AppStore..</param>
        public AppStoreProduct(string MarketPlace = null, string ProductId = null)
        {
            this.MarketPlace = MarketPlace;
            this.ProductId = ProductId;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="marketPlace", EmitDefaultValue=false)]
        public string MarketPlace { get; set; }
        /// <summary>
        /// The Product ID from the AppStore.
        /// </summary>
        /// <value>The Product ID from the AppStore.</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AppStoreProduct {\n");
            sb.Append("  MarketPlace: ").Append(MarketPlace).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as AppStoreProduct);
        }

        /// <summary>
        /// Returns true if AppStoreProduct instances are equal
        /// </summary>
        /// <param name="other">Instance of AppStoreProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AppStoreProduct other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MarketPlace == other.MarketPlace ||
                    this.MarketPlace != null &&
                    this.MarketPlace.Equals(other.MarketPlace)
                ) && 
                (
                    this.ProductId == other.ProductId ||
                    this.ProductId != null &&
                    this.ProductId.Equals(other.ProductId)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.MarketPlace != null)
                    hash = hash * 59 + this.MarketPlace.GetHashCode();
                if (this.ProductId != null)
                    hash = hash * 59 + this.ProductId.GetHashCode();
                return hash;
            }
        }
    }

}
