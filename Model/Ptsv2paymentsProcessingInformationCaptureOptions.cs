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
    /// Ptsv2paymentsProcessingInformationCaptureOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsProcessingInformationCaptureOptions :  IEquatable<Ptsv2paymentsProcessingInformationCaptureOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsProcessingInformationCaptureOptions" /> class.
        /// </summary>
        /// <param name="CaptureSequenceNumber">Capture number when requesting multiple partial captures for one authorization. Used along with &#x60;totalCaptureCount&#x60; to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber_ &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; .</param>
        /// <param name="TotalCaptureCount">Total number of captures when requesting multiple partial captures for one payment. Used along with &#x60;captureSequenceNumber&#x60; field to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; .</param>
        /// <param name="DateToCapture">Date on which you want the capture to occur. This field is supported only for CyberSource through VisaNet. Format: &#x60;MMDD&#x60;  #### Used by **Authorization** Optional field. .</param>
        public Ptsv2paymentsProcessingInformationCaptureOptions(int? CaptureSequenceNumber = default(int?), int? TotalCaptureCount = default(int?), string DateToCapture = default(string))
        {
            this.CaptureSequenceNumber = CaptureSequenceNumber;
            this.TotalCaptureCount = TotalCaptureCount;
            this.DateToCapture = DateToCapture;
        }
        
        /// <summary>
        /// Capture number when requesting multiple partial captures for one authorization. Used along with &#x60;totalCaptureCount&#x60; to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber_ &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; 
        /// </summary>
        /// <value>Capture number when requesting multiple partial captures for one authorization. Used along with &#x60;totalCaptureCount&#x60; to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber_ &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; </value>
        [DataMember(Name="captureSequenceNumber", EmitDefaultValue=false)]
        public int? CaptureSequenceNumber { get; set; }

        /// <summary>
        /// Total number of captures when requesting multiple partial captures for one payment. Used along with &#x60;captureSequenceNumber&#x60; field to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; 
        /// </summary>
        /// <value>Total number of captures when requesting multiple partial captures for one payment. Used along with &#x60;captureSequenceNumber&#x60; field to track which capture is being processed.  For example, the second of five captures would be passed to CyberSource as:   - &#x60;captureSequenceNumber &#x3D; 2&#x60;, and   - &#x60;totalCaptureCount &#x3D; 5&#x60; </value>
        [DataMember(Name="totalCaptureCount", EmitDefaultValue=false)]
        public int? TotalCaptureCount { get; set; }

        /// <summary>
        /// Date on which you want the capture to occur. This field is supported only for CyberSource through VisaNet. Format: &#x60;MMDD&#x60;  #### Used by **Authorization** Optional field. 
        /// </summary>
        /// <value>Date on which you want the capture to occur. This field is supported only for CyberSource through VisaNet. Format: &#x60;MMDD&#x60;  #### Used by **Authorization** Optional field. </value>
        [DataMember(Name="dateToCapture", EmitDefaultValue=false)]
        public string DateToCapture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsProcessingInformationCaptureOptions {\n");
            sb.Append("  CaptureSequenceNumber: ").Append(CaptureSequenceNumber).Append("\n");
            sb.Append("  TotalCaptureCount: ").Append(TotalCaptureCount).Append("\n");
            sb.Append("  DateToCapture: ").Append(DateToCapture).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsProcessingInformationCaptureOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsProcessingInformationCaptureOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsProcessingInformationCaptureOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsProcessingInformationCaptureOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CaptureSequenceNumber == other.CaptureSequenceNumber ||
                    this.CaptureSequenceNumber != null &&
                    this.CaptureSequenceNumber.Equals(other.CaptureSequenceNumber)
                ) && 
                (
                    this.TotalCaptureCount == other.TotalCaptureCount ||
                    this.TotalCaptureCount != null &&
                    this.TotalCaptureCount.Equals(other.TotalCaptureCount)
                ) && 
                (
                    this.DateToCapture == other.DateToCapture ||
                    this.DateToCapture != null &&
                    this.DateToCapture.Equals(other.DateToCapture)
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
                if (this.CaptureSequenceNumber != null)
                    hash = hash * 59 + this.CaptureSequenceNumber.GetHashCode();
                if (this.TotalCaptureCount != null)
                    hash = hash * 59 + this.TotalCaptureCount.GetHashCode();
                if (this.DateToCapture != null)
                    hash = hash * 59 + this.DateToCapture.GetHashCode();
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
            // CaptureSequenceNumber (int?) maximum
            if(this.CaptureSequenceNumber > (int?)99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CaptureSequenceNumber, must be a value less than or equal to 99.", new [] { "CaptureSequenceNumber" });
            }

            // CaptureSequenceNumber (int?) minimum
            if(this.CaptureSequenceNumber < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CaptureSequenceNumber, must be a value greater than or equal to 1.", new [] { "CaptureSequenceNumber" });
            }

            // TotalCaptureCount (int?) maximum
            if(this.TotalCaptureCount > (int?)99)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalCaptureCount, must be a value less than or equal to 99.", new [] { "TotalCaptureCount" });
            }

            // TotalCaptureCount (int?) minimum
            if(this.TotalCaptureCount < (int?)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalCaptureCount, must be a value greater than or equal to 1.", new [] { "TotalCaptureCount" });
            }

            yield break;
        }
    }

}
