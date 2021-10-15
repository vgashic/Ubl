// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
//
//     https://github.com/Gammern/ubllarsen
//     
// </auto-generated>
//------------------------------------------------------------------------------
namespace GMI.Custom.Gmi_Sr.Ubl2
{
    using Cac;
    using Udt;
    
    
    /// <summary>
    /// ComponentType: ABIE
    /// <para>DictionaryEntryName: Remittance Advice. Details</para>
    /// <para>Definition: A document that specifies details of an actual payment.</para>
    /// <para>ObjectClass: Remittance Advice</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("RemittanceAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RemittanceAdvice-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("RemittanceAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RemittanceAdvice-2", IsNullable=false)]
#endif
    public partial class RemittanceAdviceType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Document_ Currency Code. Code</para>
        /// <para>Definition: A code signifying the default currency for this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Document</para>
        /// <para>PropertyTerm: Currency Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Currency</para>
        /// <para>DataType: Currency_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentCurrencyCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Total_ Debit Amount. Amount</para>
        /// <para>Definition: The totals of all debit amounts for the Remittance Advice.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Total</para>
        /// <para>PropertyTerm: Debit Amount</para>
        /// <para>RepresentationTerm: Amount</para>
        /// <para>DataType: Amount. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TotalDebitAmount { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Total_ Credit Amount. Amount</para>
        /// <para>Definition: The totals of all credit amounts for the Remittance Advice.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Total</para>
        /// <para>PropertyTerm: Credit Amount</para>
        /// <para>RepresentationTerm: Amount</para>
        /// <para>DataType: Amount. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TotalCreditAmount { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Total_ Payment Amount. Amount</para>
        /// <para>Definition: The total payable amount for the Remittance Advice (must be positive).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Total</para>
        /// <para>PropertyTerm: Payment Amount</para>
        /// <para>RepresentationTerm: Amount</para>
        /// <para>DataType: Amount. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType TotalPaymentAmount { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Payment Order Reference. Text</para>
        /// <para>Definition: An internal reference to the order for payment from the payer to the payer's bank.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Payment Order Reference</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PaymentOrderReference { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Payer_ Reference. Text</para>
        /// <para>Definition: An internal reference to the payer's order for payment.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Payer</para>
        /// <para>PropertyTerm: Reference</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType PayerReference { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Invoicing Party_ Reference. Text</para>
        /// <para>Definition: An internal reference to the order for payment by the invoicing party. This may have been requested of the payer by the payee to accompany the payer's remittance.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Invoicing Party</para>
        /// <para>PropertyTerm: Reference</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType InvoicingPartyReference { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Remittance Advice. Line Count. Numeric</para>
        /// <para>Definition: The number of Remittance Advice Lines in the document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Line Count</para>
        /// <para>RepresentationTerm: Numeric</para>
        /// <para>DataType: Numeric. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType LineCountNumeric { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Invoice_ Period. Period</para>
        /// <para>Definition: A period (rather than a specific invoice) associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Invoice</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] InvoicePeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Billing Reference</para>
        /// <para>Definition: A reference to a billing document associated with this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Billing Reference</para>
        /// <para>AssociatedObjectClass: Billing Reference</para>
        /// <para>RepresentationTerm: Billing Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public BillingReferenceType BillingReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Additional_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an additional document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Additional</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Accounting_ Customer Party. Customer Party</para>
        /// <para>Definition: The accounting customer party.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Accounting</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType AccountingCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Accounting_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The accounting supplier party.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Accounting</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType AccountingSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Payee_ Party. Party</para>
        /// <para>Definition: The payee.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTermQualifier: Payee</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType PayeeParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Payment Means</para>
        /// <para>Definition: Expected means of payment.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Payment Means</para>
        /// <para>AssociatedObjectClass: Payment Means</para>
        /// <para>RepresentationTerm: Payment Means</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PaymentMeansType PaymentMeans { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Tax Total</para>
        /// <para>Definition: The total amount of a specific type of tax.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Tax Total</para>
        /// <para>AssociatedObjectClass: Tax Total</para>
        /// <para>RepresentationTerm: Tax Total</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TaxTotal", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TaxTotalType[] TaxTotal { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Remittance Advice. Remittance Advice Line</para>
        /// <para>Definition: A line specifying a balance.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Remittance Advice</para>
        /// <para>PropertyTerm: Remittance Advice Line</para>
        /// <para>AssociatedObjectClass: Remittance Advice Line</para>
        /// <para>RepresentationTerm: Remittance Advice Line</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("RemittanceAdviceLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public RemittanceAdviceLineType[] RemittanceAdviceLine { get; set; }
    }
}
