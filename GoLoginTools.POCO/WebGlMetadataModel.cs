using GoLoginTools.POCO.Enumerables;

namespace GoLoginTools.POCO
{
	public class WebGlMetadataModel
	{
        public string mode { get; set; } = WebGlMetadataMode.mask.ToString();
        public string vendor { get; set; }
        public string renderer { get; set; }
    }
}
