﻿using System.Net.Http.Headers;
using System.Text;
using GoLoginTools.POCO;
using GoLoginTools.Services.GoLogin.Dtos.CreateNewProfile;
using GoLoginTools.Services.GoLogin.Dtos.DeleteProfile;
using GoLoginTools.Services.GoLogin.Dtos.GetNewFingerprint;
using GoLoginTools.Services.GoLogin.Dtos.GetProfilesPaging;
using GoLoginTools.Services.GoLogin.Dtos.SetProxyToProfileDtos;
using GoLoginTools.Services.GoLogin.Dtos.UpdateNewFingerprint;
using GoLoginTools.Services.GoLogin.Dtos.UpdateProfile;
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


        public async Task<CreateNewProfileResponse> CreateNewProfileAsync(CreateNewProfileRequest request)
        {
            CreateNewProfileResponse response = new();
			HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.gologin.com");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);
            StringContent content = new(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

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
        public async Task<GetNewFingerprintResponse> GetNewFingerprintAsync(GetNewFingerprintRequest request)
        {
            GetNewFingerprintResponse responseContent = new();

			using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);

                string requestParams = $"{nameof(request.os)}={request.os}&{nameof(request.resolution)}={request.resolution}&{nameof(request.isM1)}={request.isM1}";
                var httpMessage = await client.GetAsync($"/browser/fingerprint?{requestParams}");
                var httpContent = await httpMessage.Content.ReadAsStringAsync();

                try
                {
					responseContent = JsonConvert.DeserializeObject<GetNewFingerprintResponse>(httpContent);
					return responseContent;
				}
                catch(Exception ex)
                {
                    responseContent.statusCode = 500;
                    responseContent.message = "Deserializing response failure!!";
                }

                return responseContent;
			}

		}
        public async Task<UpdateNewFingerprintResponse> UpdateNewFingerprintAsync(UpdateNewFingerprintRequest request)
        {
            UpdateNewFingerprintResponse response = new();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);
                StringContent requestContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

                var httpMessage = await client.PatchAsync("/browser/fingerprints", requestContent);
                var responseContent = await httpMessage.Content.ReadAsStringAsync();

                try
                {
					response = JsonConvert.DeserializeObject<UpdateNewFingerprintResponse>(responseContent);
                    return response;
				}
                catch(Exception ex)
                {
                    response.statusCode = 500;
                    response.message = ex.Message;
                }
                return response;
			}

		}
        public async Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request)
        {
			UpdateProfileResponse response = new();

			using (HttpClient client = new HttpClient())
			{
				client.BaseAddress = new Uri(_baseUrl);
				client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);
				StringContent requestContent = new StringContent(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

				var httpMessage = await client.PutAsync($"/browser/{request.id}", requestContent);
				var responseContent = await httpMessage.Content.ReadAsStringAsync();

				try
				{
					response = JsonConvert.DeserializeObject<UpdateProfileResponse>(responseContent);
					return response;
				}
				catch (Exception ex)
				{
					response.statusCode = 500;
					response.message = ex.Message;
				}
				return response;
			}
		}
    }
}