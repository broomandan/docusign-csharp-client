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
    /// Contains information about a preview billing plan.
    /// </summary>
    [DataContract]
    public partial class BillingPlanPreview :  IEquatable<BillingPlanPreview>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BillingPlanPreview" /> class.
        /// </summary>
        /// <param name="CurrencyCode">Specifies the ISO currency code for the account..</param>
        /// <param name="Invoice">.</param>
        /// <param name="IsProrated">.</param>
        /// <param name="SubtotalAmount">.</param>
        /// <param name="TaxAmount">.</param>
        /// <param name="TotalAmount">.</param>
        public BillingPlanPreview(string CurrencyCode = null, Invoices Invoice = null, string IsProrated = null, string SubtotalAmount = null, string TaxAmount = null, string TotalAmount = null)
        {
            this.CurrencyCode = CurrencyCode;
            this.Invoice = Invoice;
            this.IsProrated = IsProrated;
            this.SubtotalAmount = SubtotalAmount;
            this.TaxAmount = TaxAmount;
            this.TotalAmount = TotalAmount;
        }
        
        /// <summary>
        /// Specifies the ISO currency code for the account.
        /// </summary>
        /// <value>Specifies the ISO currency code for the account.</value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public Invoices Invoice { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="isProrated", EmitDefaultValue=false)]
        public string IsProrated { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="subtotalAmount", EmitDefaultValue=false)]
        public string SubtotalAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public string TaxAmount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public string TotalAmount { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingPlanPreview {\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  IsProrated: ").Append(IsProrated).Append("\n");
            sb.Append("  SubtotalAmount: ").Append(SubtotalAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
            return this.Equals(obj as BillingPlanPreview);
        }

        /// <summary>
        /// Returns true if BillingPlanPreview instances are equal
        /// </summary>
        /// <param name="other">Instance of BillingPlanPreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BillingPlanPreview other)
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
                    this.Invoice == other.Invoice ||
                    this.Invoice != null &&
                    this.Invoice.Equals(other.Invoice)
                ) && 
                (
                    this.IsProrated == other.IsProrated ||
                    this.IsProrated != null &&
                    this.IsProrated.Equals(other.IsProrated)
                ) && 
                (
                    this.SubtotalAmount == other.SubtotalAmount ||
                    this.SubtotalAmount != null &&
                    this.SubtotalAmount.Equals(other.SubtotalAmount)
                ) && 
                (
                    this.TaxAmount == other.TaxAmount ||
                    this.TaxAmount != null &&
                    this.TaxAmount.Equals(other.TaxAmount)
                ) && 
                (
                    this.TotalAmount == other.TotalAmount ||
                    this.TotalAmount != null &&
                    this.TotalAmount.Equals(other.TotalAmount)
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
                if (this.Invoice != null)
                    hash = hash * 59 + this.Invoice.GetHashCode();
                if (this.IsProrated != null)
                    hash = hash * 59 + this.IsProrated.GetHashCode();
                if (this.SubtotalAmount != null)
                    hash = hash * 59 + this.SubtotalAmount.GetHashCode();
                if (this.TaxAmount != null)
                    hash = hash * 59 + this.TaxAmount.GetHashCode();
                if (this.TotalAmount != null)
                    hash = hash * 59 + this.TotalAmount.GetHashCode();
                return hash;
            }
        }
    }

}
