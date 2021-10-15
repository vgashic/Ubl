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
    /// <para>DictionaryEntryName: Guarantee Certificate. Details</para>
    /// <para>Definition: A document to notify the deposit of a bid bond guarantee.</para>
    /// <para>ObjectClass: Guarantee Certificate</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("GuaranteeCertificate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GuaranteeCertificate-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("GuaranteeCertificate", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:GuaranteeCertificate-2", IsNullable=false)]
#endif
    public partial class GuaranteeCertificateType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Contract Folder Identifier. Identifier</para>
        /// <para>Definition: An identifier, assigned by the sender, for the process file (i.e., record) to which this document belongs.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Contract Folder Identifier</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType ContractFolderID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Guarantee Type Code. Code</para>
        /// <para>Definition: A code signifying the type of the guarantee.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Guarantee Type Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType GuaranteeTypeCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Purpose. Text</para>
        /// <para>Definition: A textual description of the purpose of the bid bond guarantee.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Purpose</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Purpose", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Purpose { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Liability. Amount</para>
        /// <para>Definition: The liability amount (a monetary value) in the bid bond guarantee.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Liability</para>
        /// <para>RepresentationTerm: Amount</para>
        /// <para>DataType: Amount. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public AmountType LiabilityAmount { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Constitution Code. Code</para>
        /// <para>Definition: The code stating the constitution means of the guarantee.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Constitution Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType ConstitutionCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Applicable_ Period. Period</para>
        /// <para>Definition: The specified period in the tendering process for which this bid bond guarantee is effective</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTermQualifier: Applicable</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType ApplicablePeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Applicable_ Regulation. Regulation</para>
        /// <para>Definition: A reference to an applicable regulation.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTermQualifier: Applicable</para>
        /// <para>PropertyTerm: Regulation</para>
        /// <para>AssociatedObjectClass: Regulation</para>
        /// <para>RepresentationTerm: Regulation</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ApplicableRegulation", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public RegulationType[] ApplicableRegulation { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Guarantee_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to a legal document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTermQualifier: Guarantee</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("GuaranteeDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] GuaranteeDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Immobilized Security</para>
        /// <para>Definition: Details of an immobilized security.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Immobilized Security</para>
        /// <para>AssociatedObjectClass: Immobilized Security</para>
        /// <para>RepresentationTerm: Immobilized Security</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ImmobilizedSecurity", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ImmobilizedSecurityType[] ImmobilizedSecurity { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Guarantor_ Party. Party</para>
        /// <para>Definition: The guarantee creditor organization that has the authority to charge bid bond guarantee credit.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTermQualifier: Guarantor</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType GuarantorParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Interested_ Party. Party</para>
        /// <para>Definition: The party depositing the bid bond guarantee.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTermQualifier: Interested</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType InterestedParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Guarantee Certificate. Beneficiary_ Party. Party</para>
        /// <para>Definition: The beneficiary of the bid bond guarantee.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Guarantee Certificate</para>
        /// <para>PropertyTermQualifier: Beneficiary</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType BeneficiaryParty { get; set; }
    }
}