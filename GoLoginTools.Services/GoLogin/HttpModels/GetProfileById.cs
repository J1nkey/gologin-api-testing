using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.HttpModels
{
    public class GetProfileByIdRequest
    {
        public string Id { get; set; }
    }

    public class GetProfileByIdResponse : BaseHttpResponse
    {
        public string name { get; set; }
        public string notes { get; set; }
        public string startUrl { get; set; }
        public string id { get; set; }
        public string browserType { get; set; }
        public string os { get; set; }
        public bool canBeRunning { get; set; }
        public bool googleServiceEnabled { get; set; } = false;
        public bool proxyEnable { get; set; }
        public NavigatorModel navigator { get; set; }
        public ProxyModel proxy { get; set; }
        public CanvasModel canvas { get; set; }
        public WebRTCModel webRTC { get; set; }
        public StorageModel storage { get; set; }
        public FontsModel fonts { get; set; }
        public WebGlModel webGL { get; set; }
        public WebGlMetadataModel webGLMetadata { get; set; }
    }
}
