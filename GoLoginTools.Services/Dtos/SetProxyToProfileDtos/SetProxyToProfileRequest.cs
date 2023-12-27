namespace GoLoginTools.Services.Dtos.SetProxyToProfileDtos
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
}
