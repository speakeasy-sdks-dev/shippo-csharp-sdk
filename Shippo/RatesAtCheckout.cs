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
    /// Rates at checkout is a tool for merchants to display up-to-date shipping estimates based on what&apos;s in their customers cart and where they’re shipping to.<br/>
    /// 
    /// <remarks>
    /// Merchants set up curated shipping options for customers in the checkout flow based on data in the shopping cart. The request must include the **to** address and item information. Optional fields are the **from** address and package information. If the optional fields are not included, the service will use the default address and/or package configured for rates at checkout. The response is a list of shipping options based on the Service Group configuration.<br/>
    /// (see &lt;a href=&quot;#tag/Service-Groups&quot;&gt;Service Group configuration&lt;/a&gt; for details).<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/LiveRate&quot;/&gt;<br/>
    /// <br/>
    /// <br/>
    /// # Default Parcel Template<br/>
    /// Assign one of your user parcel templates to be the default used when generating Live Rates. This template will be used by default when generating Live Rates, unless you explicitly provide a parcel in the Live Rates request.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/UserParcelTemplate&quot;/&gt;
    /// </remarks>
    /// </summary>
    public interface IRatesAtCheckout
    {

        /// <summary>
        /// Generate a live rates request
        /// 
        /// <remarks>
        /// Initiates a live rates request. Include either the object ID for<br/>
        /// an existing address record or a fully formed address object when entering<br/>
        /// an address value. You can also enter the object ID of an existing user parcel<br/>
        /// template or a fully formed user parcel template object as the parcel value.
        /// </remarks>
        /// </summary>
        Task<LiveRatePaginatedList> CreateAsync(LiveRateCreateRequest liveRateCreateRequest, string? shippoApiVersion = null);

        /// <summary>
        /// Show current default parcel template
        /// 
        /// <remarks>
        /// Retrieve and display the currently configured default parcel template for live rates.
        /// </remarks>
        /// </summary>
        Task<DefaultParcelTemplate> GetDefaultParcelTemplateAsync(string? shippoApiVersion = null);

        /// <summary>
        /// Update default parcel template
        /// 
        /// <remarks>
        /// Update the currently configured default parcel template for live rates. The object_id in the request payload should identify the user parcel template to be the new default.
        /// </remarks>
        /// </summary>
        Task<DefaultParcelTemplate> UpdateDefaultParcelTemplateAsync(string? shippoApiVersion = null, DefaultParcelTemplateUpdateRequest? defaultParcelTemplateUpdateRequest = null);

        /// <summary>
        /// Clear current default parcel template
        /// 
        /// <remarks>
        /// Clears the currently configured default parcel template for live rates.
        /// </remarks>
        /// </summary>
        Task DeleteDefaultParcelTemplateAsync(string? shippoApiVersion = null);
    }

    /// <summary>
    /// Rates at checkout is a tool for merchants to display up-to-date shipping estimates based on what&apos;s in their customers cart and where they’re shipping to.<br/>
    /// 
    /// <remarks>
    /// Merchants set up curated shipping options for customers in the checkout flow based on data in the shopping cart. The request must include the **to** address and item information. Optional fields are the **from** address and package information. If the optional fields are not included, the service will use the default address and/or package configured for rates at checkout. The response is a list of shipping options based on the Service Group configuration.<br/>
    /// (see &lt;a href=&quot;#tag/Service-Groups&quot;&gt;Service Group configuration&lt;/a&gt; for details).<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/LiveRate&quot;/&gt;<br/>
    /// <br/>
    /// <br/>
    /// # Default Parcel Template<br/>
    /// Assign one of your user parcel templates to be the default used when generating Live Rates. This template will be used by default when generating Live Rates, unless you explicitly provide a parcel in the Live Rates request.<br/>
    /// &lt;SchemaDefinition schemaRef=&quot;#/components/schemas/UserParcelTemplate&quot;/&gt;
    /// </remarks>
    /// </summary>
    public class RatesAtCheckout: IRatesAtCheckout
    {
        public SDKConfig SDKConfiguration { get; private set; }
        private const string _language = "csharp";
        private const string _sdkVersion = "5.0.0-beta.4";
        private const string _sdkGenVersion = "2.409.5";
        private const string _openapiDocVersion = "2018-02-08";
        private const string _userAgent = "speakeasy-sdk/csharp 5.0.0-beta.4 2.409.5 2018-02-08 Shippo";
        private string _serverUrl = "";
        private ISpeakeasyHttpClient _client;
        private Func<Shippo.Models.Components.Security>? _securitySource;

        public RatesAtCheckout(ISpeakeasyHttpClient client, Func<Shippo.Models.Components.Security>? securitySource, string serverUrl, SDKConfig config)
        {
            _client = client;
            _securitySource = securitySource;
            _serverUrl = serverUrl;
            SDKConfiguration = config;
        }

        public async Task<LiveRatePaginatedList> CreateAsync(LiveRateCreateRequest liveRateCreateRequest, string? shippoApiVersion = null)
        {
            var request = new CreateLiveRateRequest()
            {
                LiveRateCreateRequest = liveRateCreateRequest,
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/live-rates";

            var httpRequest = new HttpRequestMessage(HttpMethod.Post, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "LiveRateCreateRequest", "json", false, false);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("CreateLiveRate", null, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<LiveRatePaginatedList>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    return obj!;
                }
                throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<DefaultParcelTemplate> GetDefaultParcelTemplateAsync(string? shippoApiVersion = null)
        {
            var request = new GetDefaultParcelTemplateRequest()
            {
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/live-rates/settings/parcel-template";

            var httpRequest = new HttpRequestMessage(HttpMethod.Get, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("GetDefaultParcelTemplate", null, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<DefaultParcelTemplate>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    return obj!;
                }
                throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task<DefaultParcelTemplate> UpdateDefaultParcelTemplateAsync(string? shippoApiVersion = null, DefaultParcelTemplateUpdateRequest? defaultParcelTemplateUpdateRequest = null)
        {
            var request = new UpdateDefaultParcelTemplateRequest()
            {
                ShippoApiVersion = shippoApiVersion,
                DefaultParcelTemplateUpdateRequest = defaultParcelTemplateUpdateRequest,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/live-rates/settings/parcel-template";

            var httpRequest = new HttpRequestMessage(HttpMethod.Put, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            var serializedBody = RequestBodySerializer.Serialize(request, "DefaultParcelTemplateUpdateRequest", "json", false, true);
            if (serializedBody != null)
            {
                httpRequest.Content = serializedBody;
            }

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("UpdateDefaultParcelTemplate", null, _securitySource);

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
                    var obj = ResponseBodyDeserializer.Deserialize<DefaultParcelTemplate>(await httpResponse.Content.ReadAsStringAsync(), NullValueHandling.Ignore);
                    return obj!;
                }
                throw new SDKException("Unknown content type received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }

        public async Task DeleteDefaultParcelTemplateAsync(string? shippoApiVersion = null)
        {
            var request = new DeleteDefaultParcelTemplateRequest()
            {
                ShippoApiVersion = shippoApiVersion,
            };
            request.ShippoApiVersion ??= SDKConfiguration.ShippoApiVersion;
            
            string baseUrl = this.SDKConfiguration.GetTemplatedServerUrl();

            var urlString = baseUrl + "/live-rates/settings/parcel-template";

            var httpRequest = new HttpRequestMessage(HttpMethod.Delete, urlString);
            httpRequest.Headers.Add("user-agent", _userAgent);
            HeaderSerializer.PopulateHeaders(ref httpRequest, request);

            if (_securitySource != null)
            {
                httpRequest = new SecurityMetadata(_securitySource).Apply(httpRequest);
            }

            var hookCtx = new HookContext("DeleteDefaultParcelTemplate", null, _securitySource);

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
            if(responseStatusCode == 204)
            {                
                return;
            }
            else if(responseStatusCode == 400 || responseStatusCode >= 400 && responseStatusCode < 500 || responseStatusCode >= 500 && responseStatusCode < 600)
            {
                throw new SDKException("API error occurred", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
            else
            {
                throw new SDKException("Unknown status code received", responseStatusCode, await httpResponse.Content.ReadAsStringAsync(), httpResponse);
            }
        }
    }
}