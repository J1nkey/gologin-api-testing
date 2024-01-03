namespace GoLoginTools.Services.GoLogin.Dtos.GetNewFingerprint
{
	public class GetNewFingerprintRequest
	{
		public string os { get; set; } = "win";
		public string resolution { get; set; } = "1680x1050";
		public bool isM1 { get; set; } = true;
    }
}
