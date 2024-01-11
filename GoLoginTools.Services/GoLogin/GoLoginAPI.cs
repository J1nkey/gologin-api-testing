using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using GoLoginTools.Services.GoLogin.HttpModels;
using Newtonsoft.Json;

namespace GoLoginTools.Services
{
    public class GoLoginAPI
    {
        private string _baseUrl = "https://api.gologin.com";
        private string _goLoginAccessToken = string.Empty;
        private string _goLoginProfileId = string.Empty;

        private readonly HttpClient _httpClient;

        public GoLoginAPI()
        {

        }

        public GoLoginAPI(string accessToken)
            : base()
        {
            _goLoginAccessToken = accessToken;
        }

        public void SetAccessToken(string newToken)
        {
            _goLoginAccessToken = newToken;
        }

        public async Task<GetProfileByIdResponse> GetProfileByIdAsync(GetProfileByIdRequest request)
        {
            GetProfileByIdResponse response = new();
            using(HttpClient client = new())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);

                var httpMessage = await client.GetAsync($"/browser/{request.Id}");
                var responseContent = await httpMessage.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<GetProfileByIdResponse>(responseContent);
            }

            return response;
        }

        public async Task<CreateNewProfileResponse> CreateNewProfileAsync(CreateNewProfileRequest request)
        {
            CreateNewProfileResponse response = new();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://api.gologin.com");
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _goLoginAccessToken);
            StringContent content = new(JsonConvert.SerializeObject(request), Encoding.UTF8, "application/json");

            var httpResponse = await client.PostAsync("/browser", content);

            if (httpResponse.IsSuccessStatusCode)
            {
                var httpContent = await httpResponse.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<CreateNewProfileResponse>(httpContent);
                return response;
            }

            var responseContent = await httpResponse.Content.ReadAsStringAsync();
            //response = JsonConvert.DeserializeObject<CreateNewProfileResponse>(responseContent);
            response.statusCode = Convert.ToInt32(httpResponse.StatusCode.ToString());
            response.message = "There're some errors was happend when created profile, see the logs to know what are occured!";
            return response;
        }
        public async Task<GetProfilesPagingResponse> GetProfilesPagingAsync(GetProfilesPagingRequest request)
        {
            GetProfilesPagingResponse response = new GetProfilesPagingResponse();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(_baseUrl);
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiI2NTk1MjE1NTFlYjQyZmZjMjJkN2U5NzEiLCJ0eXBlIjoiZGV2Iiwiand0aWQiOiI2NTk1MjM2NTljMDQwNDMxYmI1MTYzYjEifQ.Gzth4UtyZd8B4ldKJsJtVdokd8FD_YbHRHRJRK7YL9A");

                var httpResponse = await client.GetAsync("/browser/v2");

                var httpContent = await httpResponse.Content.ReadAsStringAsync();
                response = JsonConvert.DeserializeObject<GetProfilesPagingResponse>(httpContent);

                return response;
            }
        }
        public async Task<SetProxyToProfileResponse> SetProxyToProfileAsync(SetProxyToProfileRequest request)
        {
            SetProxyToProfileResponse response = new SetProxyToProfileResponse();

            using (HttpClient client = new HttpClient())
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

                if (httpResponseMessage.IsSuccessStatusCode)
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
                catch (Exception ex)
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
                catch (Exception ex)
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