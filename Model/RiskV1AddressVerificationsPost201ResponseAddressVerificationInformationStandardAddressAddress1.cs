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
    /// RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1
    /// </summary>
    [DataContract]
    public partial class RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1 :  IEquatable<RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1" /> class.
        /// </summary>
        /// <param name="WithApartment">First line of the standardized address, including apartment information..</param>
        /// <param name="WithoutApartment">First line of the standardized address, without apartment information. Returned for U.S. and Canadian addresses. .</param>
        public RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1(string WithApartment = default(string), string WithoutApartment = default(string))
        {
            this.WithApartment = WithApartment;
            this.WithoutApartment = WithoutApartment;
        }
        
        /// <summary>
        /// First line of the standardized address, including apartment information.
        /// </summary>
        /// <value>First line of the standardized address, including apartment information.</value>
        [DataMember(Name="withApartment", EmitDefaultValue=false)]
        public string WithApartment { get; set; }

        /// <summary>
        /// First line of the standardized address, without apartment information. Returned for U.S. and Canadian addresses. 
        /// </summary>
        /// <value>First line of the standardized address, without apartment information. Returned for U.S. and Canadian addresses. </value>
        [DataMember(Name="withoutApartment", EmitDefaultValue=false)]
        public string WithoutApartment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1 {\n");
            sb.Append("  WithApartment: ").Append(WithApartment).Append("\n");
            sb.Append("  WithoutApartment: ").Append(WithoutApartment).Append("\n");
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
            return this.Equals(obj as RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1);
        }

        /// <summary>
        /// Returns true if RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1 instances are equal
        /// </summary>
        /// <param name="other">Instance of RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RiskV1AddressVerificationsPost201ResponseAddressVerificationInformationStandardAddressAddress1 other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WithApartment == other.WithApartment ||
                    this.WithApartment != null &&
                    this.WithApartment.Equals(other.WithApartment)
                ) && 
                (
                    this.WithoutApartment == other.WithoutApartment ||
                    this.WithoutApartment != null &&
                    this.WithoutApartment.Equals(other.WithoutApartment)
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
                if (this.WithApartment != null)
                    hash = hash * 59 + this.WithApartment.GetHashCode();
                if (this.WithoutApartment != null)
                    hash = hash * 59 + this.WithoutApartment.GetHashCode();
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
            // WithApartment (string) maxLength
            if(this.WithApartment != null && this.WithApartment.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WithApartment, length must be less than or equal to 255.", new [] { "WithApartment" });
            }

            // WithoutApartment (string) maxLength
            if(this.WithoutApartment != null && this.WithoutApartment.Length >= 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for WithoutApartment, length must be less than or equal to 255.", new [] { "WithoutApartment" });
            }

            yield break;
        }
    }

}
