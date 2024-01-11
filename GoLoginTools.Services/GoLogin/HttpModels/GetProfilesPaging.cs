using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.HttpModels
{
    public class GetProfilesPagingRequest
    {
        public int Limit { get; set; }
        public int Page { get; set; }
    }

    public class GetProfilesPagingResponse : BaseHttpResponse
    {
        public List<ProfileDto> Profiles { get; set; }
        public int AllProfilesCount { get; set; }
    }

    public class ProfileDto
    {
        public string name { get; set; }
        public string role { get; set; }
        public string id { get; set; }
        public string os { get; set; }
        public bool canBeRunning { get; set; }
        public bool proxyEnable { get; set; }
        public ProxyModel proxy { get; set; }
    }
}
