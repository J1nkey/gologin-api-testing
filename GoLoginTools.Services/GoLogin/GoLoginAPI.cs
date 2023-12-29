using System.Net.Http.Headers;
using System.Text;
using GoLoginTools.POCO;
using GoLoginTools.Services.GoLogin.Dtos.CreateNewProfile;
using GoLoginTools.Services.GoLogin.Dtos.DeleteProfile;
using GoLoginTools.Services.GoLogin.Dtos.GetProfilesPaging;
using GoLoginTools.Services.GoLogin.Dtos.SetProxyToProfileDtos;
using Newtonsoft.Json;

namespace GoLoginTools.Services
{
    public class GoLoginAPI
	{
        private string _baseUrl = "https://api.gologin.com";
		public string _goLoginAccessToken { get; set; }
		public string _goLoginProfileId { get; set; }

        private readonly HttpClient _httpClient;

        public GoLoginAPI()
        {
           
		}

		public GoLoginAPI(string accessToken)
            :base()
        {
            _goLoginAccessToken = accessToken;
        }


        public async Task<CreateNewProfileResponse> CreateNewProfileAsync(CreateNewProfileRequest profileDto)
        {
            CreateNewProfileResponse response = new();
			HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.gologin.com");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);
            StringContent content = new(JsonConvert.SerializeObject(profileDto), Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync("/browser", content);
            
            if(httpResponse.IsSuccessStatusCode)
            {
                var httpContent = await httpResponse.Content.ReadAsStringAsync();
                return response;
            }

            var responseContent = await httpResponse.Content.ReadAsStringAsync();
			return response;
        }
        public async Task<GetProfilesPagingResponse> GetProfilesPagingAsync(GetProfilesPagingRequest request) 
        {
            GetProfilesPagingResponse response = new GetProfilesPagingResponse();

			using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);

                var httpResponse = await client.GetAsync("/browser/v2");

                if(httpResponse.IsSuccessStatusCode)
                {
                    var httpContent = await httpResponse.Content.ReadAsStringAsync();
                    response = JsonConvert.DeserializeObject<GetProfilesPagingResponse>(httpContent);

                    return response;
                }
            }

            return null;
        }
        public async Task<SetProxyToProfileResponse> SetProxyToProfileAsync(SetProxyToProfileRequest request)
        {
			SetProxyToProfileResponse response = new SetProxyToProfileResponse();

            using(HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);

				StringContent content = new(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var httpResponse = await client.PatchAsync($"/browser/{request.profileId}/proxy", content);

                var httpContent = await httpResponse.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<SetProxyToProfileResponse>(httpContent);
				return response;
			}
		}
        public async Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request)
        {
			DeleteProfileResponse response = new DeleteProfileResponse();

			using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);

                var httpResponseMessage = await client.DeleteAsync($"/browser/{request.ProfileId}");

				response = JsonConvert.DeserializeObject<DeleteProfileResponse>(await httpResponseMessage.Content.ReadAsStringAsync());

                if(response.statusCode == 204 || httpResponseMessage.IsSuccessStatusCode)
                    return response;
            }

            return null;
        }
    }
}