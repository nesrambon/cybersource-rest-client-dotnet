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
    /// PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation :  IEquatable<PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation" /> class.
        /// </summary>
        /// <param name="TerminalId">Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.  #### FDC Nashville Global To have your account configured to support this field, contact CyberSource Customer Support. This value must be a value that FDC Nashville Global issued to you.  For details, see the &#x60;terminal_id&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/)  **For Payouts**: This field is applicable for CtV. .</param>
        public PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation(string TerminalId = default(string))
        {
            this.TerminalId = TerminalId;
        }
        
        /// <summary>
        /// Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.  #### FDC Nashville Global To have your account configured to support this field, contact CyberSource Customer Support. This value must be a value that FDC Nashville Global issued to you.  For details, see the &#x60;terminal_id&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/)  **For Payouts**: This field is applicable for CtV. 
        /// </summary>
        /// <value>Identifier for the terminal at your retail location. You can define this value yourself, but consult the processor for requirements.  #### FDC Nashville Global To have your account configured to support this field, contact CyberSource Customer Support. This value must be a value that FDC Nashville Global issued to you.  For details, see the &#x60;terminal_id&#x60; field description in [Card-Present Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Retail_SCMP_API/html/)  **For Payouts**: This field is applicable for CtV. </value>
        [DataMember(Name="terminalId", EmitDefaultValue=false)]
        public string TerminalId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation {\n");
            sb.Append("  TerminalId: ").Append(TerminalId).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsCapturesPost201ResponsePointOfSaleInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TerminalId == other.TerminalId ||
                    this.TerminalId != null &&
                    this.TerminalId.Equals(other.TerminalId)
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
                if (this.TerminalId != null)
                    hash = hash * 59 + this.TerminalId.GetHashCode();
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
            // TerminalId (string) maxLength
            if(this.TerminalId != null && this.TerminalId.Length >= 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TerminalId, length must be less than or equal to 8.", new [] { "TerminalId" });
            }

            yield break;
        }
    }

}
