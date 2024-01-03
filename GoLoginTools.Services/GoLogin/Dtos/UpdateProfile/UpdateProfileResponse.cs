namespace GoLoginTools.Services.GoLogin.Dtos.UpdateProfile
{
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
