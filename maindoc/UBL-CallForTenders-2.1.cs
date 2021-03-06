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
    /// <para>DictionaryEntryName: Call For Tenders. Details</para>
    /// <para>Definition: A document used by a Contracting Party to define a procurement project to buy goods, services, or works during a specified period.</para>
    /// <para>ObjectClass: Call For Tenders</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("CallForTenders", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("CallForTenders", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CallForTenders-2", IsNullable=false)]
#endif
    public partial class CallForTendersType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Call For Tenders. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Call For Tenders. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Call For Tenders. Contract Folder Identifier. Identifier</para>
        /// <para>Definition: An identifier, assigned by the sender, for the process file (i.e., record) to which this document belongs.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Contract Folder Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ContractFolderID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Call For Tenders. Approval Date. Date</para>
        /// <para>Definition: The date, assigned by the contracting party, on which the Call For Tenders was approved.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Approval Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType ApprovalDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Call For Tenders. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Call For Tenders. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Call For Tenders. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Call For Tenders. Version. Identifier</para>
        /// <para>Definition: Indicates the current version of the Call for Tenders.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Version</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: 1.1</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType VersionID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Call For Tenders. Previous_ Version. Identifier</para>
        /// <para>Definition: Identifies the previous version of the Call for Tenders which is superceded by this version.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTermQualifier: Previous</para>
        /// <para>PropertyTerm: Version</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: 1.0</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType PreviousVersionID { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Legal_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to a legal document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTermQualifier: Legal</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType LegalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Technical_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to a technical document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTermQualifier: Technical</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType TechnicalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Additional_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an additional document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTermQualifier: Additional</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Contracting Party</para>
        /// <para>Definition: The contracting party.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Contracting Party</para>
        /// <para>AssociatedObjectClass: Contracting Party</para>
        /// <para>RepresentationTerm: Contracting Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ContractingPartyType ContractingParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Originator_ Customer Party. Customer Party</para>
        /// <para>Definition: The party who originated Order.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTermQualifier: Originator</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("OriginatorCustomerParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType[] OriginatorCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Receiver_ Party. Party</para>
        /// <para>Definition: The party receiving this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTermQualifier: Receiver</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ReceiverParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Tendering Terms</para>
        /// <para>Definition: The tendering terms associated with this tendering process.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Tendering Terms</para>
        /// <para>AssociatedObjectClass: Tendering Terms</para>
        /// <para>RepresentationTerm: Tendering Terms</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TenderingTermsType TenderingTerms { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Tendering Process</para>
        /// <para>Definition: A description of the tendering process itself.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Tendering Process</para>
        /// <para>AssociatedObjectClass: Tendering Process</para>
        /// <para>RepresentationTerm: Tendering Process</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TenderingProcessType TenderingProcess { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Procurement Project</para>
        /// <para>Definition: An overall definition of this procurement project.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Procurement Project</para>
        /// <para>AssociatedObjectClass: Procurement Project</para>
        /// <para>RepresentationTerm: Procurement Project</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ProcurementProjectType ProcurementProject { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Call For Tenders. Procurement Project Lot</para>
        /// <para>Definition: One of the procurement project lots into which this contract can be split.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Call For Tenders</para>
        /// <para>PropertyTerm: Procurement Project Lot</para>
        /// <para>AssociatedObjectClass: Procurement Project Lot</para>
        /// <para>RepresentationTerm: Procurement Project Lot</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ProcurementProjectLot", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ProcurementProjectLotType[] ProcurementProjectLot { get; set; }
    }
}
