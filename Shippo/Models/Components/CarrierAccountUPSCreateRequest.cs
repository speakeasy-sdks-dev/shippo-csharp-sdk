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
    
    public class CarrierAccountUPSCreateRequest
    {

        [JsonProperty("carrier")]
        public string Carrier { get; set; } = default!;

        [JsonProperty("parameters")]
        public CarrierAccountUPSCreateRequestParameters? Parameters { get; set; }
    }
}