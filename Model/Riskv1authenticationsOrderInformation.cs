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
    /// Riskv1authenticationsOrderInformation
    /// </summary>
    [DataContract]
    public partial class Riskv1authenticationsOrderInformation :  IEquatable<Riskv1authenticationsOrderInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1authenticationsOrderInformation" /> class.
        /// </summary>
        /// <param name="AmountDetails">AmountDetails.</param>
        /// <param name="PreOrder">Indicates whether cardholder is placing an order with a future availability or release date. This field can contain one of these values: - MERCHANDISE_AVAILABLE: Merchandise available - FUTURE_AVAILABILITY: Future availability .</param>
        /// <param name="PreOrderDate">Expected date that a pre-ordered purchase will be available. Format: YYYYMMDD .</param>
        /// <param name="Reordered">Indicates whether the cardholder is reordering previously purchased merchandise. This field can contain one of these values: - false: First time ordered - true: Reordered .</param>
        /// <param name="ShipTo">ShipTo.</param>
        /// <param name="LineItems">This array contains detailed information about individual products in the order..</param>
        /// <param name="BillTo">BillTo.</param>
        /// <param name="TotalOffersCount">Total number of articles/items in the order as a numeric decimal count. Possible values: 00 - 99 .</param>
        public Riskv1authenticationsOrderInformation(Riskv1authenticationsOrderInformationAmountDetails AmountDetails = default(Riskv1authenticationsOrderInformationAmountDetails), string PreOrder = default(string), string PreOrderDate = default(string), bool? Reordered = default(bool?), Riskv1decisionsOrderInformationShipTo ShipTo = default(Riskv1decisionsOrderInformationShipTo), List<Riskv1authenticationsOrderInformationLineItems> LineItems = default(List<Riskv1authenticationsOrderInformationLineItems>), Riskv1authenticationsOrderInformationBillTo BillTo = default(Riskv1authenticationsOrderInformationBillTo), string TotalOffersCount = default(string))
        {
            this.AmountDetails = AmountDetails;
            this.PreOrder = PreOrder;
            this.PreOrderDate = PreOrderDate;
            this.Reordered = Reordered;
            this.ShipTo = ShipTo;
            this.LineItems = LineItems;
            this.BillTo = BillTo;
            this.TotalOffersCount = TotalOffersCount;
        }
        
        /// <summary>
        /// Gets or Sets AmountDetails
        /// </summary>
        [DataMember(Name="amountDetails", EmitDefaultValue=false)]
        public Riskv1authenticationsOrderInformationAmountDetails AmountDetails { get; set; }

        /// <summary>
        /// Indicates whether cardholder is placing an order with a future availability or release date. This field can contain one of these values: - MERCHANDISE_AVAILABLE: Merchandise available - FUTURE_AVAILABILITY: Future availability 
        /// </summary>
        /// <value>Indicates whether cardholder is placing an order with a future availability or release date. This field can contain one of these values: - MERCHANDISE_AVAILABLE: Merchandise available - FUTURE_AVAILABILITY: Future availability </value>
        [DataMember(Name="preOrder", EmitDefaultValue=false)]
        public string PreOrder { get; set; }

        /// <summary>
        /// Expected date that a pre-ordered purchase will be available. Format: YYYYMMDD 
        /// </summary>
        /// <value>Expected date that a pre-ordered purchase will be available. Format: YYYYMMDD </value>
        [DataMember(Name="preOrderDate", EmitDefaultValue=false)]
        public string PreOrderDate { get; set; }

        /// <summary>
        /// Indicates whether the cardholder is reordering previously purchased merchandise. This field can contain one of these values: - false: First time ordered - true: Reordered 
        /// </summary>
        /// <value>Indicates whether the cardholder is reordering previously purchased merchandise. This field can contain one of these values: - false: First time ordered - true: Reordered </value>
        [DataMember(Name="reordered", EmitDefaultValue=false)]
        public bool? Reordered { get; set; }

        /// <summary>
        /// Gets or Sets ShipTo
        /// </summary>
        [DataMember(Name="shipTo", EmitDefaultValue=false)]
        public Riskv1decisionsOrderInformationShipTo ShipTo { get; set; }

        /// <summary>
        /// This array contains detailed information about individual products in the order.
        /// </summary>
        /// <value>This array contains detailed information about individual products in the order.</value>
        [DataMember(Name="lineItems", EmitDefaultValue=false)]
        public List<Riskv1authenticationsOrderInformationLineItems> LineItems { get; set; }

        /// <summary>
        /// Gets or Sets BillTo
        /// </summary>
        [DataMember(Name="billTo", EmitDefaultValue=false)]
        public Riskv1authenticationsOrderInformationBillTo BillTo { get; set; }

        /// <summary>
        /// Total number of articles/items in the order as a numeric decimal count. Possible values: 00 - 99 
        /// </summary>
        /// <value>Total number of articles/items in the order as a numeric decimal count. Possible values: 00 - 99 </value>
        [DataMember(Name="totalOffersCount", EmitDefaultValue=false)]
        public string TotalOffersCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1authenticationsOrderInformation {\n");
            sb.Append("  AmountDetails: ").Append(AmountDetails).Append("\n");
            sb.Append("  PreOrder: ").Append(PreOrder).Append("\n");
            sb.Append("  PreOrderDate: ").Append(PreOrderDate).Append("\n");
            sb.Append("  Reordered: ").Append(Reordered).Append("\n");
            sb.Append("  ShipTo: ").Append(ShipTo).Append("\n");
            sb.Append("  LineItems: ").Append(LineItems).Append("\n");
            sb.Append("  BillTo: ").Append(BillTo).Append("\n");
            sb.Append("  TotalOffersCount: ").Append(TotalOffersCount).Append("\n");
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
            return this.Equals(obj as Riskv1authenticationsOrderInformation);
        }

        /// <summary>
        /// Returns true if Riskv1authenticationsOrderInformation instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1authenticationsOrderInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1authenticationsOrderInformation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.AmountDetails == other.AmountDetails ||
                    this.AmountDetails != null &&
                    this.AmountDetails.Equals(other.AmountDetails)
                ) && 
                (
                    this.PreOrder == other.PreOrder ||
                    this.PreOrder != null &&
                    this.PreOrder.Equals(other.PreOrder)
                ) && 
                (
                    this.PreOrderDate == other.PreOrderDate ||
                    this.PreOrderDate != null &&
                    this.PreOrderDate.Equals(other.PreOrderDate)
                ) && 
                (
                    this.Reordered == other.Reordered ||
                    this.Reordered != null &&
                    this.Reordered.Equals(other.Reordered)
                ) && 
                (
                    this.ShipTo == other.ShipTo ||
                    this.ShipTo != null &&
                    this.ShipTo.Equals(other.ShipTo)
                ) && 
                (
                    this.LineItems == other.LineItems ||
                    this.LineItems != null &&
                    this.LineItems.SequenceEqual(other.LineItems)
                ) && 
                (
                    this.BillTo == other.BillTo ||
                    this.BillTo != null &&
                    this.BillTo.Equals(other.BillTo)
                ) && 
                (
                    this.TotalOffersCount == other.TotalOffersCount ||
                    this.TotalOffersCount != null &&
                    this.TotalOffersCount.Equals(other.TotalOffersCount)
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
                if (this.AmountDetails != null)
                    hash = hash * 59 + this.AmountDetails.GetHashCode();
                if (this.PreOrder != null)
                    hash = hash * 59 + this.PreOrder.GetHashCode();
                if (this.PreOrderDate != null)
                    hash = hash * 59 + this.PreOrderDate.GetHashCode();
                if (this.Reordered != null)
                    hash = hash * 59 + this.Reordered.GetHashCode();
                if (this.ShipTo != null)
                    hash = hash * 59 + this.ShipTo.GetHashCode();
                if (this.LineItems != null)
                    hash = hash * 59 + this.LineItems.GetHashCode();
                if (this.BillTo != null)
                    hash = hash * 59 + this.BillTo.GetHashCode();
                if (this.TotalOffersCount != null)
                    hash = hash * 59 + this.TotalOffersCount.GetHashCode();
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
