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
    /// Ptsv2paymentsidrefundsProcessingInformationRecurringOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsidrefundsProcessingInformationRecurringOptions :  IEquatable<Ptsv2paymentsidrefundsProcessingInformationRecurringOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsidrefundsProcessingInformationRecurringOptions" /> class.
        /// </summary>
        /// <param name="LoanPayment">Flag that indicates whether this is a payment towards an existing contractual loan.  Possible values: - &#x60;true&#x60;: Loan payment - &#x60;false&#x60;: (default) Not a loan payment  For processor-specific details, see &#x60;debt_indicator&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/)  (default to false).</param>
        public Ptsv2paymentsidrefundsProcessingInformationRecurringOptions(bool? LoanPayment = false)
        {
            // use default value if no "LoanPayment" provided
            if (LoanPayment == null)
            {
                this.LoanPayment = false;
            }
            else
            {
                this.LoanPayment = LoanPayment;
            }
        }
        
        /// <summary>
        /// Flag that indicates whether this is a payment towards an existing contractual loan.  Possible values: - &#x60;true&#x60;: Loan payment - &#x60;false&#x60;: (default) Not a loan payment  For processor-specific details, see &#x60;debt_indicator&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) 
        /// </summary>
        /// <value>Flag that indicates whether this is a payment towards an existing contractual loan.  Possible values: - &#x60;true&#x60;: Loan payment - &#x60;false&#x60;: (default) Not a loan payment  For processor-specific details, see &#x60;debt_indicator&#x60; field description in [Credit Card Services Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/CC_Svcs_SCMP_API/html/) </value>
        [DataMember(Name="loanPayment", EmitDefaultValue=false)]
        public bool? LoanPayment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsidrefundsProcessingInformationRecurringOptions {\n");
            sb.Append("  LoanPayment: ").Append(LoanPayment).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsidrefundsProcessingInformationRecurringOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsidrefundsProcessingInformationRecurringOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsidrefundsProcessingInformationRecurringOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsidrefundsProcessingInformationRecurringOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.LoanPayment == other.LoanPayment ||
                    this.LoanPayment != null &&
                    this.LoanPayment.Equals(other.LoanPayment)
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
                if (this.LoanPayment != null)
                    hash = hash * 59 + this.LoanPayment.GetHashCode();
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
