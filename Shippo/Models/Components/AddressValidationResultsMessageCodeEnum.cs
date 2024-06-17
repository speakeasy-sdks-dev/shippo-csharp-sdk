//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
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
    
    public enum AddressValidationResultsMessageCodeEnum
    {
        [JsonProperty("verification_error")]
        VerificationError,
        [JsonProperty("unknown_street")]
        UnknownStreetLower,
        [JsonProperty("component_mismatch_error")]
        ComponentMismatchError,
        [JsonProperty("multiple_match")]
        MultipleMatch,
        [JsonProperty("sub_premise_number_invalid")]
        SubPremiseNumberInvalid,
        [JsonProperty("sub_premise_number_missing")]
        SubPremiseNumberMissing,
        [JsonProperty("premise_number_invalid")]
        PremiseNumberInvalid,
        [JsonProperty("premise_number_missing")]
        PremiseNumberMissing,
        [JsonProperty("box_number_invalid")]
        BoxNumberInvalid,
        [JsonProperty("box_number_missing")]
        BoxNumberMissing,
        [JsonProperty("pmb_number_missing")]
        PmbNumberMissing,
        [JsonProperty("postal_code_change")]
        PostalCodeChange,
        [JsonProperty("administrative_area_change")]
        AdministrativeAreaChange,
        [JsonProperty("locality_change")]
        LocalityChange,
        [JsonProperty("dependent_locality_change")]
        DependentLocalityChange,
        [JsonProperty("street_name_change")]
        StreetNameChange,
        [JsonProperty("street_type_change")]
        StreetTypeChange,
        [JsonProperty("street_directional_change")]
        StreetDirectionalChange,
        [JsonProperty("sub_premise_type_change")]
        SubPremiseTypeChange,
        [JsonProperty("sub_premise_number_change")]
        SubPremiseNumberChange,
        [JsonProperty("double_dependent_locality_change")]
        DoubleDependentLocalityChange,
        [JsonProperty("subadministrative_area_change")]
        SubadministrativeAreaChange,
        [JsonProperty("subnational_area_change")]
        SubnationalAreaChange,
        [JsonProperty("po_box_change")]
        PoBoxChange,
        [JsonProperty("premise_type_change")]
        PremiseTypeChange,
        [JsonProperty("house_number_change")]
        HouseNumberChange,
        [JsonProperty("organization_change")]
        OrganizationChange,
        [JsonProperty("extraneous_information")]
        ExtraneousInformation,
        [JsonProperty("usps_door_inaccessible")]
        UspsDoorInaccessible,
        [JsonProperty("administrative_area_partial")]
        AdministrativeAreaPartial,
        [JsonProperty("city_partial")]
        CityPartial,
        [JsonProperty("street_partial")]
        StreetPartial,
        [JsonProperty("building_partial")]
        BuildingPartial,
        [JsonProperty("subpremise_partial")]
        SubpremisePartial,
        [JsonProperty("administrative_area_full")]
        AdministrativeAreaFull,
        [JsonProperty("city_full")]
        CityFull,
        [JsonProperty("thoroughfare_full")]
        ThoroughfareFull,
        [JsonProperty("premises_full")]
        PremisesFull,
        [JsonProperty("subpremise_full")]
        SubpremiseFull,
        [JsonProperty("geocoded_street")]
        GeocodedStreet,
        [JsonProperty("geocoded_neighborhood")]
        GeocodedNeighborhood,
        [JsonProperty("geocoded_community")]
        GeocodedCommunity,
        [JsonProperty("geocoded_state")]
        GeocodedState,
        [JsonProperty("geocoded_rooftop")]
        GeocodedRooftop,
        [JsonProperty("geocoded_interpolated_rooftop")]
        GeocodedInterpolatedRooftop,
        [JsonProperty("invalid_postal_code")]
        InvalidPostalCode,
        [JsonProperty("postal_code_not_found")]
        PostalCodeNotFound,
        [JsonProperty("empty_request")]
        EmptyRequest,
        [JsonProperty("service_error")]
        ServiceError,
        [JsonProperty("street_detail_missing")]
        StreetDetailMissing,
        [JsonProperty("Invalid City/State/Zip")]
        InvalidCityStateZip,
        [JsonProperty("Default Match")]
        DefaultMatch,
        [JsonProperty("Unknown Street")]
        UnknownStreetMixed,
        [JsonProperty("Address Not Found")]
        AddressNotFound,
        [JsonProperty("Non-Deliverable ZIP4")]
        NonDeliverableZip4,
        [JsonProperty("Multiple Responses")]
        MultipleResponses,
        [JsonProperty("Invalid Dual Address")]
        InvalidDualAddress,
        [JsonProperty("Invalid State")]
        InvalidState,
        [JsonProperty("Invalid City")]
        InvalidCity,
        [JsonProperty("Ambiguous Address")]
        AmbiguousAddress,
    }

    public static class AddressValidationResultsMessageCodeEnumExtension
    {
        public static string Value(this AddressValidationResultsMessageCodeEnum value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static AddressValidationResultsMessageCodeEnum ToEnum(this string value)
        {
            foreach(var field in typeof(AddressValidationResultsMessageCodeEnum).GetFields())
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

                    if (enumVal is AddressValidationResultsMessageCodeEnum)
                    {
                        return (AddressValidationResultsMessageCodeEnum)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum AddressValidationResultsMessageCodeEnum");
        }
    }

}