using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.HttpModels
{
    public class SetProxyToProfileRequest
    {
        public int profileId { get; set; }
        public string autoProxyRegion { get; set; } = "us";
        public string torProxyRegion { get; set; } = "us";
        public string mode { get; set; } = "http";
        public string host { get; set; }
        public int port { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }

    public class SetProxyToProfileResponse : BaseHttpResponse
    {
        public string name { get; set; }
        public string role { get; set; }
        public string id { get; set; }
        public string browserType { get; set; }
        public TimeZoneModel timezone { get; set; }
        public NavigatorModel navigator { get; set; }
        public bool canBeRunning { get; set; }
        public bool isRunDisabled { get; set; }
        public string runDisabledReason { get; set; }
        public ProxyModel proxy { get; set; }
        public string status { get; set; }
    }
}
