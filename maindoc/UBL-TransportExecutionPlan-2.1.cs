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
    /// <para>DictionaryEntryName: Transport Execution Plan. Details</para>
    /// <para>Definition: A document used in the negotiation of a transport service between a transport user and a transport service provider.</para>
    /// <para>ObjectClass: Transport Execution Plan</para>
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("ublxsd", "2.1.0.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute("TransportExecutionPlan", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlan-2")]
#if USE_UBL_XMLROOTATTRIBUTE
    [System.Xml.Serialization.XmlRootAttribute("TransportExecutionPlan", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:TransportExecutionPlan-2", IsNullable=false)]
#endif
    public partial class TransportExecutionPlanType : UblBaseDocumentType
    {
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Version. Identifier</para>
        /// <para>Definition: Indicates the current version of the Transport Execution Plan.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Version</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// <para>Examples: 1.1</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType VersionID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Copy_ Indicator. Indicator</para>
        /// <para>Definition: Indicates whether this document is a copy (true) or not (false).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Copy</para>
        /// <para>PropertyTerm: Indicator</para>
        /// <para>RepresentationTerm: Indicator</para>
        /// <para>DataType: Indicator. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IndicatorType CopyIndicator { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. UUID. Identifier</para>
        /// <para>Definition: A universally unique identifier for an instance of this document.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: UUID</para>
        /// <para>RepresentationTerm: Identifier</para>
        /// <para>DataType: Identifier. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public IdentifierType UUID { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Issue Date. Date</para>
        /// <para>Definition: The date, assigned by the sender, on which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Issue Date</para>
        /// <para>RepresentationTerm: Date</para>
        /// <para>DataType: Date. Type</para>
        /// <para>AlternativeBusinessTerms: Transport Document Date</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public DateType IssueDate { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Issue Time. Time</para>
        /// <para>Definition: The time, assigned by the sender, at which this document was issued.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Issue Time</para>
        /// <para>RepresentationTerm: Time</para>
        /// <para>DataType: Time. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TimeType IssueTime { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Document Status Code. Code</para>
        /// <para>Definition: A code signifying the status of the Transport Execution Plan (updated, cancelled, confirmed, etc.)</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Document Status Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataTypeQualifier: Document Status</para>
        /// <para>DataType: Document Status_ Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentStatusCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Document Status Reason Code. Code</para>
        /// <para>Definition: A code signifying a reason associated with the status of a Transport Execution Plan.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Document Status Reason Code</para>
        /// <para>RepresentationTerm: Code</para>
        /// <para>DataType: Code. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public CodeType DocumentStatusReasonCode { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Document Status Reason Description. Text</para>
        /// <para>Definition: A reason for the status assigned to the Transport Execution Plan, expressed in text.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Document Status Reason Description</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// <para>Examples: 123 Standard Chartered Tower</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("DocumentStatusReasonDescription", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] DocumentStatusReasonDescription { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Note. Text</para>
        /// <para>Definition: Free-form text pertinent to this document, conveying information that is not contained explicitly in other structures.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Note</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Note", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] Note { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport User_ Remarks. Text</para>
        /// <para>Definition: Remarks from the transport user regarding the transport operations referred to in the Transport Execution Plan.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport User</para>
        /// <para>PropertyTerm: Remarks</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TransportUserRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] TransportUserRemarks { get; set; }
        
        /// <summary>
        /// ComponentType: BBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport Service Provider_ Remarks. Text</para>
        /// <para>Definition: Remarks from the transport service provider regarding the transport operations referred to in the Transport Execution Plan.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport Service Provider</para>
        /// <para>PropertyTerm: Remarks</para>
        /// <para>RepresentationTerm: Text</para>
        /// <para>DataType: Text. Type</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TransportServiceProviderRemarks", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2")]
        public TextType[] TransportServiceProviderRemarks { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Sender_ Party. Party</para>
        /// <para>Definition: The party sending this document (can be either the transport user or the transport service provider).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Sender</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType SenderParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Receiver_ Party. Party</para>
        /// <para>Definition: The party receiving this document (can be either the transport user or the transport service provider).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Receiver</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType ReceiverParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport User_ Party. Party</para>
        /// <para>Definition: The party requesting the transport service from a transport service provider.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport User</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TransportUserParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport Service Provider_ Party. Party</para>
        /// <para>Definition: The party offering the transport service based upon a request from a transport user.</para>
        /// <para>Cardinality: 1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport Service Provider</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType TransportServiceProviderParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Bill To_ Party. Party</para>
        /// <para>Definition: Describes the party that will pay for the transport service(s) provided in a Transport Execution Plan</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Bill To</para>
        /// <para>PropertyTerm: Party</para>
        /// <para>AssociatedObjectClass: Party</para>
        /// <para>RepresentationTerm: Party</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PartyType BillToParty { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Signature</para>
        /// <para>Definition: A signature applied to this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Signature</para>
        /// <para>AssociatedObjectClass: Signature</para>
        /// <para>RepresentationTerm: Signature</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public SignatureType[] Signature { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport Execution Plan Request_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to a Transport Execution Plan Request.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport Execution Plan Request</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType TransportExecutionPlanRequestDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport Execution Plan_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an original Transport Execution Plan.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport Execution Plan</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType TransportExecutionPlanDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport Service Description_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to the Transport Service Description, which is used by a transport service provider to announce transport services to transport users (buyers).</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport Service Description</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType TransportServiceDescriptionDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Additional_ Document Reference. Document Reference</para>
        /// <para>Definition: A reference to an additional document associated with this document.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Additional</para>
        /// <para>PropertyTerm: Document Reference</para>
        /// <para>AssociatedObjectClass: Document Reference</para>
        /// <para>RepresentationTerm: Document Reference</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDocumentReference", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public DocumentReferenceType[] AdditionalDocumentReference { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport_ Contract. Contract</para>
        /// <para>Definition: A contract related to the Transport Execution Plan.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport</para>
        /// <para>PropertyTerm: Contract</para>
        /// <para>AssociatedObjectClass: Contract</para>
        /// <para>RepresentationTerm: Contract</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ContractType TransportContract { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport Service Provider Response Required_ Period. Period</para>
        /// <para>Definition: Describes the deadline for when the Transport Service Provider will have to respond to a Transport Execution Plan .</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport Service Provider Response Required</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType TransportServiceProviderResponseRequiredPeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport User Response Required_ Period. Period</para>
        /// <para>Definition: Describes the deadline for when the Transport User will have to respond to a Transport Execution Plan suggested by a Transport Service Provider.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Transport User Response Required</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("TransportUserResponseRequiredPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] TransportUserResponseRequiredPeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Validity_ Period. Period</para>
        /// <para>Definition: A period during which the Transport Execution Plan is valid.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Validity</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("ValidityPeriod", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType[] ValidityPeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Main_ Transportation Service. Transportation Service</para>
        /// <para>Definition: Description of the main transportation service referenced in the Transport Execution Plan.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Main</para>
        /// <para>PropertyTerm: Transportation Service</para>
        /// <para>AssociatedObjectClass: Transportation Service</para>
        /// <para>RepresentationTerm: Transportation Service</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TransportationServiceType MainTransportationService { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Additional_ Transportation Service. Transportation Service</para>
        /// <para>Definition: A description of an additional transportation service referenced in the Transport Execution Plan.</para>
        /// <para>Cardinality: 0..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Additional</para>
        /// <para>PropertyTerm: Transportation Service</para>
        /// <para>AssociatedObjectClass: Transportation Service</para>
        /// <para>RepresentationTerm: Transportation Service</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalTransportationService", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TransportationServiceType[] AdditionalTransportationService { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Service Start Time_ Period. Period</para>
        /// <para>Definition: The period within which the service must begin.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Service Start Time</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType ServiceStartTimePeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Service End Time_ Period. Period</para>
        /// <para>Definition: The period during which the service must be completed.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: Service End Time</para>
        /// <para>PropertyTerm: Period</para>
        /// <para>AssociatedObjectClass: Period</para>
        /// <para>RepresentationTerm: Period</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public PeriodType ServiceEndTimePeriod { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. From_ Location. Location</para>
        /// <para>Definition: The location of origin of the transport service referenced in the Transport Execution Plan.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: From</para>
        /// <para>PropertyTerm: Location</para>
        /// <para>AssociatedObjectClass: Location</para>
        /// <para>RepresentationTerm: Location</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LocationType FromLocation { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. To_ Location. Location</para>
        /// <para>Definition: The destination location for the transport service referenced in the Transport Execution Plan.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: To</para>
        /// <para>PropertyTerm: Location</para>
        /// <para>AssociatedObjectClass: Location</para>
        /// <para>RepresentationTerm: Location</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LocationType ToLocation { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. At_ Location. Location</para>
        /// <para>Definition: The location of a transport service (e.g., terminal handling service) that does not require transport movement.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTermQualifier: At</para>
        /// <para>PropertyTerm: Location</para>
        /// <para>AssociatedObjectClass: Location</para>
        /// <para>RepresentationTerm: Location</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public LocationType AtLocation { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Transport Execution Terms</para>
        /// <para>Definition: A description of terms and conditions related to the Transport Execution Plan.</para>
        /// <para>Cardinality: 0..1</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Transport Execution Terms</para>
        /// <para>AssociatedObjectClass: Transport Execution Terms</para>
        /// <para>RepresentationTerm: Transport Execution Terms</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public TransportExecutionTermsType TransportExecutionTerms { get; set; }
        
        /// <summary>
        /// ComponentType: ASBIE
        /// <para>DictionaryEntryName: Transport Execution Plan. Consignment</para>
        /// <para>Definition: A description of an identifiable collection of goods items to be transported between the consignor and the consignee. This information may be defined within a transport contract. A consignment may comprise more than one shipment (e.g., when consolidated by a freight forwarder).</para>
        /// <para>Cardinality: 1..n</para>
        /// <para>ObjectClass: Transport Execution Plan</para>
        /// <para>PropertyTerm: Consignment</para>
        /// <para>AssociatedObjectClass: Consignment</para>
        /// <para>RepresentationTerm: Consignment</para>
        /// </summary>
        [System.Xml.Serialization.XmlElementAttribute("Consignment", Namespace = "urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2")]
        public ConsignmentType[] Consignment { get; set; }
    }
}
