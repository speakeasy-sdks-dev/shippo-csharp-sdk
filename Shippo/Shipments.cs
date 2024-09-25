//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Shippo
{
    using Newtonsoft.Json;
    using Shippo.Hooks;
    using Shippo.Models.Components;
    using Shippo.Models.Errors;
    using Shippo.Models.Requests;
    using Shippo.Utils.Retries;
    using Shippo.Utils;
    using System.Collections.Generic;
    using System.Net.Http.Headers;
    using System.Net.Http;
    using System.Threading.Tasks;
    using System;

    /// <summary>
    /// A shipment is the act of transporting goods. A shipment object contains **to** and **from** addresses, and the parcel details that you are shipping. You can use the shipment object to retrieve shipping rates and purchase a shipping label.<br/>
    /// 
    /// <remarks>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Shipment&quot;/&gt;<br/>
    ///  <br/>
    /// # Shipment Extras<br/>
    /// The following values are supported for the `extra` field of the shipment object.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/ShipmentExtra&quot;/&gt;
    /// </remarks>
    /// </summary>
    public interface IShipments
    {

        /// <summary>
        /// List all shipments
        /// 
        /// <remarks>
        /// Returns a list of all shipment objects.&lt;br&gt;&lt;br&gt;<br/>
        /// In order to filter results, you must use the below path parameters. <br/>
        /// A maximum date range of 90 days is permitted. <br/>
        /// Provided dates should be ISO 8601 UTC dates (timezone offsets are currently not supported).&lt;br&gt;&lt;br&gt;<br/>
        /// <br/>
        /// Optional path parameters:&lt;br&gt;<br/>
        ///   `object_created_gt`- object(s) created greater than a provided date time&lt;br&gt;<br/>
        ///   `object_created_gte` - object(s) created greater than or equal to a provided date time&lt;br&gt;<br/>
        ///   `object_created_lt` - object(s) created less than a provided date time&lt;br&gt;<br/>
        ///   `object_created_lte` - object(s) created less than or equal to a provided date time&lt;br&gt;<br/>
        /// <br/>
        ///   Date format examples:&lt;br&gt;<br/>
        ///     `2017-01-01`&lt;br&gt;<br/>
        ///     `2017-01-01T03:30:30` or `2017-01-01T03:30:30.5`&lt;br&gt;<br/>
        ///     `2017-01-01T03:30:30Z`&lt;br&gt;&lt;br&gt;<br/>
        /// <br/>
        ///   Example URL:&lt;br&gt;<br/>
        ///     `https://api.goshippo.com/shipments/?object_created_gte=2017-01-01T00:00:30&amp;object_created_lt=2017-04-01T00:00:30`
        /// </remarks>
        /// </summary>
        Task<ShipmentPaginatedList> ListAsync(ListShipmentsRequest? request = null);

        /// <summary>
        /// Create a new shipment
        /// 
        /// <remarks>
        /// Creates a new shipment object.
        /// </remarks>
        /// </summary>
        Task<Shipment> CreateAsync(ShipmentCreateRequest shipmentCreateRequest, string? shippoApiVersion = null);

        /// <summary>
        /// Retrieve a shipment
        /// 
        /// <remarks>
        /// Returns an existing shipment using an object ID
        /// </remarks>
        /// </summary>
        Task<Shipment> GetAsync(string shipmentId, string? shippoApiVersion = null);
    }

    /// <summary>
    /// A shipment is the act of transporting goods. A shipment object contains **to** and **from** addresses, and the parcel details that you are shipping. You can use the shipment object to retrieve shipping rates and purchase a shipping label.<br/>
    /// 
    /// <remarks>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/Shipment&quot;/&gt;<br/>
    ///  <br/>
    /// # Shipment Extras<br/>
    /// The following values are supported for the `extra` field of the shipment object.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/ShipmentExtra&quot;/&gt;
    /// </remarks>
    /// </summary>
    public class Shipments: IShipments
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.0.0-beta.5";
        private const string _sdkGenVersion = "2.422.22";
        private const string _openapiDocVersion = "2018-02-08";
        private const string _userAgent = "speakeasy-sdk/csharp 5.0.0-beta.5 2.422.22 2018-02-08 Shippo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Shippo.Models.Components.Security>? _securitySource;

        public Shipments(ISpeakeasyHttpClient client, Func<Shippo.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<ShipmentPaginatedList> ListAsync(ListShipmentsRequest? request = null)
        {
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/shipments", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("ListShipments", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<ShipmentPaginatedList>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Include);
                    return obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<Shipment> CreateAsync(ShipmentCreateRequest shipmentCreateRequest, string? shippoApiVersion = null)
        {
            var request = new CreateShipmentRequest()
            {
                ShipmentCreateRequest = shipmentCreateRequest,
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/shipments";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "ShipmentCreateRequest", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("CreateShipment", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 201)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Shipment>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    return obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }

        public async Task<Shipment> GetAsync(string shipmentId, string? shippoApiVersion = null)
        {
            var request = new GetShipmentRequest()
            {
                ShipmentId = shipmentId,
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();
            var urlString = URLBuilder.Build(baseUrl, "/shipments/{ShipmentId}", request);

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("GetShipment", null, _securitySource);

            httpRequest = await this.SDKConfiguration.Hooks.BeforeRequestAsync(new BeforeRequestContext(hookCtx), httpRequest);

            HttpResponseMessage httpResponse;
            try
            {
                httpResponse = await _client.SendAsync(httpRequest);
                int _statusCode = (int)httpResponse.StatusCode;

                if (_statusCode == 400 || _statusCode >= 400 && _statusCode < 500 || _statusCode >= 500 && _statusCode < 600)
                {
                    var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), httpResponse, null);
                    if (_httpResponse != null)
                    {
                        httpResponse = _httpResponse;
                    }
                }
            }
            catch (Exception error)
            {
                var _httpResponse = await this.SDKConfiguration.Hooks.AfterErrorAsync(new AfterErrorContext(hookCtx), null, error);
                if (_httpResponse != null)
                {
                    httpResponse = _httpResponse;
                }
                else
                {
                    throw;
                }
            }

            httpResponse = await this.SDKConfiguration.Hooks.AfterSuccessAsync(new AfterSuccessContext(hookCtx), httpResponse);

            var contentType = httpResponse.Content.Headers.ContentType?.MediaType;
            int responseStatusCode = (int)httpResponse.StatusCode;
            if(responseStatusCode == 200)
            {
                if(Utilities.IsContentTypeMatch("application/json", contentType))
                {
                    var obj = ResponseBodyDeserializer.Deserialize<Shipment>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    return obj!;
                }

                throw new Models.Errors.SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new Models.Errors.SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }

            throw new Models.Errors.SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
        }
    }
}