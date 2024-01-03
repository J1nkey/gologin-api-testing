using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace GoLoginTools.Services.Utils.Requests
{
	public class HttpRequestResolver : IRequestResolver
	{
		public HttpClient GenerateHttpClient(string baseUrl)
		{
			return new HttpClient() { BaseAddress = new Uri(baseUrl) };
		}

		public HttpClient SetHeader(HttpClient client, string key, string value)
		{
			client.DefaultRequestHeaders.Add(key, value);
			return client;
		}

		public HttpClient SetAuthorization(HttpClient client, string authorizationType, string token) 
		{
			if (string.IsNullOrEmpty(token))
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authorizationType);
			else
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue(authorizationType, token);

			return client;
		}

		public async Task<T> HttpGetAsync<T>(HttpClient client, string url)
		{
			var httpResponseMessage = await client.GetAsync(url);
			var httpContent = await httpResponseMessage.Content.ReadAsStringAsync();

			return JsonConvert.DeserializeObject<T>(httpContent);
		}
	}
}
