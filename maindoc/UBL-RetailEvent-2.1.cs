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
    /// <para>DictionaryEntryName: Retail Event. Details</para>
    /// <para>Definition: A document used to specify basic information about retail events (such as promotions, product introductions, and community or environmental events) that affect supply or demand.</para>
    /// <para>ObjectClass: Retail Event</para>
    /// <para>AlternativeBusinessTerms: Event</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("RetailEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RetailEvent-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("RetailEvent", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:RetailEvent-2", IsNullable=false)]
#endif
    public partial class RetailEventType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// <para>AlternativeBusinessTerms: Retail Event Date</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. Retail Event Name. Name</para>
        /// <para>Definition: A title, theme, slogan, or other identifier for the event for use by trading partners.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Retail Event Name</para>
        /// <para>RepresentationTerm: Name</para>
        /// <para>DataType: Name. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public NameType RetailEventName { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. Retail Event Status Code. Code</para>
        /// <para>Definition: Describes the logical state of the discrete activity affecting supply or demand in the supply chain</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Retail Event Status Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType RetailEventStatusCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. Seller Event Identifier. Identifier</para>
        /// <para>Definition: An event tracking identifier assigned by the seller.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Seller Event Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType SellerEventID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. Buyer Event Identifier. Identifier</para>
        /// <para>Definition: An event tracking identifier assigned by the buyer.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Buyer Event Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType BuyerEventID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Retail Event. Description. Text</para>
        /// <para>Definition: Definition of the discrete activity affecting supply or demand in the supply chain</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Description</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Description", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Description { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Period</para>
        /// <para>Definition: The period during which the event takes place.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType Period { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Original_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to a Forecast document associated with this event.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTermQualifier: Original</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OriginalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] OriginalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Sender_ Party. Party</para>
        /// <para>Definition: The party sending this document.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTermQualifier: Sender</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType SenderParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Receiver_ Party. Party</para>
        /// <para>Definition: The party receiving this document.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTermQualifier: Receiver</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ReceiverParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Buyer_ Customer Party. Customer Party</para>
        /// <para>Definition: The buyer.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTermQualifier: Buyer</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType BuyerCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Seller_ Supplier Party. Supplier Party</para>
        /// <para>Definition: The seller.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTermQualifier: Seller</para>
        /// <para>PropertyTerm: Supplier Party</para>
        /// <para>AssociatedObjectClass: Supplier Party</para>
        /// <para>RepresentationTerm: Supplier Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SupplierPartyType SellerSupplierParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Event Comment</para>
        /// <para>Definition: A comment regarding the event.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Event Comment</para>
        /// <para>AssociatedObjectClass: Event Comment</para>
        /// <para>RepresentationTerm: Event Comment</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("EventComment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public EventCommentType[] EventComment { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Promotional Event</para>
        /// <para>Definition: The description of a promotional event associated with this event.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Promotional Event</para>
        /// <para>AssociatedObjectClass: Promotional Event</para>
        /// <para>RepresentationTerm: Promotional Event</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PromotionalEventType PromotionalEvent { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Retail Event. Miscellaneous Event</para>
        /// <para>Definition: A miscellaneous event associated with this event.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Retail Event</para>
        /// <para>PropertyTerm: Miscellaneous Event</para>
        /// <para>AssociatedObjectClass: Miscellaneous Event</para>
        /// <para>RepresentationTerm: Miscellaneous Event</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public MiscellaneousEventType MiscellaneousEvent { get; set; }
    }
}
