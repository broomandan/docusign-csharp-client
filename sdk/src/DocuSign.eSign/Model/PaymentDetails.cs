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
    /// When a formula tab has a &#x60;paymentDetails&#x60; property, the formula tab is a payment item. See [Requesting Payments Along with Signatures][paymentguide] in the DocuSign Support Center to learn more about payments.  [paymentguide]:     https://support.docusign.com/en/guides/requesting-payments-along-with-signatures 
    /// </summary>
    [DataContract]
    public partial class PaymentDetails :  IEquatable<PaymentDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDetails" /> class.
        /// </summary>
        /// <param name="ChargeId">.</param>
        /// <param name="CurrencyCode">Specifies the three-letter [ISO 4217][ISO4217] currency code for the payment.  Supported currencies are:  * AUD Australian dollar * CAD Canadian dollar * EUR Euro * GBP Great Britain pund * USD United States dollar  Specifying any other ISO 4217 code for payments is an error.  [ISO4217]:          https://en.wikipedia.org/wiki/ISO_4217 .</param>
        /// <param name="GatewayAccountId">A GUID that identifies the payment gateway connected to the sender&#39;s DocuSign account.  There is no public API for connecting payment gateway accounts You must connect and manage payment gateway accounts through the DocuSign Admin console and through your chosen payment gateway.  You can get the gateway account ID in the Payments section of the DocuSign Admin console.   [paymentgateways]:  https://support.docusign.com/en/guides/managing-payment-gateways .</param>
        /// <param name="GatewayName">.</param>
        /// <param name="LineItems">A payment formula can have one or more line items that provide detail about individual items in a payment request.  The list of line items are returned as metadata to the payment gateway. .</param>
        /// <param name="Status">This read-only property describes the status of a payment.  * &#x60;new&#x60;&lt;br&gt;   This is a new payment request.   The envelope has been created,   but no payment authorizations have been made.  * &#x60;auth_complete&#x60;&lt;br&gt;   A recipient has entered their credit card information,   but the envelope has not been completed.   The card has not been charged.  * &#x60;payment_complete&#x60;&lt;br&gt;   The recipient&#39;s card has been charged.  * &#x60;payment_capture_failed&#x60;&lt;br&gt;   Final charge failed.   This can happen when too much time   passes between authorizing the payment   and completing the document. .</param>
        /// <param name="Total">This read-only property is a currency-formatted string that represents the total of all the line items. The total is available only after the document is completed, which is when all recipients have paid and have completed all required fields. .</param>
        public PaymentDetails(string ChargeId = null, string CurrencyCode = null, string GatewayAccountId = null, string GatewayName = null, List<PaymentLineItem> LineItems = null, string Status = null, Money Total = null)
        {
            this.ChargeId = ChargeId;
            this.CurrencyCode = CurrencyCode;
            this.GatewayAccountId = GatewayAccountId;
            this.GatewayName = GatewayName;
            this.LineItems = LineItems;
            this.Status = Status;
            this.Total = Total;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="chargeId", EmitDefaultValue=false)]
        public string ChargeId { get; set; }
        /// <summary>
        /// Specifies the three-letter [ISO 4217][ISO4217] currency code for the payment.  Supported currencies are:  * AUD Australian dollar * CAD Canadian dollar * EUR Euro * GBP Great Britain pund * USD United States dollar  Specifying any other ISO 4217 code for payments is an error.  [ISO4217]:          https://en.wikipedia.org/wiki/ISO_4217 
        /// </summary>
        /// <value>Specifies the three-letter [ISO 4217][ISO4217] currency code for the payment.  Supported currencies are:  * AUD Australian dollar * CAD Canadian dollar * EUR Euro * GBP Great Britain pund * USD United States dollar  Specifying any other ISO 4217 code for payments is an error.  [ISO4217]:          https://en.wikipedia.org/wiki/ISO_4217 </value>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public string CurrencyCode { get; set; }
        /// <summary>
        /// A GUID that identifies the payment gateway connected to the sender&#39;s DocuSign account.  There is no public API for connecting payment gateway accounts You must connect and manage payment gateway accounts through the DocuSign Admin console and through your chosen payment gateway.  You can get the gateway account ID in the Payments section of the DocuSign Admin console.   [paymentgateways]:  https://support.docusign.com/en/guides/managing-payment-gateways 
        /// </summary>
        /// <value>A GUID that identifies the payment gateway connected to the sender&#39;s DocuSign account.  There is no public API for connecting payment gateway accounts You must connect and manage payment gateway accounts through the DocuSign Admin console and through your chosen payment gateway.  You can get the gateway account ID in the Payments section of the DocuSign Admin console.   [paymentgateways]:  https://support.docusign.com/en/guides/managing-payment-gateways </value>
        [DataMember(Name="gatewayAccountId", EmitDefaultValue=false)]
        public string GatewayAccountId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <value></value>
        [DataMember(Name="gatewayName", EmitDefaultValue=false)]
        public string GatewayName { get; set; }
        /// <summary>
        /// A payment formula can have one or more line items that provide detail about individual items in a payment request.  The list of line items are returned as metadata to the payment gateway. 
        /// </summary>
        /// <value>A payment formula can have one or more line items that provide detail about individual items in a payment request.  The list of line items are returned as metadata to the payment gateway. </value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<PaymentLineItem> LineItems { get; set; }
        /// <summary>
        /// This read-only property describes the status of a payment.  * &#x60;new&#x60;&lt;br&gt;   This is a new payment request.   The envelope has been created,   but no payment authorizations have been made.  * &#x60;auth_complete&#x60;&lt;br&gt;   A recipient has entered their credit card information,   but the envelope has not been completed.   The card has not been charged.  * &#x60;payment_complete&#x60;&lt;br&gt;   The recipient&#39;s card has been charged.  * &#x60;payment_capture_failed&#x60;&lt;br&gt;   Final charge failed.   This can happen when too much time   passes between authorizing the payment   and completing the document. 
        /// </summary>
        /// <value>This read-only property describes the status of a payment.  * &#x60;new&#x60;&lt;br&gt;   This is a new payment request.   The envelope has been created,   but no payment authorizations have been made.  * &#x60;auth_complete&#x60;&lt;br&gt;   A recipient has entered their credit card information,   but the envelope has not been completed.   The card has not been charged.  * &#x60;payment_complete&#x60;&lt;br&gt;   The recipient&#39;s card has been charged.  * &#x60;payment_capture_failed&#x60;&lt;br&gt;   Final charge failed.   This can happen when too much time   passes between authorizing the payment   and completing the document. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// This read-only property is a currency-formatted string that represents the total of all the line items. The total is available only after the document is completed, which is when all recipients have paid and have completed all required fields. 
        /// </summary>
        /// <value>This read-only property is a currency-formatted string that represents the total of all the line items. The total is available only after the document is completed, which is when all recipients have paid and have completed all required fields. </value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public Money Total { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentDetails {\n");
            sb.Append("  ChargeId: ").Append(ChargeId).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  GatewayAccountId: ").Append(GatewayAccountId).Append("\n");
            sb.Append("  GatewayName: ").Append(GatewayName).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(obj as PaymentDetails);
        }

        /// <summary>
        /// Returns true if PaymentDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ChargeId == other.ChargeId ||
                    this.ChargeId != null &&
                    this.ChargeId.Equals(other.ChargeId)
                ) && 
                (
                    this.CurrencyCode == other.CurrencyCode ||
                    this.CurrencyCode != null &&
                    this.CurrencyCode.Equals(other.CurrencyCode)
                ) && 
                (
                    this.GatewayAccountId == other.GatewayAccountId ||
                    this.GatewayAccountId != null &&
                    this.GatewayAccountId.Equals(other.GatewayAccountId)
                ) && 
                (
                    this.GatewayName == other.GatewayName ||
                    this.GatewayName != null &&
                    this.GatewayName.Equals(other.GatewayName)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.Total == other.Total ||
                    this.Total != null &&
                    this.Total.Equals(other.Total)
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
                if (this.ChargeId != null)
                    hash = hash * 59 + this.ChargeId.GetHashCode();
                if (this.CurrencyCode != null)
                    hash = hash * 59 + this.CurrencyCode.GetHashCode();
                if (this.GatewayAccountId != null)
                    hash = hash * 59 + this.GatewayAccountId.GetHashCode();
                if (this.GatewayName != null)
                    hash = hash * 59 + this.GatewayName.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.Total != null)
                    hash = hash * 59 + this.Total.GetHashCode();
                return hash;
            }
        }
    }

}
