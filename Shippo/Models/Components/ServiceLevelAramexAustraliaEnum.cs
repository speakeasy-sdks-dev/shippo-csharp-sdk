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
    /// |Token | Service name|<br/>
    /// 
    /// <remarks>
    /// |:---|:---|<br/>
    /// | fastway_australia_parcel | Parcel|<br/>
    /// | fastway_australia_satchel | Satchel|<br/>
    /// | fastway_australia_box_small | Box Small|<br/>
    /// | fastway_australia_box_medium | Box Medium|<br/>
    /// | fastway_australia_box_large | Box Large|<br/>
    /// 
    /// </remarks>
    /// </summary>
    public enum ServiceLevelAramexAustraliaEnum
    {
        [JsonProperty("fastway_australia_parcel")]
        FastwayAustraliaParcel,
        [JsonProperty("fastway_australia_satchel")]
        FastwayAustraliaSatchel,
        [JsonProperty("fastway_australia_box_small")]
        FastwayAustraliaBoxSmall,
        [JsonProperty("fastway_australia_box_medium")]
        FastwayAustraliaBoxMedium,
        [JsonProperty("fastway_australia_box_large")]
        FastwayAustraliaBoxLarge,
    }

    public static class ServiceLevelAramexAustraliaEnumExtension
    {
        public static string Value(this ServiceLevelAramexAustraliaEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static ServiceLevelAramexAustraliaEnum ToEnum(this string value)
        {
            foreach(var field in typeof(ServiceLevelAramexAustraliaEnum).GetFields())
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

                    if (enumVal is ServiceLevelAramexAustraliaEnum)
                    {
                        return (ServiceLevelAramexAustraliaEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum ServiceLevelAramexAustraliaEnum");
        }
    }

}