using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace IT.Netic.DispatchIt.Web.Portal.Helper
{
    public interface IApiHelper
    {
        string GetUrl();
        Task<HttpResponseMessage> GetAsync(string uri);
        Task<HttpResponseMessage> PostAsync(string uri, HttpContent content);
        Task<HttpResponseMessage> PutAsync(string uri, HttpContent content);
        Task<HttpResponseMessage> DeleteAsync(string uri);
    }
}
