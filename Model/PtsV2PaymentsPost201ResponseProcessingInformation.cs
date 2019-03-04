/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
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
    /// PtsV2PaymentsPost201ResponseProcessingInformation
    /// </summary>
    [DataContract]
    public partial class PtsV2PaymentsPost201ResponseProcessingInformation :  IEquatable<PtsV2PaymentsPost201ResponseProcessingInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PtsV2PaymentsPost201ResponseProcessingInformation" /> class.
        /// </summary>
        /// <param name="BankTransferOptions">BankTransferOptions.</param>
        public PtsV2PaymentsPost201ResponseProcessingInformation(PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions BankTransferOptions = default(PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions))
        {
            this.BankTransferOptions = BankTransferOptions;
        }
        
        /// <summary>
        /// Gets or Sets BankTransferOptions
        /// </summary>
        [DataMember(Name="bankTransferOptions", EmitDefaultValue=false)]
        public PtsV2PaymentsPost201ResponseProcessingInformationBankTransferOptions BankTransferOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PtsV2PaymentsPost201ResponseProcessingInformation {\n");
            sb.Append("  BankTransferOptions: ").Append(BankTransferOptions).Append("\n");
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
            return this.Equals(obj as PtsV2PaymentsPost201ResponseProcessingInformation);
        }

        /// <summary>
        /// Returns true if PtsV2PaymentsPost201ResponseProcessingInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of PtsV2PaymentsPost201ResponseProcessingInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PtsV2PaymentsPost201ResponseProcessingInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BankTransferOptions == other.BankTransferOptions ||
                    this.BankTransferOptions != null &&
                    this.BankTransferOptions.Equals(other.BankTransferOptions)
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
                if (this.BankTransferOptions != null)
                    hash = hash * 59 + this.BankTransferOptions.GetHashCode();
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
