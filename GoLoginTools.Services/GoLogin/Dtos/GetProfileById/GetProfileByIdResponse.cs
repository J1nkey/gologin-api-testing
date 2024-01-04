using GoLoginTools.POCO;

namespace GoLoginTools.Services.GoLogin.Dtos.GetProfileById
{
    public class GetProfileByIdResponse : BaseHttpResponse
    {
        public string name { get; set; }
        public string id { get; set; }
        public string browserType { get; set; }
        public string os { get; set; }
        public bool canBeRunning { get; set; }
        public NavigatorModel navigator { get; set; }
        public ProxyModel proxy { get; set; }
    }
}
