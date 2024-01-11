using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.HttpModels
{
    public class CreateNewProfileRequest
    {
        public string name { get; set; }
        public string notes { get; set; }
        public string browserType { get; set; } = "chrome";
        public string os { get; set; } = "win";
        public string startUrl { get; set; } = "google.com";
        public NavigatorModel navigator { get; set; }
        public bool proxyEnable { get; set; }
        public ProxyModel proxy { get; set; }
        public string dns { get; set; }
        public WebRTCModel webRTC { get; set; }
        public bool GoogleServiceEnabled { get; set; } = false;
        public bool lockEnabled { get; set; } = false;
        public bool debugMode { get; set; } = false;
        public int geoProxyInfo { get; set; }
        public StorageModel storage { get; set; }
        public PluginsModel plugins { get; set; }
        public TimeZoneModel timezone { get; set; }
        public CanvasModel canvas { get; set; }
        public FontsModel fonts { get; set; }
        public MediaDevicesModel mediaDevices { get; set; }
        public WebGlModel webGL { get; set; }
        public string profile { get; set; }
        public string googleClientId { get; set; }
        public bool updateExtensions { get; set; } = true;
        public string[] chromeExtensions { get; set; }
        public WebGlMetadataModel webGLMetadata { get; set; }
        public AudioContextModel audioContext { get; set; }
    }

    public class CreateNewProfileResponse : BaseHttpResponse
    {

    }
}
