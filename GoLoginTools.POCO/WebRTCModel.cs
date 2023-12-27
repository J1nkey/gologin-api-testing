using GoLoginTools.POCO.Enumerables;

namespace GoLoginTools.POCO
{
	public class WebRTCModel
	{
        public string mode { get; set; } = WebRTCMode.alert.ToString();
        public bool enabled { get; set; } = true;
        public bool customize { get; set; } = true;
        public bool localIPMasking { get; set; } = false;
        public bool fillBasedOnIp { get; set; } = true;
        public string publicIP { get; set; }
        public string[] localIps { get; set; }
    }
}
