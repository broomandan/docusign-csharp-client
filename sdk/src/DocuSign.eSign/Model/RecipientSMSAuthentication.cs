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
    /// Contains the element senderProvidedNumbers which is an Array  of phone numbers the recipient can use for SMS text authentication.
    /// </summary>
    [DataContract]
    public partial class RecipientSMSAuthentication :  IEquatable<RecipientSMSAuthentication>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipientSMSAuthentication" /> class.
        /// </summary>
        /// <param name="SenderProvidedNumbers">An Array containing a list of phone numbers the recipient may use for SMS text authentication. .</param>
        public RecipientSMSAuthentication(List<string> SenderProvidedNumbers = null)
        {
            this.SenderProvidedNumbers = SenderProvidedNumbers;
        }
        
        /// <summary>
        /// An Array containing a list of phone numbers the recipient may use for SMS text authentication. 
        /// </summary>
        /// <value>An Array containing a list of phone numbers the recipient may use for SMS text authentication. </value>
        [DataMember(Name="senderProvidedNumbers", EmitDefaultValue=false)]
        public List<string> SenderProvidedNumbers { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecipientSMSAuthentication {\n");
            sb.Append("  SenderProvidedNumbers: ").Append(SenderProvidedNumbers).Append("\n");
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
            return this.Equals(obj as RecipientSMSAuthentication);
        }

        /// <summary>
        /// Returns true if RecipientSMSAuthentication instances are equal
        /// </summary>
        /// <param name="other">Instance of RecipientSMSAuthentication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecipientSMSAuthentication other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.SenderProvidedNumbers == other.SenderProvidedNumbers ||
                    this.SenderProvidedNumbers != null &&
                    this.SenderProvidedNumbers.SequenceEqual(other.SenderProvidedNumbers)
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
                if (this.SenderProvidedNumbers != null)
                    hash = hash * 59 + this.SenderProvidedNumbers.GetHashCode();
                return hash;
            }
        }
    }

}
