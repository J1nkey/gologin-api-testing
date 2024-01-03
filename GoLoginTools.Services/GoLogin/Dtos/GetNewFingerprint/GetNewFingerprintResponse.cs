using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.Dtos.GetNewFingerprint
{
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
