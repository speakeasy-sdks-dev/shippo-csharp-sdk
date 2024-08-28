//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Components
{
    using Newtonsoft.Json;
    using Shippo.Models.Components;
    using Shippo.Utils;
    using System.Collections.Generic;
    
    public class CustomsDeclarationCreateRequest
    {

        /// <summary>
        /// **required if eel_pfc is `AES_ITN`**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// AES / ITN reference of the shipment.
        /// </remarks>
        /// </summary>
        [JsonProperty("aes_itn")]
        public string? AesItn { get; set; }

        [JsonProperty("b13a_filing_option")]
        public CustomsDeclarationB13AFilingOptionEnum? B13aFilingOption { get; set; }

        /// <summary>
        /// **must be provided if and only if b13a_filing_option is provided**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Represents:&lt;br&gt; the Proof of Report (POR) Number when b13a_filing_option is `FILED_ELECTRONICALLY`;&lt;br&gt; <br/>
        /// the Summary ID Number when b13a_filing_option is `SUMMARY_REPORTING`;&lt;br&gt; <br/>
        /// or the Exemption Number when b13a_filing_option is `NOT_REQUIRED`.
        /// </remarks>
        /// </summary>
        [JsonProperty("b13a_number")]
        public string? B13aNumber { get; set; }

        /// <summary>
        /// Certificate reference of the shipment.
        /// </summary>
        [JsonProperty("certificate")]
        public string? Certificate { get; set; }

        /// <summary>
        /// Expresses that the certify_signer has provided all information of this customs declaration truthfully.
        /// </summary>
        [JsonProperty("certify")]
        public bool Certify { get; set; } = default!;

        /// <summary>
        /// Name of the person who created the customs declaration and is responsible for the validity of all <br/>
        /// 
        /// <remarks>
        /// information provided.
        /// </remarks>
        /// </summary>
        [JsonProperty("certify_signer")]
        public string CertifySigner { get; set; } = default!;

        [JsonProperty("commercial_invoice")]
        public bool? CommercialInvoice { get; set; }

        /// <summary>
        /// **required if contents_type is `OTHER`**&lt;br&gt;<br/>
        /// 
        /// <remarks>
        /// Explanation of the type of goods of the shipment.
        /// </remarks>
        /// </summary>
        [JsonProperty("contents_explanation")]
        public string? ContentsExplanation { get; set; }

        /// <summary>
        /// Disclaimer for the shipment and customs information that have been provided.
        /// </summary>
        [JsonProperty("disclaimer")]
        public string? Disclaimer { get; set; }

        /// <summary>
        /// Additional exporter identification that may be required to ship in certain countries
        /// </summary>
        [JsonProperty("exporter_identification")]
        public CustomsExporterIdentification? ExporterIdentification { get; set; }

        /// <summary>
        /// Exporter reference of an export shipment.
        /// </summary>
        [JsonProperty("exporter_reference")]
        public string? ExporterReference { get; set; }

        /// <summary>
        /// Importer reference of an import shipment.
        /// </summary>
        [JsonProperty("importer_reference")]
        public string? ImporterReference { get; set; }

        /// <summary>
        /// Indicates whether the shipment&apos;s destination VAT has been collected. May be required for some destinations.
        /// </summary>
        [JsonProperty("is_vat_collected")]
        public bool? IsVatCollected { get; set; }

        /// <summary>
        /// Invoice reference of the shipment.
        /// </summary>
        [JsonProperty("invoice")]
        public string? Invoice { get; set; }

        /// <summary>
        /// License reference of the shipment.
        /// </summary>
        [JsonProperty("license")]
        public string? License { get; set; }

        /// <summary>
        /// A string of up to 100 characters that can be filled with any additional information you <br/>
        /// 
        /// <remarks>
        /// want to attach to the object.
        /// </remarks>
        /// </summary>
        [JsonProperty("metadata")]
        public string? Metadata { get; set; }

        /// <summary>
        /// Additional notes to be included in the customs declaration.
        /// </summary>
        [JsonProperty("notes")]
        public string? Notes { get; set; }

        /// <summary>
        /// Object that represents the address of the importer
        /// </summary>
        [JsonProperty("address_importer")]
        public AddressImporter? AddressImporter { get; set; }

        [JsonProperty("contents_type")]
        public CustomsDeclarationContentsTypeEnum ContentsType { get; set; } = default!;

        [JsonProperty("eel_pfc")]
        public CustomsDeclarationEelPfcEnum? EelPfc { get; set; }

        [JsonProperty("incoterm")]
        public CustomsDeclarationIncotermEnum? Incoterm { get; set; }

        [JsonProperty("items")]
        public List<CustomsItemBase> Items { get; set; } = default!;

        [JsonProperty("non_delivery_option")]
        public CustomsDeclarationNonDeliveryOptionEnum NonDeliveryOption { get; set; } = default!;

        [JsonProperty("test")]
        public bool? Test { get; set; }
    }
}