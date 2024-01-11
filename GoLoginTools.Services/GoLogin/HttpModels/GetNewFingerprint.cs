using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.HttpModels
{
    public class GetNewFingerprintRequest
    {
        public string os { get; set; } = "win";
        public string resolution { get; set; } = "1680x1050";
        public bool isM1 { get; set; } = true;
    }

    public class GetNewFingerprintResponse : BaseHttpResponse
    {
        public NavigatorModel navigator { get; set; }
        public PluginsModel plugins { get; set; }
        public CanvasModel canvas { get; set; }
        public MediaDevicesModel mediaDevices { get; set; }
        public WebRTCModel webRTC { get; set; }
        public WebGlMetadataModel webGLMetadata { get; set; }
        public string os { get; set; }
        public int devicePixelRatio { get; set; }
        public string[] fonts { get; set; }
        public bool autoLang { get; set; }
    }
}
