namespace GoLoginTools.POCO
{
	public class NavigatorModel
	{
        public string userAgent { get; set; }
        public string resolution { get; set; }
        public string language { get; set; } = "en-GB,en-US;q=0.9,en;q=0.8";
        public string platform { get; set; }
        public bool doNotTrack { get; set; } = false;
        public int harewareConcurrency { get; set; } = 0;
        public int deviceMemory { get; set; } = 1;
        public int maxTouchPoints { get; set; } = 0;
    }
}