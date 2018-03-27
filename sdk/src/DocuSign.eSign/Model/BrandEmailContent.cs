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
    public partial class BrandEmailContent :  IEquatable<BrandEmailContent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BrandEmailContent" /> class.
        /// </summary>
        /// <param name="Content">.</param>
        /// <param name="EmailContentType">.</param>
        /// <param name="EmailToLink">.</param>
        /// <param name="LinkText">.</param>
        public BrandEmailContent(string Content = null, string EmailContentType = null, string EmailToLink = null, string LinkText = null)
        {
            this.Content = Content;
            this.EmailContentType = EmailContentType;
            this.EmailToLink = EmailToLink;
            this.LinkText = LinkText;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="emailContentType", EmitDefaultValue=false)]
        public string EmailContentType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="emailToLink", EmitDefaultValue=false)]
        public string EmailToLink { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="linkText", EmitDefaultValue=false)]
        public string LinkText { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BrandEmailContent {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  EmailContentType: ").Append(EmailContentType).Append("\n");
            sb.Append("  EmailToLink: ").Append(EmailToLink).Append("\n");
            sb.Append("  LinkText: ").Append(LinkText).Append("\n");
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
            return this.Equals(obj as BrandEmailContent);
        }

        /// <summary>
        /// Returns true if BrandEmailContent instances are equal
        /// </summary>
        /// <param name="other">Instance of BrandEmailContent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BrandEmailContent other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Content == other.Content ||
                    this.Content != null &&
                    this.Content.Equals(other.Content)
                ) && 
                (
                    this.EmailContentType == other.EmailContentType ||
                    this.EmailContentType != null &&
                    this.EmailContentType.Equals(other.EmailContentType)
                ) && 
                (
                    this.EmailToLink == other.EmailToLink ||
                    this.EmailToLink != null &&
                    this.EmailToLink.Equals(other.EmailToLink)
                ) && 
                (
                    this.LinkText == other.LinkText ||
                    this.LinkText != null &&
                    this.LinkText.Equals(other.LinkText)
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
                if (this.Content != null)
                    hash = hash * 59 + this.Content.GetHashCode();
                if (this.EmailContentType != null)
                    hash = hash * 59 + this.EmailContentType.GetHashCode();
                if (this.EmailToLink != null)
                    hash = hash * 59 + this.EmailToLink.GetHashCode();
                if (this.LinkText != null)
                    hash = hash * 59 + this.LinkText.GetHashCode();
                return hash;
            }
        }
    }

}
