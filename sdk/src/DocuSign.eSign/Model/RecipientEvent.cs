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
    public partial class RecipientEvent :  IEquatable<RecipientEvent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientEvent" /> class.
        /// </summary>
        /// <param name="IncludeDocuments">reserved.</param>
        /// <param name="RecipientEventStatusCode">Send a webhook notification for the following recipient statuses: Sent, Delivered, Completed, Declined, AuthenticationFailed, and AutoResponded..</param>
        public RecipientEvent(string IncludeDocuments = null, string RecipientEventStatusCode = null)
        {
            this.IncludeDocuments = IncludeDocuments;
            this.RecipientEventStatusCode = RecipientEventStatusCode;
        }
        
        /// <summary>
        /// reserved
        /// </summary>
        /// <value>reserved</value>
        [DataMember(Name="includeDocuments", EmitDefaultValue=false)]
        public string IncludeDocuments { get; set; }
        /// <summary>
        /// Send a webhook notification for the following recipient statuses: Sent, Delivered, Completed, Declined, AuthenticationFailed, and AutoResponded.
        /// </summary>
        /// <value>Send a webhook notification for the following recipient statuses: Sent, Delivered, Completed, Declined, AuthenticationFailed, and AutoResponded.</value>
        [DataMember(Name="recipientEventStatusCode", EmitDefaultValue=false)]
        public string RecipientEventStatusCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientEvent {\n");
            sb.Append("  IncludeDocuments: ").Append(IncludeDocuments).Append("\n");
            sb.Append("  RecipientEventStatusCode: ").Append(RecipientEventStatusCode).Append("\n");
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
            return this.Equals(obj as RecipientEvent);
        }

        /// <summary>
        /// Returns true if RecipientEvent instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientEvent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IncludeDocuments == other.IncludeDocuments ||
                    this.IncludeDocuments != null &&
                    this.IncludeDocuments.Equals(other.IncludeDocuments)
                ) && 
                (
                    this.RecipientEventStatusCode == other.RecipientEventStatusCode ||
                    this.RecipientEventStatusCode != null &&
                    this.RecipientEventStatusCode.Equals(other.RecipientEventStatusCode)
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
                if (this.IncludeDocuments != null)
                    hash = hash * 59 + this.IncludeDocuments.GetHashCode();
                if (this.RecipientEventStatusCode != null)
                    hash = hash * 59 + this.RecipientEventStatusCode.GetHashCode();
                return hash;
            }
        }
    }

}
