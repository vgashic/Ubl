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
    /// <para>DictionaryEntryName: Despatch Advice. Details</para>
    /// <para>Definition: A document used to describe the despatch or delivery of goods and services.</para>
    /// <para>ObjectClass: Despatch Advice</para>
    /// <para>AlternativeBusinessTerms: Ship Note, Dispatch Advice, Consignment Note</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("DespatchAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("DespatchAdvice", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:DespatchAdvice-2", IsNullable=false)]
#endif
    public partial class DespatchAdviceType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Despatch Advice. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Despatch Advice. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Despatch Advice. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Despatch Advice. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Despatch Advice. Document Status Code. Code</para>
        /// <para>Definition: A code signifying the status of the Despatch Advice with respect to its original state. This code may be used if the document precedes the event and is subsequently found to be incorrect and in need of cancellation or revision.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Document Status Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Document Status</para>
        /// <para>DataType: Document Status_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentStatusCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Despatch Advice. Despatch Advice Type Code. Code</para>
        /// <para>Definition: A code signifying the type of the Despatch Advice.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Despatch Advice Type Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DespatchAdviceTypeCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Despatch Advice. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Despatch Advice. Line Count. Numeric</para>
        /// <para>Definition: The number of Despatch Lines in this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Line Count</para>
        /// <para>RepresentationTerm: Numeric</para>
        /// <para>DataType: Numeric. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NumericType LineCountNumeric { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Order Reference</para>
        /// <para>Definition: A reference to an Order with which this Despatch Advice is associated.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Order Reference</para>
        /// <para>AssociatedObjectClass: Order Reference</para>
        /// <para>RepresentationTerm: Order Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OrderReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public OrderReferenceType[] OrderReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Additional_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an additional document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTermQualifier: Additional</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Despatch_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The despatch party.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTermQualifier: Despatch</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType DespatchSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Delivery_ Customer Party. Customer Party</para>
        /// <para>Definition: The delivery recipient.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTermQualifier: Delivery</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType DeliveryCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Buyer_ Customer Party. Customer Party</para>
        /// <para>Definition: The buyer.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTermQualifier: Buyer</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Seller_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The seller.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTermQualifier: Seller</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Originator_ Customer Party. Customer Party</para>
        /// <para>Definition: A customer party as originator.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTermQualifier: Originator</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType OriginatorCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Shipment</para>
        /// <para>Definition: The shipment.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Shipment</para>
        /// <para>AssociatedObjectClass: Shipment</para>
        /// <para>RepresentationTerm: Shipment</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ShipmentType Shipment { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Despatch Advice. Despatch Line</para>
        /// <para>Definition: A Despatch Line associated with a kind of item delivered.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Despatch Advice</para>
        /// <para>PropertyTerm: Despatch Line</para>
        /// <para>AssociatedObjectClass: Despatch Line</para>
        /// <para>RepresentationTerm: Despatch Line</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DespatchLine", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DespatchLineType[] DespatchLine { get; set; }
    }
}
