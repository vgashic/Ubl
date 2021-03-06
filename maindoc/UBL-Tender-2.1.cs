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
    /// <para>DictionaryEntryName: Tender. Details</para>
    /// <para>Definition: A document whereby an economic operator (the tenderer) makes a formal offer (the tender) to a contracting authority to execute an order for the supply or purchase of goods, or for the execution of work, according to the terms of a proposed contract.</para>
    /// <para>ObjectClass: Tender</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("Tender", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Tender-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("Tender", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:Tender-2", IsNullable=false)]
#endif
    public partial class TenderType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Tender. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Tender. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Tender. Tender Type Code. Code</para>
        /// <para>Definition: A code to specify the type of tender (economical or objective criteria versus technical or subjective criteria)</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Tender Type Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType TenderTypeCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Tender. Contract Folder Identifier. Identifier</para>
        /// <para>Definition: An identifier, assigned by the sender, for the process file (i.e., record) to which this document belongs.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Contract Folder Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ContractFolderID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Tender. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Tender. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Tender. Contract Name. Text</para>
        /// <para>Definition: Short title of a contract associated with this Tender.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Contract Name</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ContractName", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] ContractName { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Tender. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Tender. Validity_ Period. Period</para>
        /// <para>Definition: The period for which the Tender is valid.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTermQualifier: Validity</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType ValidityPeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Tender. Document Reference</para>
        /// <para>Definition: A reference to another document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] DocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Tender. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Tender. Tenderer_ Party. Party</para>
        /// <para>Definition: The primary tenderer.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTermQualifier: Tenderer</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TendererParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Tender. Tenderer Qualification_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to the tenderer qualification document that has been used to qualify the tenderer.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTermQualifier: Tenderer Qualification</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType TendererQualificationDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Tender. Subcontractor_ Party. Party</para>
        /// <para>Definition: A subcontractor or other tenderer participating in the same Tender.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTermQualifier: Subcontractor</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("SubcontractorParty", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType[] SubcontractorParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Tender. Contracting Party</para>
        /// <para>Definition: The contracting party.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Contracting Party</para>
        /// <para>AssociatedObjectClass: Contracting Party</para>
        /// <para>RepresentationTerm: Contracting Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ContractingPartyType ContractingParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Tender. Originator_ Customer Party. Customer Party</para>
        /// <para>Definition: The party originating the Tender.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTermQualifier: Originator</para>
        /// <para>PropertyTerm: Customer Party</para>
        /// <para>AssociatedObjectClass: Customer Party</para>
        /// <para>RepresentationTerm: Customer Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public CustomerPartyType OriginatorCustomerParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Tender. Tendered Project</para>
        /// <para>Definition: A project with which this Tender is associated. A single Tender can be used to bid for one project, multiple projects, or the global project.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Tender</para>
        /// <para>PropertyTerm: Tendered Project</para>
        /// <para>AssociatedObjectClass: Tendered Project</para>
        /// <para>RepresentationTerm: Tendered Project</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TenderedProject", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TenderedProjectType[] TenderedProject { get; set; }
    }
}
