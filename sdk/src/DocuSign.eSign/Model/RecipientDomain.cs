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
    public partial class RecipientDomain :  IEquatable<RecipientDomain>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientDomain" /> class.
        /// </summary>
        /// <param name="Active">.</param>
        /// <param name="DomainCode">.</param>
        /// <param name="DomainName">.</param>
        /// <param name="RecipientDomainId">.</param>
        public RecipientDomain(string Active = null, string DomainCode = null, string DomainName = null, string RecipientDomainId = null)
        {
            this.Active = Active;
            this.DomainCode = DomainCode;
            this.DomainName = DomainName;
            this.RecipientDomainId = RecipientDomainId;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public string Active { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="domainCode", EmitDefaultValue=false)]
        public string DomainCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="domainName", EmitDefaultValue=false)]
        public string DomainName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="recipientDomainId", EmitDefaultValue=false)]
        public string RecipientDomainId { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientDomain {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  DomainCode: ").Append(DomainCode).Append("\n");
            sb.Append("  DomainName: ").Append(DomainName).Append("\n");
            sb.Append("  RecipientDomainId: ").Append(RecipientDomainId).Append("\n");
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
            return this.Equals(obj as RecipientDomain);
        }

        /// <summary>
        /// Returns true if RecipientDomain instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientDomain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientDomain other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Active == other.Active ||
                    this.Active != null &&
                    this.Active.Equals(other.Active)
                ) && 
                (
                    this.DomainCode == other.DomainCode ||
                    this.DomainCode != null &&
                    this.DomainCode.Equals(other.DomainCode)
                ) && 
                (
                    this.DomainName == other.DomainName ||
                    this.DomainName != null &&
                    this.DomainName.Equals(other.DomainName)
                ) && 
                (
                    this.RecipientDomainId == other.RecipientDomainId ||
                    this.RecipientDomainId != null &&
                    this.RecipientDomainId.Equals(other.RecipientDomainId)
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
                if (this.Active != null)
                    hash = hash * 59 + this.Active.GetHashCode();
                if (this.DomainCode != null)
                    hash = hash * 59 + this.DomainCode.GetHashCode();
                if (this.DomainName != null)
                    hash = hash * 59 + this.DomainName.GetHashCode();
                if (this.RecipientDomainId != null)
                    hash = hash * 59 + this.RecipientDomainId.GetHashCode();
                return hash;
            }
        }
    }

}
