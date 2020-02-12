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
    /// The Network Token associated with the Instrument Identifier (PAN)
    /// </summary>
    [DataContract]
    public partial class TmsV1InstrumentIdentifiersPost200ResponseTokenizedCard :  IEquatable<TmsV1InstrumentIdentifiersPost200ResponseTokenizedCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TmsV1InstrumentIdentifiersPost200ResponseTokenizedCard" /> class.
        /// </summary>
        /// <param name="State">Issuer state for the Network Token Valid values: - ACTIVE - SUSPENDED - DELETED .</param>
        /// <param name="Card">Card.</param>
        public TmsV1InstrumentIdentifiersPost200ResponseTokenizedCard(string State = default(string), TmsV1InstrumentIdentifiersPost200ResponseTokenizedCardCard Card = default(TmsV1InstrumentIdentifiersPost200ResponseTokenizedCardCard))
        {
            this.State = State;
            this.Card = Card;
        }
        
        /// <summary>
        /// Issuer state for the Network Token Valid values: - ACTIVE - SUSPENDED - DELETED 
        /// </summary>
        /// <value>Issuer state for the Network Token Valid values: - ACTIVE - SUSPENDED - DELETED </value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// The Network Token expiration month, automatically updated
        /// </summary>
        /// <value>The Network Token expiration month, automatically updated</value>
        [DataMember(Name="expirationMonth", EmitDefaultValue=false)]
        public string ExpirationMonth { get; private set; }

        /// <summary>
        /// The Network Token expiration year, automatically updated
        /// </summary>
        /// <value>The Network Token expiration year, automatically updated</value>
        [DataMember(Name="expirationYear", EmitDefaultValue=false)]
        public string ExpirationYear { get; private set; }

        /// <summary>
        /// The Network Token brand Valid values: - visa - mastercard 
        /// </summary>
        /// <value>The Network Token brand Valid values: - visa - mastercard </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or Sets Card
        /// </summary>
        [DataMember(Name="card", EmitDefaultValue=false)]
        public TmsV1InstrumentIdentifiersPost200ResponseTokenizedCardCard Card { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TmsV1InstrumentIdentifiersPost200ResponseTokenizedCard {\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  ExpirationMonth: ").Append(ExpirationMonth).Append("\n");
            sb.Append("  ExpirationYear: ").Append(ExpirationYear).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Card: ").Append(Card).Append("\n");
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
            return this.Equals(obj as TmsV1InstrumentIdentifiersPost200ResponseTokenizedCard);
        }

        /// <summary>
        /// Returns true if TmsV1InstrumentIdentifiersPost200ResponseTokenizedCard instances are equal
        /// </summary>
        /// <param name="other">Instance of TmsV1InstrumentIdentifiersPost200ResponseTokenizedCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TmsV1InstrumentIdentifiersPost200ResponseTokenizedCard other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.ExpirationMonth == other.ExpirationMonth ||
                    this.ExpirationMonth != null &&
                    this.ExpirationMonth.Equals(other.ExpirationMonth)
                ) && 
                (
                    this.ExpirationYear == other.ExpirationYear ||
                    this.ExpirationYear != null &&
                    this.ExpirationYear.Equals(other.ExpirationYear)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Card == other.Card ||
                    this.Card != null &&
                    this.Card.Equals(other.Card)
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
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.ExpirationMonth != null)
                    hash = hash * 59 + this.ExpirationMonth.GetHashCode();
                if (this.ExpirationYear != null)
                    hash = hash * 59 + this.ExpirationYear.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Card != null)
                    hash = hash * 59 + this.Card.GetHashCode();
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
            // ExpirationMonth (string) maxLength
            if(this.ExpirationMonth != null && this.ExpirationMonth.Length >= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationMonth, length must be less than or equal to 2.", new [] { "ExpirationMonth" });
            }

            // ExpirationMonth (string) minLength
            if(this.ExpirationMonth != null && this.ExpirationMonth.Length <= 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationMonth, length must be greater than or equal to 2.", new [] { "ExpirationMonth" });
            }

            // ExpirationYear (string) maxLength
            if(this.ExpirationYear != null && this.ExpirationYear.Length >= 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationYear, length must be less than or equal to 4.", new [] { "ExpirationYear" });
            }

            // ExpirationYear (string) minLength
            if(this.ExpirationYear != null && this.ExpirationYear.Length <= 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExpirationYear, length must be greater than or equal to 4.", new [] { "ExpirationYear" });
            }

            yield break;
        }
    }

}
