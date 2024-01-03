using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.Dtos.UpdateNewFingerprint
{
	public class UpdateNewFingerprintResponse : BaseHttpResponse
	{
        public string name { get; set; }
        public string role { get; set; }
        public string id { get; set; }
        public NavigatorModel navigator { get; set; }
        public bool debugMode  { get; set; }
        public bool isM1 { get; set; }
        public bool canBeRunning { get; set; }
        public bool isRunDisabled { get; set; }
        public string os { get; set; }
        public string proxyType { get; set; }
        public string proxyRegion { get; set; }
        public string status { get; set; }
        public bool proxyEnabled { get; set; }
    }
}
