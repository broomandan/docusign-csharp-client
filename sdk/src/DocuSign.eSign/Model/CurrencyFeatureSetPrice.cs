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
    /// 
    /// </summary>
    [DataContract]
    public partial class CurrencyFeatureSetPrice :  IEquatable<CurrencyFeatureSetPrice>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyFeatureSetPrice" /> class.
        /// </summary>
        /// <param name="CurrencyCode">Specifies the alternate ISO currency code for the account. .</param>
        /// <param name="CurrencySymbol">Specifies the alternate currency symbol for the account..</param>
        /// <param name="EnvelopeFee">An incremental envelope cost for plans with envelope overages (when &#x60;isEnabled&#x60; is set to **true**.).</param>
        /// <param name="FixedFee">Specifies a one-time fee associated with the plan (when &#x60;isEnabled&#x60; is set to **true**.).</param>
        /// <param name="SeatFee">Specifies an incremental seat cost for seat-based plans (when &#x60;isEnabled&#x60; is set to **true**.).</param>
        public CurrencyFeatureSetPrice(string CurrencyCode = null, string CurrencySymbol = null, string EnvelopeFee = null, string FixedFee = null, string SeatFee = null)
        {
            this.CurrencyCode = CurrencyCode;
            this.CurrencySymbol = CurrencySymbol;
            this.EnvelopeFee = EnvelopeFee;
            this.FixedFee = FixedFee;
            this.SeatFee = SeatFee;
        }
        
        /// <summary>
        /// Specifies the alternate ISO currency code for the account. 
        /// </summary>
        /// <value>Specifies the alternate ISO currency code for the account. </value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// Specifies the alternate currency symbol for the account.
        /// </summary>
        /// <value>Specifies the alternate currency symbol for the account.</value>
        [DataMember(Name="currencySymbol", EmitDefaultValue=false)]
        public string CurrencySymbol { get; set; }
        /// <summary>
        /// An incremental envelope cost for plans with envelope overages (when &#x60;isEnabled&#x60; is set to **true**.)
        /// </summary>
        /// <value>An incremental envelope cost for plans with envelope overages (when &#x60;isEnabled&#x60; is set to **true**.)</value>
        [DataMember(Name="envelopeFee", EmitDefaultValue=false)]
        public string EnvelopeFee { get; set; }
        /// <summary>
        /// Specifies a one-time fee associated with the plan (when &#x60;isEnabled&#x60; is set to **true**.)
        /// </summary>
        /// <value>Specifies a one-time fee associated with the plan (when &#x60;isEnabled&#x60; is set to **true**.)</value>
        [DataMember(Name="fixedFee", EmitDefaultValue=false)]
        public string FixedFee { get; set; }
        /// <summary>
        /// Specifies an incremental seat cost for seat-based plans (when &#x60;isEnabled&#x60; is set to **true**.)
        /// </summary>
        /// <value>Specifies an incremental seat cost for seat-based plans (when &#x60;isEnabled&#x60; is set to **true**.)</value>
        [DataMember(Name="seatFee", EmitDefaultValue=false)]
        public string SeatFee { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CurrencyFeatureSetPrice {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  CurrencySymbol: ").Append(CurrencySymbol).Append("\n");
            sb.Append("  EnvelopeFee: ").Append(EnvelopeFee).Append("\n");
            sb.Append("  FixedFee: ").Append(FixedFee).Append("\n");
            sb.Append("  SeatFee: ").Append(SeatFee).Append("\n");
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
            return this.Equals(obj as CurrencyFeatureSetPrice);
        }

        /// <summary>
        /// Returns true if CurrencyFeatureSetPrice instances are equal
        /// </summary>
        /// <param name="other">Instance of CurrencyFeatureSetPrice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CurrencyFeatureSetPrice other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.CurrencySymbol == other.CurrencySymbol ||
                    this.CurrencySymbol != null &&
                    this.CurrencySymbol.Equals(other.CurrencySymbol)
                ) && 
                (
                    this.EnvelopeFee == other.EnvelopeFee ||
                    this.EnvelopeFee != null &&
                    this.EnvelopeFee.Equals(other.EnvelopeFee)
                ) && 
                (
                    this.FixedFee == other.FixedFee ||
                    this.FixedFee != null &&
                    this.FixedFee.Equals(other.FixedFee)
                ) && 
                (
                    this.SeatFee == other.SeatFee ||
                    this.SeatFee != null &&
                    this.SeatFee.Equals(other.SeatFee)
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
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.CurrencySymbol != null)
                    hash = hash * 59 + this.CurrencySymbol.GetHashCode();
                if (this.EnvelopeFee != null)
                    hash = hash * 59 + this.EnvelopeFee.GetHashCode();
                if (this.FixedFee != null)
                    hash = hash * 59 + this.FixedFee.GetHashCode();
                if (this.SeatFee != null)
                    hash = hash * 59 + this.SeatFee.GetHashCode();
                return hash;
            }
        }
    }

}
