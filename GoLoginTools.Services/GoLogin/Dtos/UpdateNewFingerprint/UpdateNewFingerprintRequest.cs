namespace GoLoginTools.Services.GoLogin.Dtos.UpdateNewFingerprint
{
	public class UpdateNewFingerprintRequest
	{
        public string resolution { get; set; } = "1280x720";
        public string language { get; set; } = "en-US";
        public string[] browserIds { get; set; }
    }
}
