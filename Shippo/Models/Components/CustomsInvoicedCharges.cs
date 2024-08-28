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
    using Shippo.Utils;
    
    /// <summary>
    /// Additional invoiced charges to be shown on the Customs Declaration Commercial Invoice.
    /// </summary>
    public class CustomsInvoicedCharges
    {

        /// <summary>
        /// Currency for the invoiced charges amounts incurred on the end consumer.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; } = default!;

        /// <summary>
        /// Total shipping paid by the buyer.
        /// </summary>
        [JsonProperty("total_shipping")]
        public string? TotalShipping { get; set; }

        /// <summary>
        /// Total taxes paid by the buyer.
        /// </summary>
        [JsonProperty("total_taxes")]
        public string? TotalTaxes { get; set; }

        /// <summary>
        /// Total duties paid by the buyer.
        /// </summary>
        [JsonProperty("total_duties")]
        public string? TotalDuties { get; set; }

        /// <summary>
        /// Other fees paid by the buyer.
        /// </summary>
        [JsonProperty("other_fees")]
        public string? OtherFees { get; set; }
    }
}