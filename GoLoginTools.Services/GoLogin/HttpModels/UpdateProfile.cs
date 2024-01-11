using GoLoginTools.POCO;
namespace GoLoginTools.Services.GoLogin.HttpModels
{
    public class UpdateProfileRequest
    {
        public string id { get; set; }
        public string name { get; set; }
        public string notes { get; set; }
        public bool proxyEnable { get; set; }
        public string browserType { get; set; } = "chrome";
        public string startUrl { get; set; }
        public bool googleServicesEnabled { get; set; }
        public string os { get; set; } = "win";
        public NavigatorModel navigator { get; set; }
        public ProxyModel proxy { get; set; }
        public StorageModel storage { get; set; }
        public TimeZoneModel timezone { get; set; }
        public WebGlModel webGL { get; set; }
        public CanvasModel canvas { get; set; }
        public WebGlMetadataModel webGLMetadata { get; set; }
        public WebRTCModel webRTC { get; set; }
        public FontsModel fonts { get; set; }

    }
    public class UpdateProfileResponse : BaseHttpResponse
    {
        public string name { get; set; }
        public string role { get; set; }
        public string id { get; set; }
        public string browserType { get; set; }
        public bool canBeRunning { get; set; }
        public bool isRunDisabled { get; set; }
        public string runDisabledReason { get; set; }
    }
}
