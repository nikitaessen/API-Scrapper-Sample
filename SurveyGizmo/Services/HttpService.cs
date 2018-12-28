using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace SurveyGizmo.Services
{
    public class HttpService
    {
        private const string API_KEY_NAME = "x-api-key";
        private const string API_KEY_VALUE = "b140d0633f6a4d8db096ceaae7797363";

        private HttpClient _client;

        public HttpService()
        {
            _client = new HttpClient();
            SetApiKey();
        }

        public async Task<HttpResponseMessage> Get(string uri)
        {
            return await _client.GetAsync(uri);
        }

        public async Task<HttpResponseMessage> Get(Uri uri)
        {
            return await _client.GetAsync(uri);
        }

        public async Task<HttpResponseMessage> Post(HttpRequestMessage request)
        {
            return await _client.SendAsync(request);
        }

        public async Task<HttpResponseMessage> Post(Uri uri, HttpContent content)
        {
            return await _client.PostAsync(uri, content);
        }

        public void SetRequestHeader(string headerName, string value)
        {
            _client.DefaultRequestHeaders.Add(headerName, value);
        }

        private void SetApiKey()
        {
            _client.DefaultRequestHeaders.Add(API_KEY_NAME, API_KEY_VALUE);
        }
    }
}
