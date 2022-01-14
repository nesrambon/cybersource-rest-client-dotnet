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
    /// Ptsv2paymentsOrderInformationInvoiceDetails
    /// </summary>
    [DataContract]
    public partial class Ptsv2paymentsOrderInformationInvoiceDetails :  IEquatable<Ptsv2paymentsOrderInformationInvoiceDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2paymentsOrderInformationInvoiceDetails" /> class.
        /// </summary>
        /// <param name="InvoiceNumber">Invoice Number..</param>
        /// <param name="BarcodeNumber">Barcode Number..</param>
        /// <param name="ExpirationDate">Expiration Date..</param>
        /// <param name="PurchaseOrderNumber">Value used by your customer to identify the order. This value is typically a purchase order number. CyberSource recommends that you do not populate the field with all zeros or nines.  For processor-specific information, see the &#x60;user_po&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="PurchaseOrderDate">Date the order was processed. &#x60;Format: YYYY-MM-DD&#x60;.  For processor-specific information, see the &#x60;purchaser_order_date&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="PurchaseContactName">The name of the individual or the company contacted for company authorized purchases.  For processor-specific information, see the &#x60;authorized_contact_name&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="Taxable">Flag that indicates whether an order is taxable. This value must be true if the sum of all _lineItems[].taxAmount_ values &gt; 0.  If you do not include any &#x60;lineItems[].taxAmount&#x60; values in your request, CyberSource does not include &#x60;invoiceDetails.taxable&#x60; in the data it sends to the processor.  For processor-specific information, see the &#x60;tax_indicator&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html)  Possible values:  - **true**  - **false** .</param>
        /// <param name="VatInvoiceReferenceNumber">VAT invoice number associated with the transaction.  For processor-specific information, see the &#x60;vat_invoice_ref_number&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="CommodityCode">International description code of the overall order’s goods or services or the Categorizes purchases for VAT reporting. Contact your acquirer for a list of codes.  For processor-specific information, see the &#x60;summary_commodity_code&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) .</param>
        /// <param name="MerchandiseCode">Identifier for the merchandise. This field is supported only on the processors listed in this field description.  #### American Express Direct Possible value: - 1000: Gift card  #### CyberSource through VisaNet This value must be right justified. In Japan, this value is called a _goods code_.  #### JCN Gateway This value must be right justified. In Japan, this value is called a _goods code_. .</param>
        /// <param name="TransactionAdviceAddendum">TransactionAdviceAddendum.</param>
        /// <param name="ReferenceDataCode">Code that identifies the value of the &#x60;referenceDataNumber&#x60; field.  For the possible values, see \&quot;Reference Data Codes\&quot; in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/).  This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. .</param>
        /// <param name="ReferenceDataNumber">Reference number. The meaning of this value is identified by the value of the &#x60;referenceDataCode&#x60; field.  This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. .</param>
        /// <param name="SalesSlipNumber">Transaction identifier that is generated. You have the option of printing the sales slip number on the receipt. This field is supported only on Cybersource through Visanet and JCN gateway.  Optional field.  #### Card Present processing message If you included this field in the request, the returned value is the value that you sent in the request. If you did not include this field in the request, the system generated this value for you.  The difference between this reply field and the &#x60;processorInformation.systemTraceAuditNumber&#x60; field is that the system generates the system trace audit number (STAN), and you must print the receipt number on the receipt; whereas you can generate the sales slip number, and you can choose to print the sales slip number on the receipt. .</param>
        /// <param name="InvoiceDate">Date of the tax calculation. Use format YYYYMMDD. You can provide a date in the past if you are calculating tax for a refund and want to know what the tax was on the date the order was placed. You can provide a date in the future if you are calculating the tax for a future date, such as an upcoming tax holiday.  The default is the date, in Pacific time, that the bank receives the request. Keep this in mind if you are in a different time zone and want the tax calculated with the rates that are applicable on a specific date.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. .</param>
        public Ptsv2paymentsOrderInformationInvoiceDetails(string InvoiceNumber = default(string), string BarcodeNumber = default(string), string ExpirationDate = default(string), string PurchaseOrderNumber = default(string), string PurchaseOrderDate = default(string), string PurchaseContactName = default(string), bool? Taxable = default(bool?), string VatInvoiceReferenceNumber = default(string), string CommodityCode = default(string), int? MerchandiseCode = default(int?), List<Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum> TransactionAdviceAddendum = default(List<Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum>), string ReferenceDataCode = default(string), string ReferenceDataNumber = default(string), int? SalesSlipNumber = default(int?), string InvoiceDate = default(string))
        {
            this.InvoiceNumber = InvoiceNumber;
            this.BarcodeNumber = BarcodeNumber;
            this.ExpirationDate = ExpirationDate;
            this.PurchaseOrderNumber = PurchaseOrderNumber;
            this.PurchaseOrderDate = PurchaseOrderDate;
            this.PurchaseContactName = PurchaseContactName;
            this.Taxable = Taxable;
            this.VatInvoiceReferenceNumber = VatInvoiceReferenceNumber;
            this.CommodityCode = CommodityCode;
            this.MerchandiseCode = MerchandiseCode;
            this.TransactionAdviceAddendum = TransactionAdviceAddendum;
            this.ReferenceDataCode = ReferenceDataCode;
            this.ReferenceDataNumber = ReferenceDataNumber;
            this.SalesSlipNumber = SalesSlipNumber;
            this.InvoiceDate = InvoiceDate;
        }
        
        /// <summary>
        /// Invoice Number.
        /// </summary>
        /// <value>Invoice Number.</value>
        [DataMember(Name="invoiceNumber", EmitDefaultValue=false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Barcode Number.
        /// </summary>
        /// <value>Barcode Number.</value>
        [DataMember(Name="barcodeNumber", EmitDefaultValue=false)]
        public string BarcodeNumber { get; set; }

        /// <summary>
        /// Expiration Date.
        /// </summary>
        /// <value>Expiration Date.</value>
        [DataMember(Name="expirationDate", EmitDefaultValue=false)]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// Value used by your customer to identify the order. This value is typically a purchase order number. CyberSource recommends that you do not populate the field with all zeros or nines.  For processor-specific information, see the &#x60;user_po&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Value used by your customer to identify the order. This value is typically a purchase order number. CyberSource recommends that you do not populate the field with all zeros or nines.  For processor-specific information, see the &#x60;user_po&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="purchaseOrderNumber", EmitDefaultValue=false)]
        public string PurchaseOrderNumber { get; set; }

        /// <summary>
        /// Date the order was processed. &#x60;Format: YYYY-MM-DD&#x60;.  For processor-specific information, see the &#x60;purchaser_order_date&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>Date the order was processed. &#x60;Format: YYYY-MM-DD&#x60;.  For processor-specific information, see the &#x60;purchaser_order_date&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="purchaseOrderDate", EmitDefaultValue=false)]
        public string PurchaseOrderDate { get; set; }

        /// <summary>
        /// The name of the individual or the company contacted for company authorized purchases.  For processor-specific information, see the &#x60;authorized_contact_name&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>The name of the individual or the company contacted for company authorized purchases.  For processor-specific information, see the &#x60;authorized_contact_name&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="purchaseContactName", EmitDefaultValue=false)]
        public string PurchaseContactName { get; set; }

        /// <summary>
        /// Flag that indicates whether an order is taxable. This value must be true if the sum of all _lineItems[].taxAmount_ values &gt; 0.  If you do not include any &#x60;lineItems[].taxAmount&#x60; values in your request, CyberSource does not include &#x60;invoiceDetails.taxable&#x60; in the data it sends to the processor.  For processor-specific information, see the &#x60;tax_indicator&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html)  Possible values:  - **true**  - **false** 
        /// </summary>
        /// <value>Flag that indicates whether an order is taxable. This value must be true if the sum of all _lineItems[].taxAmount_ values &gt; 0.  If you do not include any &#x60;lineItems[].taxAmount&#x60; values in your request, CyberSource does not include &#x60;invoiceDetails.taxable&#x60; in the data it sends to the processor.  For processor-specific information, see the &#x60;tax_indicator&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html)  Possible values:  - **true**  - **false** </value>
        [DataMember(Name="taxable", EmitDefaultValue=false)]
        public bool? Taxable { get; set; }

        /// <summary>
        /// VAT invoice number associated with the transaction.  For processor-specific information, see the &#x60;vat_invoice_ref_number&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>VAT invoice number associated with the transaction.  For processor-specific information, see the &#x60;vat_invoice_ref_number&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="vatInvoiceReferenceNumber", EmitDefaultValue=false)]
        public string VatInvoiceReferenceNumber { get; set; }

        /// <summary>
        /// International description code of the overall order’s goods or services or the Categorizes purchases for VAT reporting. Contact your acquirer for a list of codes.  For processor-specific information, see the &#x60;summary_commodity_code&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) 
        /// </summary>
        /// <value>International description code of the overall order’s goods or services or the Categorizes purchases for VAT reporting. Contact your acquirer for a list of codes.  For processor-specific information, see the &#x60;summary_commodity_code&#x60; field in [Level II and Level III Processing Using the SCMP API.](http://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html) </value>
        [DataMember(Name="commodityCode", EmitDefaultValue=false)]
        public string CommodityCode { get; set; }

        /// <summary>
        /// Identifier for the merchandise. This field is supported only on the processors listed in this field description.  #### American Express Direct Possible value: - 1000: Gift card  #### CyberSource through VisaNet This value must be right justified. In Japan, this value is called a _goods code_.  #### JCN Gateway This value must be right justified. In Japan, this value is called a _goods code_. 
        /// </summary>
        /// <value>Identifier for the merchandise. This field is supported only on the processors listed in this field description.  #### American Express Direct Possible value: - 1000: Gift card  #### CyberSource through VisaNet This value must be right justified. In Japan, this value is called a _goods code_.  #### JCN Gateway This value must be right justified. In Japan, this value is called a _goods code_. </value>
        [DataMember(Name="merchandiseCode", EmitDefaultValue=false)]
        public int? MerchandiseCode { get; set; }

        /// <summary>
        /// Gets or Sets TransactionAdviceAddendum
        /// </summary>
        [DataMember(Name="transactionAdviceAddendum", EmitDefaultValue=false)]
        public List<Ptsv2paymentsOrderInformationInvoiceDetailsTransactionAdviceAddendum> TransactionAdviceAddendum { get; set; }

        /// <summary>
        /// Code that identifies the value of the &#x60;referenceDataNumber&#x60; field.  For the possible values, see \&quot;Reference Data Codes\&quot; in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/).  This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. 
        /// </summary>
        /// <value>Code that identifies the value of the &#x60;referenceDataNumber&#x60; field.  For the possible values, see \&quot;Reference Data Codes\&quot; in [Level II and Level III Processing Using the SCMP API.](https://apps.cybersource.com/library/documentation/dev_guides/Level_2_3_SCMP_API/html/).  This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. </value>
        [DataMember(Name="referenceDataCode", EmitDefaultValue=false)]
        public string ReferenceDataCode { get; set; }

        /// <summary>
        /// Reference number. The meaning of this value is identified by the value of the &#x60;referenceDataCode&#x60; field.  This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. 
        /// </summary>
        /// <value>Reference number. The meaning of this value is identified by the value of the &#x60;referenceDataCode&#x60; field.  This field is a pass-through, which means that CyberSource does not verify the value or modify it in any way before sending it to the processor. </value>
        [DataMember(Name="referenceDataNumber", EmitDefaultValue=false)]
        public string ReferenceDataNumber { get; set; }

        /// <summary>
        /// Transaction identifier that is generated. You have the option of printing the sales slip number on the receipt. This field is supported only on Cybersource through Visanet and JCN gateway.  Optional field.  #### Card Present processing message If you included this field in the request, the returned value is the value that you sent in the request. If you did not include this field in the request, the system generated this value for you.  The difference between this reply field and the &#x60;processorInformation.systemTraceAuditNumber&#x60; field is that the system generates the system trace audit number (STAN), and you must print the receipt number on the receipt; whereas you can generate the sales slip number, and you can choose to print the sales slip number on the receipt. 
        /// </summary>
        /// <value>Transaction identifier that is generated. You have the option of printing the sales slip number on the receipt. This field is supported only on Cybersource through Visanet and JCN gateway.  Optional field.  #### Card Present processing message If you included this field in the request, the returned value is the value that you sent in the request. If you did not include this field in the request, the system generated this value for you.  The difference between this reply field and the &#x60;processorInformation.systemTraceAuditNumber&#x60; field is that the system generates the system trace audit number (STAN), and you must print the receipt number on the receipt; whereas you can generate the sales slip number, and you can choose to print the sales slip number on the receipt. </value>
        [DataMember(Name="salesSlipNumber", EmitDefaultValue=false)]
        public int? SalesSlipNumber { get; set; }

        /// <summary>
        /// Date of the tax calculation. Use format YYYYMMDD. You can provide a date in the past if you are calculating tax for a refund and want to know what the tax was on the date the order was placed. You can provide a date in the future if you are calculating the tax for a future date, such as an upcoming tax holiday.  The default is the date, in Pacific time, that the bank receives the request. Keep this in mind if you are in a different time zone and want the tax calculated with the rates that are applicable on a specific date.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. 
        /// </summary>
        /// <value>Date of the tax calculation. Use format YYYYMMDD. You can provide a date in the past if you are calculating tax for a refund and want to know what the tax was on the date the order was placed. You can provide a date in the future if you are calculating the tax for a future date, such as an upcoming tax holiday.  The default is the date, in Pacific time, that the bank receives the request. Keep this in mind if you are in a different time zone and want the tax calculated with the rates that are applicable on a specific date.  #### Tax Calculation Optional field for U.S., Canadian, international tax, and value added taxes. </value>
        [DataMember(Name="invoiceDate", EmitDefaultValue=false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2paymentsOrderInformationInvoiceDetails {\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  BarcodeNumber: ").Append(BarcodeNumber).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  PurchaseOrderNumber: ").Append(PurchaseOrderNumber).Append("\n");
            sb.Append("  PurchaseOrderDate: ").Append(PurchaseOrderDate).Append("\n");
            sb.Append("  PurchaseContactName: ").Append(PurchaseContactName).Append("\n");
            sb.Append("  Taxable: ").Append(Taxable).Append("\n");
            sb.Append("  VatInvoiceReferenceNumber: ").Append(VatInvoiceReferenceNumber).Append("\n");
            sb.Append("  CommodityCode: ").Append(CommodityCode).Append("\n");
            sb.Append("  MerchandiseCode: ").Append(MerchandiseCode).Append("\n");
            sb.Append("  TransactionAdviceAddendum: ").Append(TransactionAdviceAddendum).Append("\n");
            sb.Append("  ReferenceDataCode: ").Append(ReferenceDataCode).Append("\n");
            sb.Append("  ReferenceDataNumber: ").Append(ReferenceDataNumber).Append("\n");
            sb.Append("  SalesSlipNumber: ").Append(SalesSlipNumber).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
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
            return this.Equals(obj as Ptsv2paymentsOrderInformationInvoiceDetails);
        }

        /// <summary>
        /// Returns true if Ptsv2paymentsOrderInformationInvoiceDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2paymentsOrderInformationInvoiceDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2paymentsOrderInformationInvoiceDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.InvoiceNumber == other.InvoiceNumber ||
                    this.InvoiceNumber != null &&
                    this.InvoiceNumber.Equals(other.InvoiceNumber)
                ) && 
                (
                    this.BarcodeNumber == other.BarcodeNumber ||
                    this.BarcodeNumber != null &&
                    this.BarcodeNumber.Equals(other.BarcodeNumber)
                ) && 
                (
                    this.ExpirationDate == other.ExpirationDate ||
                    this.ExpirationDate != null &&
                    this.ExpirationDate.Equals(other.ExpirationDate)
                ) && 
                (
                    this.PurchaseOrderNumber == other.PurchaseOrderNumber ||
                    this.PurchaseOrderNumber != null &&
                    this.PurchaseOrderNumber.Equals(other.PurchaseOrderNumber)
                ) && 
                (
                    this.PurchaseOrderDate == other.PurchaseOrderDate ||
                    this.PurchaseOrderDate != null &&
                    this.PurchaseOrderDate.Equals(other.PurchaseOrderDate)
                ) && 
                (
                    this.PurchaseContactName == other.PurchaseContactName ||
                    this.PurchaseContactName != null &&
                    this.PurchaseContactName.Equals(other.PurchaseContactName)
                ) && 
                (
                    this.Taxable == other.Taxable ||
                    this.Taxable != null &&
                    this.Taxable.Equals(other.Taxable)
                ) && 
                (
                    this.VatInvoiceReferenceNumber == other.VatInvoiceReferenceNumber ||
                    this.VatInvoiceReferenceNumber != null &&
                    this.VatInvoiceReferenceNumber.Equals(other.VatInvoiceReferenceNumber)
                ) && 
                (
                    this.CommodityCode == other.CommodityCode ||
                    this.CommodityCode != null &&
                    this.CommodityCode.Equals(other.CommodityCode)
                ) && 
                (
                    this.MerchandiseCode == other.MerchandiseCode ||
                    this.MerchandiseCode != null &&
                    this.MerchandiseCode.Equals(other.MerchandiseCode)
                ) && 
                (
                    this.TransactionAdviceAddendum == other.TransactionAdviceAddendum ||
                    this.TransactionAdviceAddendum != null &&
                    this.TransactionAdviceAddendum.SequenceEqual(other.TransactionAdviceAddendum)
                ) && 
                (
                    this.ReferenceDataCode == other.ReferenceDataCode ||
                    this.ReferenceDataCode != null &&
                    this.ReferenceDataCode.Equals(other.ReferenceDataCode)
                ) && 
                (
                    this.ReferenceDataNumber == other.ReferenceDataNumber ||
                    this.ReferenceDataNumber != null &&
                    this.ReferenceDataNumber.Equals(other.ReferenceDataNumber)
                ) && 
                (
                    this.SalesSlipNumber == other.SalesSlipNumber ||
                    this.SalesSlipNumber != null &&
                    this.SalesSlipNumber.Equals(other.SalesSlipNumber)
                ) && 
                (
                    this.InvoiceDate == other.InvoiceDate ||
                    this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(other.InvoiceDate)
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
                if (this.InvoiceNumber != null)
                    hash = hash * 59 + this.InvoiceNumber.GetHashCode();
                if (this.BarcodeNumber != null)
                    hash = hash * 59 + this.BarcodeNumber.GetHashCode();
                if (this.ExpirationDate != null)
                    hash = hash * 59 + this.ExpirationDate.GetHashCode();
                if (this.PurchaseOrderNumber != null)
                    hash = hash * 59 + this.PurchaseOrderNumber.GetHashCode();
                if (this.PurchaseOrderDate != null)
                    hash = hash * 59 + this.PurchaseOrderDate.GetHashCode();
                if (this.PurchaseContactName != null)
                    hash = hash * 59 + this.PurchaseContactName.GetHashCode();
                if (this.Taxable != null)
                    hash = hash * 59 + this.Taxable.GetHashCode();
                if (this.VatInvoiceReferenceNumber != null)
                    hash = hash * 59 + this.VatInvoiceReferenceNumber.GetHashCode();
                if (this.CommodityCode != null)
                    hash = hash * 59 + this.CommodityCode.GetHashCode();
                if (this.MerchandiseCode != null)
                    hash = hash * 59 + this.MerchandiseCode.GetHashCode();
                if (this.TransactionAdviceAddendum != null)
                    hash = hash * 59 + this.TransactionAdviceAddendum.GetHashCode();
                if (this.ReferenceDataCode != null)
                    hash = hash * 59 + this.ReferenceDataCode.GetHashCode();
                if (this.ReferenceDataNumber != null)
                    hash = hash * 59 + this.ReferenceDataNumber.GetHashCode();
                if (this.SalesSlipNumber != null)
                    hash = hash * 59 + this.SalesSlipNumber.GetHashCode();
                if (this.InvoiceDate != null)
                    hash = hash * 59 + this.InvoiceDate.GetHashCode();
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
            // SalesSlipNumber (int?) maximum
            if(this.SalesSlipNumber > (int?)99999)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SalesSlipNumber, must be a value less than or equal to 99999.", new [] { "SalesSlipNumber" });
            }

            yield break;
        }
    }

}
