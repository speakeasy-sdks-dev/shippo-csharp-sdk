//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo.Models.Requests
{
    using Newtonsoft.Json;
    using Shippo.Utils;
    using System;
    
    /// <summary>
    /// filter by specific carrier
    /// </summary>
    public enum Carrier
    {
        [JsonProperty("ups")]
        Ups,
        [JsonProperty("usps")]
        Usps,
        [JsonProperty("canada_post")]
        CanadaPost,
    }

    public static class CarrierExtension
    {
        public static string Value(this Carrier value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Carrier ToEnum(this string value)
        {
            foreach(var field in typeof(Carrier).GetFields())
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

                    if (enumVal is Carrier)
                    {
                        return (Carrier)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Carrier");
        }
    }

}