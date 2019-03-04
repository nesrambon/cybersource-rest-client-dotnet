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
    /// Provides failed validation input field detail 
    /// </summary>
    [DataContract]
    public partial class Reportingv3ReportDownloadsGet400ResponseDetails :  IEquatable<Reportingv3ReportDownloadsGet400ResponseDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reportingv3ReportDownloadsGet400ResponseDetails" /> class.
        /// </summary>
        /// <param name="Field">Field in request that caused an error .</param>
        /// <param name="Reason">Documented reason code .</param>
        public Reportingv3ReportDownloadsGet400ResponseDetails(string Field = default(string), string Reason = default(string))
        {
            this.Field = Field;
            this.Reason = Reason;
        }
        
        /// <summary>
        /// Field in request that caused an error 
        /// </summary>
        /// <value>Field in request that caused an error </value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Documented reason code 
        /// </summary>
        /// <value>Documented reason code </value>
        [DataMember(Name="reason", EmitDefaultValue=false)]
        public string Reason { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Reportingv3ReportDownloadsGet400ResponseDetails {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
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
            return this.Equals(obj as Reportingv3ReportDownloadsGet400ResponseDetails);
        }

        /// <summary>
        /// Returns true if Reportingv3ReportDownloadsGet400ResponseDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Reportingv3ReportDownloadsGet400ResponseDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Reportingv3ReportDownloadsGet400ResponseDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Field == other.Field ||
                    this.Field != null &&
                    this.Field.Equals(other.Field)
                ) && 
                (
                    this.Reason == other.Reason ||
                    this.Reason != null &&
                    this.Reason.Equals(other.Reason)
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
                if (this.Field != null)
                    hash = hash * 59 + this.Field.GetHashCode();
                if (this.Reason != null)
                    hash = hash * 59 + this.Reason.GetHashCode();
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
