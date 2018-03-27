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
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace DocuSign.eSign.Model
{
    /// <summary>
    /// 
    /// </summary>
    [DataContract]
    public partial class RecipientNamesResponse :  IEquatable<RecipientNamesResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientNamesResponse" /> class.
        /// </summary>
        /// <param name="MultipleUsers">Indicates whether email address is used by more than one user..</param>
        /// <param name="RecipientNames">.</param>
        /// <param name="ReservedRecipientEmail">.</param>
        public RecipientNamesResponse(string MultipleUsers = null, List<string> RecipientNames = null, string ReservedRecipientEmail = null)
        {
            this.MultipleUsers = MultipleUsers;
            this.RecipientNames = RecipientNames;
            this.ReservedRecipientEmail = ReservedRecipientEmail;
        }
        
        /// <summary>
        /// Indicates whether email address is used by more than one user.
        /// </summary>
        /// <value>Indicates whether email address is used by more than one user.</value>
        [DataMember(Name="multipleUsers", EmitDefaultValue=false)]
        public string MultipleUsers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="recipientNames", EmitDefaultValue=false)]
        public List<string> RecipientNames { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="reservedRecipientEmail", EmitDefaultValue=false)]
        public string ReservedRecipientEmail { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientNamesResponse {\n");
            sb.Append("  MultipleUsers: ").Append(MultipleUsers).Append("\n");
            sb.Append("  RecipientNames: ").Append(RecipientNames).Append("\n");
            sb.Append("  ReservedRecipientEmail: ").Append(ReservedRecipientEmail).Append("\n");
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
            return this.Equals(obj as RecipientNamesResponse);
        }

        /// <summary>
        /// Returns true if RecipientNamesResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientNamesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientNamesResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MultipleUsers == other.MultipleUsers ||
                    this.MultipleUsers != null &&
                    this.MultipleUsers.Equals(other.MultipleUsers)
                ) && 
                (
                    this.RecipientNames == other.RecipientNames ||
                    this.RecipientNames != null &&
                    this.RecipientNames.SequenceEqual(other.RecipientNames)
                ) && 
                (
                    this.ReservedRecipientEmail == other.ReservedRecipientEmail ||
                    this.ReservedRecipientEmail != null &&
                    this.ReservedRecipientEmail.Equals(other.ReservedRecipientEmail)
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
                if (this.MultipleUsers != null)
                    hash = hash * 59 + this.MultipleUsers.GetHashCode();
                if (this.RecipientNames != null)
                    hash = hash * 59 + this.RecipientNames.GetHashCode();
                if (this.ReservedRecipientEmail != null)
                    hash = hash * 59 + this.ReservedRecipientEmail.GetHashCode();
                return hash;
            }
        }
    }

}
