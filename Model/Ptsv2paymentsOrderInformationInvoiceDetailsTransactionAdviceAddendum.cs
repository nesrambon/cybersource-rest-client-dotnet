/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum :  IEquatable<Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum" /> class.
        /// </summary>
        /// <param name="Data">Four Transaction Advice Addendum (TAA) fields. These fields are used to display descriptive information about a transaction on the customer’s American Express card statement. When you send TAA fields, start with amexdata_taa1, then ...taa2, and so on. Skipping a TAA field causes subsequent TAA fields to be ignored.  To use these fields, contact CyberSource Customer Support to have your account enabled for this feature. .</param>
        public Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum(string Data = default(string))
        {
            this.Data = Data;
        }
        
        /// <summary>
        /// Four Transaction Advice Addendum (TAA) fields. These fields are used to display descriptive information about a transaction on the customer’s American Express card statement. When you send TAA fields, start with amexdata_taa1, then ...taa2, and so on. Skipping a TAA field causes subsequent TAA fields to be ignored.  To use these fields, contact CyberSource Customer Support to have your account enabled for this feature. 
        /// </summary>
        /// <value>Four Transaction Advice Addendum (TAA) fields. These fields are used to display descriptive information about a transaction on the customer’s American Express card statement. When you send TAA fields, start with amexdata_taa1, then ...taa2, and so on. Skipping a TAA field causes subsequent TAA fields to be ignored.  To use these fields, contact CyberSource Customer Support to have your account enabled for this feature. </value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Data == other.Data ||
                    this.Data != null &&
                    this.Data.Equals(other.Data)
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
                if (this.Data != null)
                    hash = hash * 59 + this.Data.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
