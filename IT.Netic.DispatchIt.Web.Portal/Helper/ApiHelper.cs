using System;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Globalization;
using Azure.Core;
using Microsoft.Identity.Client;
using Microsoft.IdentityModel.Clients.ActiveDirectory.Extensibility;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web;
using System.Threading.Tasks;

namespace IT.Netic.DispatchIt.Web.Portal.Helper
{
    public class ApiHelper : IApiHelper
    {
        private static string token = string.Empty;
        public static HttpClient ApiClient { get; set; }
        private readonly ITokenAcquisition _tokenAcquisition;


        public ApiHelper(ITokenAcquisition tokenAcquisition)
        {
            _tokenAcquisition = tokenAcquisition;
            InitializeClient();
        }

        private void InitializeClient()
        {
            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            ApiClient = new HttpClient(clientHandler);
            ApiClient.BaseAddress = new Uri(GetUrl());
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

            //ApiClient.DefaultRequestHeaders.Add("Source", "LogicApp");
        }

        public string GetUrl()
        {
            return Startup.StaticConfig.GetConnectionString("AksBackendApi");
        }

        public async Task<HttpResponseMessage> GetAsync(string uri)
        {
            string[] scopes = new string[] { "api://131f37bb-cc83-44de-a384-e7a9c78869db/access_as_user" };
            var accessToken = await _tokenAcquisition.GetAccessTokenForUserAsync(scopes);
            ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            return await ApiClient.GetAsync(uri);
        }

        public async Task<HttpResponseMessage> PostAsync(string uri, HttpContent content)
        {
            string[] scopes = new string[] { "api://131f37bb-cc83-44de-a384-e7a9c78869db/access_as_user" };
            var accessToken = await _tokenAcquisition.GetAccessTokenForUserAsync(scopes);
            ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            return await ApiClient.PostAsync(uri, content);
        }

        public async Task<HttpResponseMessage> PutAsync(string uri, HttpContent content)
        {
            string[] scopes = new string[] { "api://131f37bb-cc83-44de-a384-e7a9c78869db/access_as_user" };
            var accessToken = await _tokenAcquisition.GetAccessTokenForUserAsync(scopes);
            ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            return await ApiClient.PutAsync(uri, content);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string uri)
        {
            string[] scopes = new string[] { "api://131f37bb-cc83-44de-a384-e7a9c78869db/access_as_user" };
            var accessToken = await _tokenAcquisition.GetAccessTokenForUserAsync(scopes);
            ApiClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            return await ApiClient.DeleteAsync(uri);
        }
    }
}
