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
    
    /// <summary>
    /// Content of the webhook posted to the external URL
    /// </summary>
    public class WebhookPayloadTrack
    {

        /// <summary>
        /// Type of event that triggered the webhook.
        /// </summary>
        [JsonProperty("event")]
        public WebhookEventTypeEnum? Event { get; set; }

        /// <summary>
        /// Determines whether the webhook is a test webhook or not.
        /// </summary>
        [JsonProperty("test")]
        public bool? Test { get; set; }

        [JsonProperty("data")]
        public Track? Data { get; set; }
    }
}