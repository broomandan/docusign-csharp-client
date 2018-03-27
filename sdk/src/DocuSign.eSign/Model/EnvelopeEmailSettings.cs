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
    /// Envelope email settings
    /// </summary>
    [DataContract]
    public partial class EnvelopeEmailSettings :  IEquatable<EnvelopeEmailSettings>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeEmailSettings" /> class.
        /// </summary>
        /// <param name="BccEmailAddresses">A list of email addresses that receive a copy of all email communications for an envelope. You can use this for archiving purposes..</param>
        /// <param name="ReplyEmailAddressOverride">.</param>
        /// <param name="ReplyEmailNameOverride">.</param>
        public EnvelopeEmailSettings(List<BccEmailAddress> BccEmailAddresses = null, string ReplyEmailAddressOverride = null, string ReplyEmailNameOverride = null)
        {
            this.BccEmailAddresses = BccEmailAddresses;
            this.ReplyEmailAddressOverride = ReplyEmailAddressOverride;
            this.ReplyEmailNameOverride = ReplyEmailNameOverride;
        }
        
        /// <summary>
        /// A list of email addresses that receive a copy of all email communications for an envelope. You can use this for archiving purposes.
        /// </summary>
        /// <value>A list of email addresses that receive a copy of all email communications for an envelope. You can use this for archiving purposes.</value>
        [DataMember(Name="bccEmailAddresses", EmitDefaultValue=false)]
        public List<BccEmailAddress> BccEmailAddresses { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="replyEmailAddressOverride", EmitDefaultValue=false)]
        public string ReplyEmailAddressOverride { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="replyEmailNameOverride", EmitDefaultValue=false)]
        public string ReplyEmailNameOverride { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeEmailSettings {\n");
            sb.Append("  BccEmailAddresses: ").Append(BccEmailAddresses).Append("\n");
            sb.Append("  ReplyEmailAddressOverride: ").Append(ReplyEmailAddressOverride).Append("\n");
            sb.Append("  ReplyEmailNameOverride: ").Append(ReplyEmailNameOverride).Append("\n");
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
            return this.Equals(obj as EnvelopeEmailSettings);
        }

        /// <summary>
        /// Returns true if EnvelopeEmailSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of EnvelopeEmailSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeEmailSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BccEmailAddresses == other.BccEmailAddresses ||
                    this.BccEmailAddresses != null &&
                    this.BccEmailAddresses.SequenceEqual(other.BccEmailAddresses)
                ) && 
                (
                    this.ReplyEmailAddressOverride == other.ReplyEmailAddressOverride ||
                    this.ReplyEmailAddressOverride != null &&
                    this.ReplyEmailAddressOverride.Equals(other.ReplyEmailAddressOverride)
                ) && 
                (
                    this.ReplyEmailNameOverride == other.ReplyEmailNameOverride ||
                    this.ReplyEmailNameOverride != null &&
                    this.ReplyEmailNameOverride.Equals(other.ReplyEmailNameOverride)
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
                if (this.BccEmailAddresses != null)
                    hash = hash * 59 + this.BccEmailAddresses.GetHashCode();
                if (this.ReplyEmailAddressOverride != null)
                    hash = hash * 59 + this.ReplyEmailAddressOverride.GetHashCode();
                if (this.ReplyEmailNameOverride != null)
                    hash = hash * 59 + this.ReplyEmailNameOverride.GetHashCode();
                return hash;
            }
        }
    }

}