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
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using Shippo.Utils;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    using System;
    

    public class LongitudeType
    {
        private LongitudeType(string value) { Value = value; }

        public string Value { get; private set; }
        public static LongitudeType Number { get { return new LongitudeType("number"); } }
        
        public static LongitudeType Str { get { return new LongitudeType("str"); } }
        
        public static LongitudeType Null { get { return new LongitudeType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(LongitudeType v) { return v.Value; }
        public static LongitudeType FromString(string v) {
            switch(v) {
                case "number": return Number;
                case "str": return Str;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for LongitudeType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((LongitudeType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(Longitude.LongitudeConverter))]
    public class Longitude {
        public Longitude(LongitudeType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public double? Number { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public string? Str { get; set; }

        public LongitudeType Type { get; set; }


        public static Longitude CreateNumber(double number) {
            LongitudeType typ = LongitudeType.Number;

            Longitude res = new Longitude(typ);
            res.Number = number;
            return res;
        }

        public static Longitude CreateStr(string str) {
            LongitudeType typ = LongitudeType.Str;

            Longitude res = new Longitude(typ);
            res.Str = str;
            return res;
        }

        public static Longitude CreateNull() {
            LongitudeType typ = LongitudeType.Null;
            return new Longitude(typ);
        }

        public class LongitudeConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(Longitude);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    var converted = Convert.ToDouble(json);
                    return new Longitude(LongitudeType.Number)
                    {
                        Number = converted
                    };
                }
                catch (System.FormatException)
                {
                    // try next option
                }

                if (json[0] == '"' && json[^1] == '"'){
                    return new Longitude(LongitudeType.Str)
                    {
                        Str = json[1..^1]
                    };
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                Longitude res = (Longitude)value;
                if (LongitudeType.FromString(res.Type).Equals(LongitudeType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.Number != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Number));
                    return;
                }
                if (res.Str != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Str));
                    return;
                }

            }

        }

    }
}