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
    using System;
    
    /// <summary>
    /// Indicates the status of the Refund.
    /// </summary>
    public enum RefundStatus
    {
        [JsonProperty("QUEUED")]
        Queued,
        [JsonProperty("PENDING")]
        Pending,
        [JsonProperty("SUCCESS")]
        Success,
        [JsonProperty("ERROR")]
        Error,
    }

    public static class RefundStatusExtension
    {
        public static string Value(this RefundStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static RefundStatus ToEnum(this string value)
        {
            foreach(var field in typeof(RefundStatus).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is RefundStatus)
                    {
                        return (RefundStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum RefundStatus");
        }
    }

}